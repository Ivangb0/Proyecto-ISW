using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    //asocicion unidireccional
    public partial class Paper
    {
        public Paper()
        {
            CoAuthors = new List<Person>(4);
        }

        public Paper(string title, DateTime uploadDate, Area belongingArea, User responsible) : this()
        {
            this.Title = title;
            this.UploadDate = uploadDate;
            this.Responsible = responsible;
            this.BelongingArea = belongingArea;
            // Si puede haber 0 coautores, el responsible sera el autor del articulo, pero no el coautor.
            // CoAuthors.Add(responsible);
        }

        public void AddCoAuthor(Person p)
        {
            if(CoAuthors.Count < 4)
            {
                this.CoAuthors.Add(p);
            } 
        }

        public override string ToString()
        {
            string res = "";
            res += "Titulo: " + this.Title + " " + Environment.NewLine;
            res += "Autor: " + this.Responsible.Name + " " + this.Responsible.Surname + " " + Environment.NewLine;
            res += "CoAutores: ";
            for (int i = 0; i < CoAuthors.Count - 1; i++)
            {
                res += CoAuthors.ElementAt(i).Name + CoAuthors.ElementAt(i).Surname + ",";
            }

            if (CoAuthors.Count > 0)
            {
                res += CoAuthors.ElementAt(CoAuthors.Count - 1).Name + CoAuthors.ElementAt(CoAuthors.Count - 1).Surname + " " + Environment.NewLine;
            }

            if(this.BelongingArea.PublicationPending.Contains(this))
            {
                res += "Estado: Pendiente de publicación" + Environment.NewLine;
            } 
            else if (this.Evaluation == null)
            {
                res += "Estado: Pendiente de evaluación." + Environment.NewLine;
            }
            else if (this.Evaluation.Accepted)
            {
                res += "Estado: Publicado" + Environment.NewLine;
            }
            else if (!this.Evaluation.Accepted)
            {
                res += "Estado: Rechazado" + Environment.NewLine;
            }

            return res;
        }
    }
}
