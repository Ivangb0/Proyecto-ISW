﻿using System;
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

        public Magazine(int id, string name, User chiefEditor) : this() 
        {
            this.Id = id;
            this.Name = name;
            this.ChiefEditor = chiefEditor; 
        }
    }
}