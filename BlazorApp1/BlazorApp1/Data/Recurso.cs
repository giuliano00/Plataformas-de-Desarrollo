using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
namespace BlazorApp1.Data
{
    public class Recurso
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
