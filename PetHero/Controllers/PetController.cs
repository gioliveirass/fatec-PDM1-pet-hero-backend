using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetHero.Context;
using PetHero.Models;

namespace PetHero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly DataContext _myContext;
        private readonly IConfiguration _configuration;

        public PetController(IConfiguration configuration, DataContext myContext)
        {
            _myContext = myContext;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _myContext.Pets.ToListAsync();
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Pet pet)
        {
            pet.ID = Guid.NewGuid();
            await _myContext.AddAsync(pet);
            await _myContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Pet pet)
        {
            _myContext.Update(pet);
            await _myContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _myContext.Pets.
               AsQueryable()
               .FirstOrDefaultAsync(x => x.ID == id);

            if (response == null)
            {
                return NotFound();
            }

            _myContext.Remove(response);
            await _myContext.SaveChangesAsync();

            return Ok();
        }
    }
}
