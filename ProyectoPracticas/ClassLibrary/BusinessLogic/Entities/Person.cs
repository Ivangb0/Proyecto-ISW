using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        public Person()
        {
            CoAuthoredPapers = new List<Paper>();
        }

        public Person(int id, string name, string surname) : this()
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
