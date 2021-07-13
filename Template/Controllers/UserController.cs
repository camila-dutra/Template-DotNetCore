using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SQLitePCL;
using Template.Infrastructure.Context;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly TemplateContext _context;

        public UserController(TemplateContext context)
        {
            _context = context;
        }

        //GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.User.ToListAsync());
        }

    }
}
