﻿using GestionEventosAcademicos.API.Data;
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
    }
}