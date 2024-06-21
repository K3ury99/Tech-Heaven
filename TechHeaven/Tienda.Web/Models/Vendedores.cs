using System;
using System.Collections.Generic;

namespace Tienda.Web.Models;

public partial class Vendedores
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Productos> Productos { get; set; } = new List<Productos>();
}
