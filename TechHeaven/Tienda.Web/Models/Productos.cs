using System;
using System.Collections.Generic;

namespace Tienda.Web.Models;

public partial class Productos
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public virtual ICollection<Vendedores> Vendedors { get; set; } = new List<Vendedores>();
}
