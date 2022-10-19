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
            this.Paper = new List<Paper>();

        }

        public Issue(int id, int number, DateTime? publicationDate)
        {
            Id = id;
            Number = number;
            PublicationDate = publicationDate;
        }
    }
}
