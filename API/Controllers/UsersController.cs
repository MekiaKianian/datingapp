using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);

        }

       [HttpPost]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers2()
        {
            return await _context.Users.ToListAsync();
        }
       [HttpPost("{id123}")]
        public async Task<ActionResult<AppUser>> GetUser2(int id123)
        {
            return await _context.Users.FindAsync(id123);

        }


    }
}