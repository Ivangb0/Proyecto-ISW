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

namespace InterfazProyecto
{
    public partial class EvaluarArticulo : Form
    {
        private IMagazineService service;
        private Area areaSelec;
        private ICollection<Paper> papersAreaSelec = new List<Paper>();
        

        public EvaluarArticulo(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            //En el box aparezcan todas las areas
            BoxAreas.DataSource = service.GetAllAreas();
            
        }
   
        private void EvaluarArticulo_Load(object sender, EventArgs e)
        {
            
        }

        private void BoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtenemos el area que ha sido seleccionada
            areaSelec = (Area)BoxAreas.SelectedItem;
            //Añadimos a la listBox los articulos pendientes de evaluar
            noEvaluados.DataSource = areaSelec.EvaluationPending;
        }

        private void articuloSeleccionado(object sender, EventArgs e)
        {
            
        }

        private void noEvaluados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
