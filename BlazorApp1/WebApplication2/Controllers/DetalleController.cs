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
    public class DetalleController : ControllerBase
    {
        private readonly TareasDbContext _context;

        public DetalleController(TareasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalle>>> Get()
        {
            return await _context.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).AsNoTracking().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Detalle>> GetDetail(int id)
        {
            return await _context.Detalles.Where(i => i.Id == id).AsNoTracking().SingleAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Detalle>> Post(Detalle valor)
        {
            if (valor.Id == 0)
            {
                await _context.Detalles.AddAsync(valor);
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
               
            }
            await _context.SaveChangesAsync();
            return valor;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var detail = _context.Detalles.Where(i => i.Id == id).Single();

            _context.Detalles.Remove(detail);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
