using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public bool Alerted { get; set; }
        public string AreasOfInterest { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Paper> Papers { get; set; }
        public Area Area { get; set; }  
        public Magazine Magazine { get; set; }

    }
}
