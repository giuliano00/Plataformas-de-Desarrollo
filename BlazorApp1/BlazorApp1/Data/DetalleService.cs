using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class DetalleService
    {

        private TareasDbContext ctx;

        public DetalleService(TareasDbContext _context)
        {
            ctx = _context;
        }

        public async Task<List<Detalle>> ListDetail()
        {
            return await ctx.Detalles.Include(i => i.Recurso).Include(i => i.Tarea).ToListAsync();
        }

        public async Task<Detalle> SelectDetail(int id)
        {
            return await ctx.Detalles.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Detalle> SaveDetail(Detalle value)
        {
            if (value.Id == 0)
            {
                await ctx.Detalles.AddAsync(value);
            }
            else
            {
                ctx.Detalles.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;
        }

        public async Task<bool> DeleteDetail(int id)
        {
            Detalle det = await ctx.Detalles.Where(i => i.Id == id).SingleAsync();

            ctx.Detalles.Remove(det);

            await ctx.SaveChangesAsync();

            return true;
        }

        public async Task<List<Recurso>> GetResource()
        {
            return await ctx.Recursos.ToListAsync();
        }

        public async Task<List<Tareas>> GetTask()
        {

            return await ctx.Tareas.ToListAsync();

        }
    }
}