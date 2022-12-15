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
using System.Data.Entity.Infrastructure;

namespace InterfazProyecto
{
    public partial class Registro : Form
    {
        private IMagazineService service;
        public Registro(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string login = this.RegLogin.Text;
            string password = this.RegPassword.Text;
            string id = this.RegId.Text;
            string name = this.RegName.Text;
            string surname = this.RegSurname.Text;
            bool alerted = this.RegAlerted.Checked;
            string areasOfInterest = this.RegAreasInterest.Text;
            string confPassword = this.RegConfPassword.Text;
            string email = this.RegEmail.Text;

            if (password != confPassword)
            {
                this.MensajeError.Visible = true;
                this.MensajeError.Text = "La contraseña es distinta de su confirmación";
            } 
            else 
            {
                User u = new User(id, name, surname, alerted, areasOfInterest, email, login, password);
                
                try
                {
                    service.AddUser(u);
                    service.Login(login, password);
                }
                catch (ServiceException s)
                {
                    this.MensajeError.Visible = true;
                    this.MensajeError.Text = s.Message;
                }

                //navegar a siguiente pantalla, opciones habilitadas segun sea editor jefe, editor área o autor
                this.Hide();

                Opciones o1 = new Opciones(service);
                o1.Show();
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void RegInicioSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            MagazineApp r1 = new MagazineApp(service);
            r1.Show();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
