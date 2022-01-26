using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAlpha.Context;
using ProjectAlpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectAlpha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersAPIController : ControllerBase
    {
        public readonly DBContextClass _context;
        public UsersAPIController(DBContextClass context)
        {
            _context = context;
        }

        //UsersAPI/GetUsers

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersTable>>> Get()
        {
            var users= await _context.UsersTables.ToListAsync();
            return users;
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<UsersTable>> Get(int id)
        {
            return await _context.UsersTables.FindAsync(id);
        }









    }
}
