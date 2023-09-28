using GestionEventosAcademicos.API.Data;
using GestionEventosAcademicos.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionEventosAcademicos.API.Controllers
{

    [ApiController]
    [Route("api/Events")]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;
        public EventsController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await
                _context.Events.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Event @event)
        {
            _context.Add(@event);
            await _context.SaveChangesAsync();
            return Ok(@event);
        }

        //Get Por Paràmetro
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var events = await _context.Events.FirstOrDefaultAsync(x => x.Id
            == id);
            if (events == null)
            {
                return NotFound();
            }
            return Ok(events);
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
                if (!_context.Events.Any(e => e.Id == id))
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
            var @event = await _context.Events.FindAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
