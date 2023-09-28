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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var programs = await _context.Programs.FirstOrDefaultAsync(x => x.Id== id);
            if (programs == null)
            {
                return NotFound();
            }
            return Ok(programs);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Event @event)
        {
            if (id != @event.Id)
            {
                return BadRequest();
            }

            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Programs.Any(e => e.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var @event = await _context.Programs.FindAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            _context.Programs.Remove(@event);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
