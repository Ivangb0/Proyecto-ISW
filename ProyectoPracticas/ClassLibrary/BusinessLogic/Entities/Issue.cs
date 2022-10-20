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

        public Issue(int id, int number, DateTime? publicationDate, Magazine magazine)
        {
            Id = id;
            Number = number;
            PublicationDate = publicationDate;
            Magazine = magazine;
        }
    }
}
