using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class RecursoService
    {

        private TareasDbContext ctx;

        public RecursoService(TareasDbContext _context)
        {

            ctx = _context;

        }


        public async Task<List<Recurso>> ListResource()
        {
            return await ctx.Recursos.Include(i => i.Usuario).ToListAsync();
        }

        public async Task<Recurso> SelectResource(int id)
        {
            return await ctx.Recursos.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Recurso> SaveResource(Recurso value)
        {
            if (value.Id == 0)
            {
                await ctx.Recursos.AddAsync(value);
            }
            else
            {
                ctx.Recursos.Update(value);
            }
            await ctx.SaveChangesAsync();

            return value;
        }

        public async Task<bool> DeleteResource(int id)
        {
            Recurso res = await ctx.Recursos.Where(i => i.Id == id).SingleAsync();

            ctx.Recursos.Remove(res);

            await ctx.SaveChangesAsync();

            return true;
        }

        public async Task<List<Usuario>> GetUser()
        {

            return await ctx.Usuarios.ToListAsync();

        }

    }
}