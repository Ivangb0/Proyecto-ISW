using Magazine.Services;
using Magazine.Entities;
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
    public partial class Opciones : Form
    {
        private IMagazineService service;
        public Opciones(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            User u = service.UserLogged();

            if (u.Area != null)
            {
                EvaluarArticulo.Enabled = true;
                EvaluarArticulo.Visible = true; 
            }
            else if (u.Magazine != null)
            {
                ConfeccionarEjemplar.Enabled = true;
                ConfeccionarEjemplar.Visible = true;
                ListadoDeArticulos.Enabled = true;
                ListadoDeArticulos.Visible = true;
            }
             
            EnviarArticulo.Enabled = true;
            EnviarArticulo.Visible = true;
        }

        private void Opciones_Load(object sender, EventArgs e)
        {

        }

        private void EnviarArticulo_Click(object sender, EventArgs e)
        {
            //navegar a pantalla donde puedes enviar un articulo
            this.Hide();

            EnviarArticulo r1 = new EnviarArticulo(service);
            r1.Show();
        }

        private void EvaluarArticulo_Click(object sender, EventArgs e)
        {
            //navegar a pantalla donde puedes evaluar un articulo
            this.Hide();

            EvaluarArticulo r1 = new EvaluarArticulo(service);
            r1.Show();
        }

        private void ConfeccionarEjemplar_Click(object sender, EventArgs e)
        {
            //navegar a pantalla donde puedes confeccionar un articulo
            this.Hide();

            ConfeccionarEjemplar r1 = new ConfeccionarEjemplar(service);
            r1.Show();
        }

        private void ListadoDeArticulos_Click(object sender, EventArgs e)
        {
            //navegar a pantalla donde puedes mostrar el listado de articulos
            this.Hide();

            ListadoDeArticulos r1 = new ListadoDeArticulos(service);
            r1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            service.Logout();
            // al cerrar sesion se cierra la aplicacion o saltamos a pantalla de inicio sesion
            //Application.Exit();
            this.Hide();

            MagazineApp r1 = new MagazineApp(service);
            r1.Show();
        }
    }
}
