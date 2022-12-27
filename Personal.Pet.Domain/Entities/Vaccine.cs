using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Pet.Domain.Entities
{
    public class Vaccine
    {
        public String type { get; set; }
        public DateTime GivenDate { get; set; }
        public DateTime BoostDate { get; set; }
    }
}
