using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Infrastructure.Models
{
    public class ProductoModel
    {
        public int id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Precio { get; set; } = string.Empty;
        public string Stock { get; set; } = string.Empty;
    }
}
