using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public User()
        {
            Papers = new List<Paper>();
        }

        public User(bool alerted, string areasOfInterest, string email, string login, string password) : this()
        {
            Alerted = alerted;
            AreasOfInterest = areasOfInterest;
            Email = email;
            Login = login;
            Password = password;
        }
    }
}
