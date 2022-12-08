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
        private ICollection<Area> areas = new List<Area>();
        private ICollection<Paper> papers = new List<Paper>();

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

        private void HacerArbol()
        {
            ICollection<Area> areas = service.GetAllAreas();
            foreach (Area a in areas)
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

        private void NEjemplar_TextChanged(object sender, EventArgs e)
        {
            if (NEjemplar.Text.Length == 0)
            {
                HacerArbol();
            } 
            else
            {
                ICollection<Area> areas = service.GetAllAreas();
                foreach (Area a in areas)
                {
                    ListadoArticulos.Nodes.Add(a.Name);
                    ICollection<Paper> papers = a.GetPapers();
                    foreach (Paper p in papers)
                    {
                        if (p.Issue.Id.ToString() == NEjemplar.ToString())
                        {
                            ListadoArticulos.TopNode.Nodes.Add(p.ToString());
                        }
                        else
                        {
                            MensajeError.Text = "El número de artículo no existe";
                        }
                    }
                }
            }           
        }
    }
}
