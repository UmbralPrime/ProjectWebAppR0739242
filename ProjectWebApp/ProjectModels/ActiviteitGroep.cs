using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class ActiviteitGroep
    {
        public int Id { get; set; }
        public int ActiviteitId { get; set; }
        public int GroepId { get; set; }
        public Groep Groep { get; set; }
        public Activiteit Activiteit { get; set; }
    }
}
