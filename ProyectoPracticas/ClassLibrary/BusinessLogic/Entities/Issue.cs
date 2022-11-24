using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue() 
        {
            this.PublishedPapers = new List<Paper>();

        }

        public Issue(int number, Magazine magazine) : this()
        {
            this.Number = number;
            this.Magazine = magazine;
        }

        public void AddPaper(Paper p)
        {
            this.PublishedPapers.Add(p);
        }

        public void RemovePaper(Paper p) 
        { 
            this.PublishedPapers.Remove(p); 
        }
    }
}
