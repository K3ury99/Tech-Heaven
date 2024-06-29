using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Application.Dtos.Cliente
{
    public class BaseProductoDto
    {
        [Required(ErrorMessage = "El nombre del producto es requerido.")]
        public string Nombre { get; set; }
    }
}
