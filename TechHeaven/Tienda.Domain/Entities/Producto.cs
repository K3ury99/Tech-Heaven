using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Domain.Core;

namespace Tienda.Domain.Entities
{
    public class Producto : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public string Precio { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Stock { get; set; } = string.Empty;

    }
}
