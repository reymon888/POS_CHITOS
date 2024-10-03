using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_CHITOS
{
    public class POSContext : DbContext
    {
        public POSContext(DbContextOptions<POSContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Proveedores> Proveedores { get; set; }

        public DbSet<inventario> Inventario { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<DetalleCompra> DetallesCompras { get; set; }

        public DbSet<Venta> ventas { get; set; }

        public DbSet<DetalleVenta> DetallesVentas { get; set; }

        public DbSet<EntradaEfectivo> entradaEfectivo { get; set; }



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

            

            base.OnModelCreating(modelBuilder);
        }

    }



}

