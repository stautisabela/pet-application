using Personal.Pet.Application.Interfaces;
using Personal.Pet.Domain.Entities;
using Personal.Pet.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Pet.Application
{
    public class PetService : IPetService
    {
        public PetService()
        {
                
        }
        public async Task<Domain.Entities.Pet> GetPetsAsync(string id)
        {
            var pet = new Domain.Entities.Pet
            {
                BirthDate = DateTime.Now,
                Color = "black",
                Name = "Jack",
                Sex = 'M',
                Species = PetSpeciesEnum.DOG
            };
            return pet;
        }
    }
}
