using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;
namespace BlazorApp1.Data
{
    public class RecursoService
    {
        // Metodos de Recursos 

        public async Task<List<Recurso>> ListResource()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            return await remoteService.GetAllRecurso();
        }

        public async Task<Recurso> SelectResource(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            return await remoteService.GetRecurso(id);
        }

        public async Task<Recurso> SaveResource(Recurso value)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            return await remoteService.GuardarRecurso(value);
        }

        public async Task<bool> DeleteResource(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            await remoteService.BorrarRecurso(id);
            return true;
        }

    }
}
