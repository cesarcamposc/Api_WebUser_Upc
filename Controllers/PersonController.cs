using Api_WebApplication1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonContext _db;

        public PersonController(PersonContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult> GetPeoples()
        {
            var lista = await _db.Person.OrderBy(c =>
            c.Nombre).ToListAsync();

            return Ok(lista);

        }
    }
}
