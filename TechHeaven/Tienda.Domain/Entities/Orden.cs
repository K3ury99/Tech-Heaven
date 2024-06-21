using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Domain.Core;

namespace Tienda.Domain.Entities
{
    public class Orden : BaseEntity
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public DateTime FechaOrden { get; set; }
        public ICollection<OrdenItem> OrdenItems { get; set; }
    }
}
