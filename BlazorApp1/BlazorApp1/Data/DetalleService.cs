using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Refit;
namespace BlazorApp1.Data
{
    public class DetalleService
    {

        public async Task<List<Detalle>> ListDetail()
        {          
            var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> SelectDetail(int id)
        {   
            var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            return await remoteService.GetDetalle(id);
        }

        public async Task<Detalle> SaveDetail(Detalle value)
        {          
            var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            return await remoteService.GuardarDetalle(value);
        }

        public async Task<bool> DeleteDetail(int id)
        {

        var remoteService = RestService.For<IRemoteService>("https://localhost:44314/api/");
            await remoteService.BorrarDetalle(id);
            return true;
        }
    }
}