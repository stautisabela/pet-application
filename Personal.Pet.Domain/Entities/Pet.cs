using Personal.Pet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Pet.Domain.Entities
{
    public class Pet
    {
        public string Id { get; }
        public PetSpeciesEnum Species { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public int Weight { get; set; }
        public string MicrochipNo { get; set; }
        public string Color { get; set; }
        public PetOwner Owner { get; set; }
        public ICollection<Vaccine> VaccinationCard { get; set; }
    }
}
