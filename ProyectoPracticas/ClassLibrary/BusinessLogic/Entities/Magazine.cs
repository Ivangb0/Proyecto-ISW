using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine()
        {
            Areas = new List<Area>();
            Issues = new List<Issue>();
        }

        public Magazine(string name, User chiefEditor) : this() 
        {
            this.Name = name;
            this.ChiefEditor = chiefEditor; 
        }

        public Issue LastIssueNotPublished()
        {
            Issue aux = this.Issues.Last<Issue>();
            if (DateTime.Today > aux.PublicationDate) { return new Issue(); }
            return aux;
        }
    }
}
