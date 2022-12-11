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
            CoAuthors.Add(responsible);
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
            res += "Titulo: " + this.Title + ".\n";
            res += "Autor: " + this.Responsible + ".\n";
            res += "CoAutores: ";
            for (int i = 0; i < CoAuthors.Count - 1; i++)
            {
                res += CoAuthors.ElementAt(i).Name + CoAuthors.ElementAt(i).Surname + ",";
            }

            if (CoAuthors.Count > 0)
            {
                res += CoAuthors.ElementAt(CoAuthors.Count - 1).Name + CoAuthors.ElementAt(CoAuthors.Count - 1).Surname + ". \n";
            }

            res += "Estado: " + this.Evaluation.ToString() + ".\n" ;

            return res;
        }
    }
}
