﻿using Magazine.Services;
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
    public partial class EnviarArticulo : Form
    {
        private IMagazineService service;
        private ICollection<Person> coAutors = new List<Person>();
        private string area;
        private Area a;
        public EnviarArticulo(IMagazineService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void EnviarArticulo_Load(object sender, EventArgs e)
        {
            ICollection<string> areasNombre = new List<string>();
            ICollection<Area> areas = service.GetAllAreas();
            
            foreach (Area a in areas)
            {
                areasNombre.Add(a.Name);
            }
            
            AreasBox.DataSource = areasNombre;
        }

        private void AddCoAuthor_Click(object sender, EventArgs e)
        {
            string name = CoAutorName.Text;
            string surname = CoAutorSurname.Text;
            string id = CoAutorId.Text;

            Person p = service.FindPersonByName(name, surname);
            if (p == null && id == "")
            {
                this.labelDNI.Visible = true;
                this.CoAutorId.Visible = true;
                this.MensajeError.Visible = true;
                this.MensajeError.Text = "Este autor no está registrado, proporciona su DNI para registrarlo";
            } 
            else if (p == null && id != "")
            {
                // crear nueva person y guardarlo en base de datos, y ademas añadirlo a la lista 
                p = new Person(id, name, surname);
                try
                {
                    service.AddPerson(p);
                    if (!coAutors.Contains(p) && coAutors.Count < 3)
                    {
                        coAutors.Add(p);
                        ResetFields();
                    }
                    else
                    {
                        this.MensajeError.Visible = true;
                        this.MensajeError.Text = "El autor ya pertenece a la lista de CoAutores o ya no puede haber más CoAutores";
                    }
                }
                catch (ServiceException s)
                {
                    this.MensajeError.Visible = true;
                    this.MensajeError.Text = s.Message;
                }
                
            }
            else
            {
                // p != null, añadir a una collection de person que se pasara como lista de coautores al crear el paper
                // coAutorns.Add((Person) p)
                if (!coAutors.Contains(p) && coAutors.Count < 3)
                {
                    coAutors.Add(p);
                    ResetFields();
                }
                else
                {
                    this.MensajeError.Visible = true;
                    this.MensajeError.Text = "El autor ya pertenece a la lista de CoAutores o ya no puede haber más CoAutores";
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetFields();
            this.Hide();

            Opciones o1 = new Opciones(service);
            o1.Show();
        }

        private void ResetFields()
        {
            this.labelDNI.Visible = false;
            this.CoAutorId.Visible = false;
            this.MensajeError.Visible = false;
            this.MensajeError.Text = "";
            this.CoAutorId.ResetText();
            this.CoAutorName.ResetText();
            this.CoAutorSurname.ResetText();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                a = service.FindAreaByName(area);
                string title = TituloArticulo.Text;
                if (a != null && title.Length != 0)
                {
                    User u = service.UserLogged();

                    DateTime uploadDate = DateTime.Now;

                    Paper p = new Paper(title, uploadDate, a, u);

                    //if(coAutors.Count > 0)
                    //{
                    //    p.CoAuthors = coAutors;
                    //}

                    foreach (Person coAut in coAutors)
                    {
                        p.AddCoAuthor(coAut);
                    }

                    service.AddPaper(p);

                    a.AddPaperEv(p);

                    ResetFields();

                    this.Hide();

                    Opciones o1 = new Opciones(service);
                    o1.Show();
                } 
                else
                {
                    throw new ServiceException("Introduce un título");
                }
            } 
            catch (ServiceException s)
            {
                MensajeError.Text = s.Message;
                MensajeError.Visible = true;
            }
        }

        private void AreasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = AreasBox.Text;
        }

        private void CoAutorSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
