using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Simpsons.Core.Entities;
using Simpsons.Infrastructure.Data;

namespace Simpsons.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly SimpsonsContext _context;
        public CharacterController(SimpsonsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> GetSimpsons()
        {
            var characters = await _context.Characters.ToListAsync();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingleSimpson(int id)
        {
            var simpson = await _context.Characters.FindAsync(id);
            return Ok(simpson);
        }
    }
}