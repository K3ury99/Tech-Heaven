using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Application.Dtos.Cliente
{
    public class BaseClienteDto
    {
        [Required(ErrorMessage = "El nombre del cliente es requerido.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido del cliente es requerido.")]
        public string Apellido { get; set; }
    }
}
