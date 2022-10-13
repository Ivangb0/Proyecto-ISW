using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    //asocicion unidireccional
    public partial class Paper : Evaluation  
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UploadDate DateTime { get; set; }
        public virtual ICollection<Person> CoAuthors { get; set; }
        public virtual User Resiponble { get; set; }
        public virtual Area BelongingArea { get; set; }
        public virtual Area PublicationPendingArea { get; set; }

    }
}
