using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using POS_CHITOS.Inventario;
using POS_CHITOS.Ventas;
using POS_CHITOS.Usuarios;
using POS_CHITOS.Compras;
using POS_CHITOS;

using POS_CHITOS.PI;
using POS_CHITOS.Clientes;

namespace POS_CHITOS
{
    public class POSContext : DbContext
    {
        public POSContext(DbContextOptions<POSContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }

        public DbSet<inventario> Inventario { get; set; }

        public DbSet<CategoriaInventario> CategoriasInventario { get; set; }  

        public DbSet<Compra> Compras { get; set; }

        public DbSet<DetalleCompra> DetallesCompras { get; set; }

        public DbSet<Venta> ventas { get; set; }

        public DbSet<DetalleVenta> DetallesVentas { get; set; }

        public DbSet<EntradaEfectivo> entradaEfectivo { get; set; }

        public DbSet<SalidaEfectivo> salidaEfectivo { get; set; }

        public DbSet<CortesCaja> CortesCaja { get; set; }

        public DbSet<ProveedoresInventario> ProveedoresInventario { get; set; }

        public DbSet<clientes> Clientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=POS_CHITOS;User=root;Password=1234;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir clave primaria para CortesCaja
            modelBuilder.Entity<CortesCaja>()
                .HasKey(c => c.IdCorte);

            // Configurar la relación con Usuario
            modelBuilder.Entity<CortesCaja>()
                .HasOne(c => c.Usuario)  // Relación con la clase Usuario
                .WithMany()  // Un usuario puede tener múltiples cortes
                .HasForeignKey(c => c.IdUsuario)  // FK que apunta a Usuario
                .OnDelete(DeleteBehavior.Restrict);  // Comportamiento si se elimina un usuario

            // Configuración de la relación entre ProveedoresInventario e Inventario
            modelBuilder.Entity<ProveedoresInventario>()
                .HasOne(pi => pi.Producto) // Relación con la clase Inventario
                .WithMany() // Asume que Inventario no tiene una lista de ProveedoresInventario
                .HasForeignKey(pi => pi.CodigoProducto) // Clave foránea
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración de la relación entre ProveedoresInventario y Proveedores
            modelBuilder.Entity<ProveedoresInventario>()
                .HasOne(pi => pi.Proveedor)
                .WithMany(p => p.ProveedoresInventario)
                .HasForeignKey(pi => pi.IdProveedor)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }



}

