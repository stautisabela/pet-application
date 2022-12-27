using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Pet.Domain.Entities;

namespace Personal.Pet.Application.Interfaces
{
    public interface IPetService
    {
        async Task<Domain.Entities.Pet> GetPetsAsync(string id);
    }
}
