using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class Agenda
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int ActiviteitGroepId { get; set; }
        public ActiviteitGroep ActiviteitGroep { get; set; }        
    }
}
