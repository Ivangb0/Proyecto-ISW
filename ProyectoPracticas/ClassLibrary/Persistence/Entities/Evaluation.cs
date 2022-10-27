﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation
    {
        public bool Accepted { get; set; }
        public String Comments { get; set; }
        public DateTime Date { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
