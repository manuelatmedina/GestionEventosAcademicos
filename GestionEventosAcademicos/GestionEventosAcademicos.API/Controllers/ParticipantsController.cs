using GestionEventosAcademicos.API.Data;
using GestionEventosAcademicos.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionEventosAcademicos.API.Controllers
{

    [ApiController]
    [Route("api/participants")]
    public class ParticipantsController:ControllerBase
    {

        private readonly DataContext _context;
        public ParticipantsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task <IActionResult> Get()
        {
            return Ok(await 
                _context.Participants.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Participant participant)
        {
            _context.Add(participant);
                await _context.SaveChangesAsync();
            return Ok(participant);
        }

    }
}
