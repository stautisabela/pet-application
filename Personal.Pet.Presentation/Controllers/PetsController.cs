using Microsoft.AspNetCore.Mvc;
using Personal.Pet.Application;
using Personal.Pet.Application.Interfaces;
using Personal.Pet.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Personal.Pet.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly PetService petService;
        public PetsController(PetService petService)
        {
            this.petService = petService;
        }

        // GET: api/<PetsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public async Task<Pets> GetPetByIdAsync(string id)
        {
            return await petService.GetPetsAsync(id);
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
