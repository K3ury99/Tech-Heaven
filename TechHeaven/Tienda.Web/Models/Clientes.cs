using System;
using System.Collections.Generic;

namespace Tienda.Web.Models;

public partial class Clientes
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Correo { get; set; }

    public decimal? Cedula { get; set; }

    public int? SucursalId { get; set; }

    public virtual Sucursales? Sucursal { get; set; }
}
