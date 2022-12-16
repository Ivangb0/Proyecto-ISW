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
    public partial class AñadeComentario : Form
    {
        private IMagazineService service;
        public Paper paperParaEv;
        public AñadeComentario(IMagazineService service)
        {
            InitializeComponent();
            this.service = service; 
        }

        //Metodo para que salga el nombre del paper seleccionado al lado del texto Articulo Seleccionado:
        public void PonerTituloArtSelec(String texto) 
        { 
            aparezcaTitutloArt.Text = texto; 
        }

        private void PaperAccepted(object sender, EventArgs e)
        {
            //Obtenemos el comentario que ha añadido el usuario
            String comentario = textoComentario.Text;
            
            //Obtenemos el articulo con el titulo que hemos seleccionado en evaluar articulo
            paperParaEv = service.FindPaperByTitle(aparezcaTitutloArt.Text);
            //Falta obtener el area que habia sido seleccionada en evaluar articulo y asi usar el metodo setEvPaper de la linea de abajo
            //service.setEvPaper(, paperParaEv, comentario,true);
        }

        private void PaperRejected(object sender, EventArgs e)
        {
            //Obtenemos el comentario que ha añadido el usuario
            String comentario = textoComentario.Text;
            //Obtenemos el area que habia sido seleccionada en evaluar articulo
            //Obtenemos el articulo con el titulo que hemos seleccionado en evaluar articulo
            paperParaEv = service.FindPaperByTitle(aparezcaTitutloArt.Text);
            //service.setEvPaper(, paperParaEv, comentario, true);
        }
    }
}
