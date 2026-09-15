using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetTechApi.Data;
using VetTechApi.Models;

namespace VetTechApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutoresController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TutoresController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async
            Task<ActionResult<IEnumerable<Tutor>>>
            GetProfessores()
        {
            return await _context.tutors.ToListAsync();
        }
        [HttpPost]
        public async Task<IActionResult> CriarProfessor(Tutor tutores)
        {
            _context.tutors.Add(tutores);
            await _context.SaveChangesAsync();
            return Ok("Professor salvo com sucesso!!!");
        }
    }
}
