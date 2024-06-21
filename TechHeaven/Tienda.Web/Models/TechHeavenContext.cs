using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tienda.Web.Models;

public partial class TechHeavenContext : DbContext
{
    public TechHeavenContext()
    {
    }

    public TechHeavenContext(DbContextOptions<TechHeavenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Clientes> Clientes { get; set; }

    public virtual DbSet<Productos> Productos { get; set; }

    public virtual DbSet<Sucursales> Sucursales { get; set; }

    public virtual DbSet<Vendedores> Vendedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("#");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Clientes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3213E83FC804CC45");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cedula).HasColumnType("decimal(10, 8)");
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.SucursalId).HasColumnName("SucursalID");
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK__Clientes__Sucurs__4BAC3F29");
        });

        modelBuilder.Entity<Productos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3213E83FD417AEBF");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasMany(d => d.Vendedors).WithMany(p => p.Productos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoVendedor",
                    r => r.HasOne<Vendedores>().WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ProductoV__Vende__534D60F1"),
                    l => l.HasOne<Productos>().WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ProductoV__Produ__52593CB8"),
                    j =>
                    {
                        j.HasKey("ProductoId", "VendedorId").HasName("PK__Producto__7633906F3B754482");
                        j.ToTable("ProductoVendedor");
                        j.IndexerProperty<int>("ProductoId").HasColumnName("ProductoID");
                        j.IndexerProperty<int>("VendedorId").HasColumnName("VendedorID");
                    });
        });

        modelBuilder.Entity<Sucursales>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sucursal__3213E83F48428E53");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Vendedores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vendedor__3213E83F49837925");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
