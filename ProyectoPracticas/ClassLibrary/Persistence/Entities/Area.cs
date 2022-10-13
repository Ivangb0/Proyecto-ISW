using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public ICollection<Paper> Papers { get; set; }
        public ICollection<Paper> EvaluationPending { get; set; }
        public ICollection<Paper> PublicationPending { get; set; }
        public User Editor { get; set; }
    }
}
