﻿using Magazine.Services;
using System;
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

        public Magazine(string name, User chiefEditor) : this() 
        {
            this.Name = name;
            this.ChiefEditor = chiefEditor; 
        }

        public Issue LastIssueNotPublished()
        {
            Issue aux = null;
            try
            {
                aux = this.Issues.Last<Issue>();
            } 
            catch (Exception e)
            {
                aux = null;
            }
            
            if (aux == null) { return new Issue(1, this); }
            else if (aux != null && aux.PublicationDate == null) { return new Issue(aux.Number, this); }
            else if (aux != null && DateTime.Today > aux.PublicationDate) { return new Issue(aux.Number + 1, this); }
            return aux;
        }
    }
}
