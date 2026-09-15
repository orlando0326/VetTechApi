using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTechApi.Data;
using VetTechApi.Models;

namespace VetTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        public class CursosController : ControllerBase
        {
            private readonly AppDbContext _context;
            public CursosController(AppDbContext context)
            {
                _context = context;
            }
            [HttpGet]
            public async
        Task<ActionResult<IEnumerable<Pet>>>
          GetProfessores()
            {
                return await _context.pets.ToListAsync();
            }
            [HttpPost]
            public async Task<IActionResult> CriarProfessor(Pet pets)
            {
                _context.pets.Add(pets);
                await _context.SaveChangesAsync();
                return Ok("Veterinario salvo com sucesso!!!");
            }
        }
    }
}

