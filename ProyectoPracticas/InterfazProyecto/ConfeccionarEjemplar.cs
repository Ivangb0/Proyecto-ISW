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
    public partial class ConfeccionarEjemplar : Form
    {
        private IMagazineService service;
        private Issue i1;
        private Area a;
        private ICollection<Paper> papersArea = new List<Paper>();
        private DateTime fecha;
        bool cambio;
        public ConfeccionarEjemplar(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            Magazine.Entities.Magazine m = service.GetMagazine();
            
            try
            {
                i1 = m.LastIssueNotPublished();
                service.AddIssue(i1);
                service.Commit();
            } 
            catch (ServiceException s)
            {
                MensajeError.Text = s.Message;
            }
            if (i1.PublicationDate != null)
            {
                dateTimePicker1.Value = (DateTime) i1.PublicationDate;
            }
            this.nRevista.Text = m.Id.ToString();
            ICollection<string> areasNombre = new List<string>();
            ICollection<Area> areas = service.GetAllAreas();
            foreach (Area a in areas)
            {
                //areasNombre.Add(a.Name);
                comboBoxAreas.Items.Add(a.Name);
            }
        }

        private void ConfeccionarEjemplar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArticulosPendientes.Items.Clear();
            ArticulosPublicados.Items.Clear();  
            String aarea = (String)comboBoxAreas.SelectedItem;
            Area a = service.FindAreaByName(aarea);
            
            foreach (Paper p in i1.PublishedPapers)
            {
                if(p.BelongingArea == a)
                {
                    //papersArea.Add(p);
                    ArticulosPublicados.Items.Add(p);
                }
            }

            foreach(Paper p in a.PublicationPending)
            {
                ArticulosPendientes.Items.Add(p);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Opciones o1 = new Opciones(service);
            o1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paper p = (Paper) ArticulosPendientes.SelectedItem;
            if (p != null)
            {
                MensajeError.Text = "";
                i1.AddPaper(p);
                p.BelongingArea.RemovePaperPubl(p);
                //papersArea.Add(p);
                ArticulosPublicados.Items.Add(p);
                ArticulosPendientes.Items.Remove(p);
            } else
            {
                MensajeError.Text = "Selecciona un articulo";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Paper p = (Paper) ArticulosPublicados.SelectedItem;
            if (p != null)
            {
                MensajeError.Text = "";
                i1.RemovePaper(p);
                p.BelongingArea.AddPaperPubl(p);
                //papersArea.Remove(p);
                ArticulosPublicados.Items.Remove(p);
                ArticulosPendientes.Items.Add(p);
            } else
            {
                MensajeError.Text = "Selecciona un articulo";
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if(cambio)
            {
                i1.PublicationDate = fecha;
            }    
            
            service.Commit();
                
            this.Hide();

            Opciones o1 = new Opciones(service);
            o1.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MensajeError.Text = "Fecha no válida";
            } else
            {
                fecha = dateTimePicker1.Value;
                cambio = true;
                MensajeError.Text = "";
            }
        }
    }
}
