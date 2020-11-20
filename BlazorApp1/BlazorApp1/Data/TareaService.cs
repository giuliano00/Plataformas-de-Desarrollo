using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class TareaService
    {     

        private TareasDbContext ctx;

        public TareaService(TareasDbContext _context)
        {
            ctx = _context;
        }

        public async Task<List<Tareas>> ListTask()
        {
            return await ctx.Tareas.Include(i => i.Responsable).ToListAsync();
        }

        public async Task<Tareas> SelectTask(int id)
        {
            return await ctx.Tareas.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Tareas> SaveTask(Tareas value)
        {
            if (value.Id == 0)
            {
                await ctx.Tareas.AddAsync(value);
            }
            else
            {
                ctx.Tareas.Update(value);
            }
            await ctx.SaveChangesAsync();
            return value;
        }

        public async Task<bool> DeleteTask(int id)
        {
            Tareas task = await ctx.Tareas.Where(i => i.Id == id).SingleAsync();

            ctx.Tareas.Remove(task);

            await ctx.SaveChangesAsync();
            return true;
        }

        public async Task<List<Recurso>> GetResource()
        {

            return await ctx.Recursos.ToListAsync();

        }

    }
}
