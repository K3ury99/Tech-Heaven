using System;
using System.Collections.Generic;

namespace Tienda.Web.Models;

public partial class Sucursales
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Clientes> Clientes { get; set; } = new List<Clientes>();
}
