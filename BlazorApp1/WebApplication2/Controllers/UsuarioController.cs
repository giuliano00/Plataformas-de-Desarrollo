using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Entidades;
using WebApplication2.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public UsuarioController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
            return await _context.Usuarios.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUser(int id)
        {
            return await _context.Usuarios.Where(i => i.UsuarioPK == id).AsNoTracking().SingleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Post(Usuario valor)
        {

            if (valor.UsuarioPK == 0)
            {
                _context.Usuarios.Add(valor);
            }
            else
            {
                _context.Entry(valor).State = EntityState.Unchanged;

                _context.Entry(valor).State = EntityState.Modified;

            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var user = _context.Usuarios.Where(i => i.UsuarioPK == id).Single();

            _context.Usuarios.Remove(user);

            await _context.SaveChangesAsync();

            return NoContent();
        }

      

    }
}