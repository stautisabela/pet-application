using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Pet.Domain.Entities
{
    public class Vaccine
    {
        public String Type { get; set; }
        public DateTime GivenDate { get; set; }
        public Nullable<DateTime> BoostDate { get; set; }

        public Vaccine(string type, DateTime givenDate, Nullable<DateTime> boostDate = null)
        {
            Type = type;
            GivenDate = givenDate;
            BoostDate = boostDate;
        }
    }
}
