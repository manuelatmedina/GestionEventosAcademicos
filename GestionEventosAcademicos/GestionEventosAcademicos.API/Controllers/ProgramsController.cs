using GestionEventosAcademicos.API.Data;
using GestionEventosAcademicos.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionEventosAcademicos.API.Controllers
{

    [ApiController]
    [Route("api/Programs")]
    public class ProgramsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProgramsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await
                _context.Programs.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(GestionEventosAcademicos.Shared.Entities.Program program)
        {
            _context.Add(program);
                await _context.SaveChangesAsync();
            return Ok(program);
        }
    }
}
