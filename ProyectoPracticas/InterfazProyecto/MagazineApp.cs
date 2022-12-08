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
    public partial class MagazineApp : Form
    {
        private IMagazineService service;
        public MagazineApp(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            string login = this.login.Text;
            string password = this.password.Text;
            try 
            { 
                service.Login(login, password); 
            } 
            catch (ServiceException s) 
            {
                this.MensajeError.Visible = true;
                this.MensajeError.Text = s.Message;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IrARegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Registro r1 = new Registro(service);
            r1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
