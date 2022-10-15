using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Issue> Issues { get; set; }
        public ICollection<Area> Areas { get; set; }
        public User ChiefEditor { get; set; }
    }
}
