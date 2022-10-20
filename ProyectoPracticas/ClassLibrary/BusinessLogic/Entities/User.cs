using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public User()
        {
            MainAuthoredPapers = new List<Paper>();
        }

        public User(bool alerted, string areasOfInterest, string email, string login, string password, string id, string name, string surname) : base(id, name, surname)
        {
            this.MainAuthoredPapers = new List<Paper>();
            this.Alerted = alerted;
            this.AreasOfInterest = areasOfInterest;
            this.Email = email;
            this.Login = login;
            this.Password = password;
        }
    }
}
