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

        public Issue(int id, int number, DateTime? publicationDate, Magazine magazine) : this()
        {
            this.Id = id;
            this.Number = number;
            this.PublicationDate = publicationDate;
            this.Magazine = magazine;
        }
    }
}
