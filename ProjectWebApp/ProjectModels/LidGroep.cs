using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModels
{
    public class LidGroep
    {
        public int Id { get; set; }
        public int LidId { get; set; }
        public int GroepId { get; set; }
        public Lid Lid { get; set; }
        public Groep Groep { get; set; }
    }
}
