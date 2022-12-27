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
        public Guid Id { get; }
        public PetSpeciesEnum Species { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public int Weight { get; set; }
        public string MicrochipNo { get; set; }
        public string Color { get; set; }
        public PetOwner Owner { get; set; }
        public List<Vaccine> VaccinationCard { get; set; }

        public Pet(PetSpeciesEnum species, string name, char sex, DateTime birthDate, int weight, string microchipNo, string color, PetOwner owner)
        {
            Id = Guid.NewGuid();
            Species = species;
            Name = name;
            Sex = sex;
            BirthDate = birthDate;
            Weight = weight;
            MicrochipNo = microchipNo;
            Color = color;
            Owner = owner;
            VaccinationCard = new List<Vaccine>();
        }
    }
}
