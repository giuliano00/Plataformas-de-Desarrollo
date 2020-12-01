using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
namespace ClassLibrary1.Entidades
{
    public class Recurso
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
