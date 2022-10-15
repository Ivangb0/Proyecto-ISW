using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    //asocicion unidireccional
    public partial class Paper
    {
        public Paper()
        {
            CoAuthors = new List<Person>(4);
        }

        public Paper(int id, string title, DateTime uploadDate, User responsible, Area belongingArea)
        {
            Id = id;
            Title = title;
            UploadDate = uploadDate;
            Responsible = responsible;
            BelongingArea = belongingArea;
        }
    }
}
