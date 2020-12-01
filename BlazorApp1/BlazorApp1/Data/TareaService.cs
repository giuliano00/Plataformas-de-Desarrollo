using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;
namespace BlazorApp1.Data
{
    public class TareasService
    {

        public async Task<List<Tareas>> ListTask()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetAllTareas();
        }

        public async Task<Tareas> SelectTask(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GetTareas(id);
        }

        public async Task<Tareas> SaveTask(Tareas value)
        {         
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            return await remoteService.GuardarTareas(value);
        }

        public async Task<bool> DeleteTask(int id)
        {          
            var remoteService = RestService.For<IRemoteService>("https://localhost:44373/api/");
            await remoteService.BorrarTareas(id);
            return true;
        }

    }
}