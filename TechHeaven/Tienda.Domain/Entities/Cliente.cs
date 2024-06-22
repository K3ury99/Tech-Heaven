using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Domain.Core;

namespace Tienda.Domain.Entities
{
    public class Cliente : Persona
    {
        public string Cedula { get; set; } = string.Empty;
    }
}
