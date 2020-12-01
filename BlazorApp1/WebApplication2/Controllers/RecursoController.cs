using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using ClassLibrary1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursoController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public RecursoController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recurso>>> Get()
        {
            return await _context.Recursos.Include(i => i.Usuario).AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Recurso>> GetResource(int id)
        {
            return await _context.Recursos.Where(i => i.Id == id).AsNoTracking().SingleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Recurso>> Post(Recurso valor)
        {
            if (valor.Id == 0)
            {
                await _context.Recursos.AddAsync(valor);
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
            return valor;
        }

        public async Task<IActionResult> Delete(int id)
        {
            var resource = await _context.Recursos.Where(i => i.Id == id).SingleAsync();

            _context.Recursos.Remove(resource);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
