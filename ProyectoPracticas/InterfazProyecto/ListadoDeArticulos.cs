using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazProyecto
{
    public partial class ListadoDeArticulos : Form
    {
        private IMagazineService service;

        public ListadoDeArticulos(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            ICollection<Area> areas = service.GetAllAreas();
            foreach  (Area a in areas)
            {
                ListadoArticulos.Nodes.Add(a.Name);
                ICollection<Paper> papers = a.GetPapers();
                foreach (Paper p in papers)
                {
                    ListadoArticulos.TopNode.Nodes.Add(p.ToString());
                }
            }
        }
        
        private void ListadoDeArticulos_Load(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();

            Opciones o1 = new Opciones(service);
            o1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nEjemplar = NEjemplar.Text;
            
            if(nEjemplar != "") 
            {
                ListadoArticulos.Nodes.Clear();

                ICollection<Area> areas = service.GetAllAreas();
                foreach (Area a in areas)
                {
                    // para saber que areas poner y cuales no, hacer una funcion que compruebe si alguno de sus papers 
                    // pertenece a ese ejemplar, y en caso de ser verdadero añadir el área y los papers.
                    if (a.HasPapersWithNumber(Convert.ToInt32(nEjemplar)))
                    {
                        ListadoArticulos.Nodes.Add(a.Name);
                        ICollection<Paper> papers = a.GetPapers();
                        foreach (Paper p in papers)
                        {
                            if (p.Issue.Id.ToString() == nEjemplar)
                            {
                                ListadoArticulos.TopNode.Nodes.Add(p.ToString());
                            }
                        }
                    }
                }
            }            
        }
    }
}
