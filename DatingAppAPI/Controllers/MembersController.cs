using DatingAppAPI.Data;
using DatingAppAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetMembers()
        {
            var members = await context.Users.ToListAsync();
            return Ok(members);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetMemberById(string id)
        {
            var member = await context.Users.FirstOrDefaultAsync(member => member.Id == id);
            if (member == null) return NotFound();
            return Ok(member);
        }
    }
}
