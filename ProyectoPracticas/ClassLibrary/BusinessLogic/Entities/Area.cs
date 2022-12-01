using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
       public Area()
        {
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();
        }

        public Area(String Name, User editor, Magazine magazine) : this()
        {
            this.Name = Name;
            this.Magazine = magazine;
            this.Editor = editor;
        }
        public ICollection<Paper> GetPapers()
        {
            ICollection<Paper> papeles = new List<Paper>();
            for (int i = 0; i < this.Papers.Count; i++)
            {                 
                    papeles.Add(this.Papers.ElementAt(i));                
            }

            return papeles;
        }
    }
}
