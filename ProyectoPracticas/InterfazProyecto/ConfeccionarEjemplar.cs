﻿using Magazine.Entities;
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
        Issue i1;
        Area a;
        public ConfeccionarEjemplar(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
            Magazine.Entities.Magazine m = service.GetMagazine();
            i1 = m.LastIssueNotPublished();
            this.nRevista.Text = i1.Id.ToString();
            comboBoxAreas.DataSource = service.GetAllAreas();
        }

        private void ConfeccionarEjemplar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = (Area)comboBoxAreas.SelectedItem;
            ArticulosPublicados.DataSource = i1.PublishedPapers;
            ArticulosPendientes.DataSource = a.PublicationPending;
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
            i1.PublishedPapers.Add(p);
            a.PublicationPending.Remove(p);
            ArticulosPublicados.DataSource = i1.PublishedPapers;
            ArticulosPendientes.DataSource = a.PublicationPending;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paper p = (Paper) ArticulosPublicados.SelectedItem;
            i1.PublishedPapers.Remove(p);
            a.PublicationPending.Add(p);
            ArticulosPublicados.DataSource = i1.PublishedPapers;
            ArticulosPendientes.DataSource = a.PublicationPending;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                i1.PublicationDate = dateTimePicker1.Value;

                service.Commit();
                
                this.Hide();

                Opciones o1 = new Opciones(service);
                o1.Show();
            }
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MensajeError.Text = "Fecha no válida";
            }
        }
    }
}
