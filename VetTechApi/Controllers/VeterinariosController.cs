using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTechApi.Data;
using VetTechApi.Models;

namespace VetTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinariosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public VeterinariosController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async
          Task<ActionResult<IEnumerable<Veterinario>>>
          GetProfessores()
        {
            return await _context.veterinarios.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> CriarProfessor(Veterinario veterinario)
        {
            _context.veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();
            return Ok("Veterinario salvo com sucesso!!!");
        }
    }
}

