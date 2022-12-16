using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfazProyecto
{
    public partial class EvaluarArticulo : Form
    {
        private IMagazineService service;
        private ICollection<Paper> papersAreaSelec = new List<Paper>();
        public String areaSelec;
        private String tituloSelec;


        public EvaluarArticulo(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            //En el boxAreas aparezcan todas las areas
            ICollection<string> areasNombre = new List<string>();
            ICollection<Area> areas = service.GetAllAreas();
            foreach (Area a in areas)
            {
                areasNombre.Add(a.Name);
            }
            BoxAreas.DataSource = areasNombre;
            noEvaluados.Columns.Add("Titulo", 190);
            noEvaluados.Columns.Add("Autor", 190);
            noEvaluados.Columns.Add("Fecha de envío", 100);

        }
   
        private void EvaluarArticulo_Load(object sender, EventArgs e)
        {
            
        }

        private void BoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arr = new string[3];
            ListViewItem itm;
            //Obtener el area que ha sido seleccionada
            areaSelec = BoxAreas.Text;
            //Obtener la lista de papers no evaluados del area seleccionada
            papersAreaSelec = service.ReturnEvaluationPending(areaSelec);
            //Añadir los items al listView noEvaluados cada uno en su columna
            foreach (Paper p in papersAreaSelec)
            {
                arr[0] = p.Title;
                arr[1] = p.Responsible.Name;
                arr[2] = p.UploadDate.ToString();
                itm = new ListViewItem(arr);
                noEvaluados.Items.Add(itm);
            }
        }

        private void PaperSeleccionado(object sender, EventArgs e)
        {
            //Comprobar que hay items en la listView
            if (noEvaluados.Items.Count > 0)
            {

                //Pulsemos en la columna que pulsemos que coja el titulo del paper seleccionado
                tituloSelec = noEvaluados.SelectedItems[0].ToString();
                AñadeComentario modif = new AñadeComentario(service);
                modif.PonerTituloArtSelec(tituloSelec);
                modif.ShowDialog();
            }
        }
    }
}
