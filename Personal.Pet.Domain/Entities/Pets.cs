using Personal.Pet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Pet.Domain.Entities
{
    public class Pets
    {
        public PetSpeciesEnum Species { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Color { get; set; }
    }
}
