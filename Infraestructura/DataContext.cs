using Facturacion.Conexion;
using Facturacion.Dominio.Entities;

namespace Infraestructura
{
    using Facturacion.Dominio.Entities;
    using Facturacion.Dominio.MetaData;
    using Microsoft.EntityFrameworkCore;
    using System.IO.Compression;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;
    using System.Threading.Tasks;
    using static ConexionBD; 
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConexionSql);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFks = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);


            foreach (var fk in cascadeFks)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //Caja

            modelBuilder.Entity<Caja>().HasMany(x => x.Movimientos).WithOne(x => x.Caja)
               .HasForeignKey(x => x.CajaId);

            modelBuilder.Entity<Caja>().HasMany(x => x.DetalleDeCajas).WithOne(x => x.Caja)
                .HasForeignKey(x => x.CajaId);

            //Carrito

            modelBuilder.Entity<Carrito>().HasMany(x => x.DetalleFacturas).WithOne(x => x.Carrito)
                .HasForeignKey(x => x.CarritoId);

            modelBuilder.Entity<Carrito>().HasOne(x => x.Usuario).WithMany(x => x.Carritos)
                .HasForeignKey(x => x.UsuarioId);

            //Categoria
            modelBuilder.Entity<Categoria>().HasMany(x => x.Productos)
                .WithOne(x => x.Categoria)
                .HasForeignKey(x => x.CategoriaId);


            //Cliente

            modelBuilder.Entity<Cliente>().HasOne(x => x.Usuario)
                .WithOne(x => x.Cliente)
                .HasForeignKey<Cliente>(x => x.UsuarioId);

            modelBuilder.Entity<Cliente>().HasMany(x => x.FacturaVentas)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId);

            modelBuilder.Entity<Cliente>().HasOne(x => x.ListaDePrecios)
                .WithMany(x => x.Clientes)
                .HasForeignKey(x => x.ListaPrecioId);

          
            //DetalleDeCaja

            modelBuilder.Entity<DetalleDeCaja>().HasOne(x => x.Caja)
                .WithMany(x => x.DetalleDeCajas)
                .HasForeignKey(x => x.CajaId);

            //DetalleFactura

            modelBuilder.Entity<DetalleFactura>().HasOne(x => x.Factura)
                .WithMany(x => x.DetalleFacturas)
                .HasForeignKey(x => x.FacturaId);

            modelBuilder.Entity<DetalleFactura>().HasOne(x => x.Producto)
                .WithMany(x => x.DetalleFacturas)
                .HasForeignKey(x => x.ProductoId);

            //Empleado


            //FacturaCompra

            //FacturaVenta

            //FormaPago

            //ListaDePrecios

            //Marca

            //Movimiento

            //Orden

            //Precio

            //PrecioListaPrecio

            //Producto

            //Proveedor

            //Usuario


            modelBuilder.ApplyConfiguration(new CajaMetaData());
            modelBuilder.ApplyConfiguration(new CarritoMetaData());
            modelBuilder.ApplyConfiguration(new CategoriaMetaData());
            modelBuilder.ApplyConfiguration(new ClienteMetaData());
            modelBuilder.ApplyConfiguration(new DetalleDeCajaMetaData());
            modelBuilder.ApplyConfiguration(new DetalleFacturaMetaData());
            modelBuilder.ApplyConfiguration(new EmpleadoMetaData());
            modelBuilder.ApplyConfiguration(new FacturaCompraMetaData());
            modelBuilder.ApplyConfiguration(new FacturaVentaMetaData());
            modelBuilder.ApplyConfiguration(new FormaPagoMetaData());
            modelBuilder.ApplyConfiguration(new ListaDePreciosMetaData());
            modelBuilder.ApplyConfiguration(new MarcaMetaData());
            modelBuilder.ApplyConfiguration(new MovimientoMetaData());
            modelBuilder.ApplyConfiguration(new OrdenMetaData());
            modelBuilder.ApplyConfiguration(new PrecioMetaData());
            modelBuilder.ApplyConfiguration(new PrecioListaPrecioMetaData());
            modelBuilder.ApplyConfiguration(new ProductoMetaData());
            modelBuilder.ApplyConfiguration(new ProveedorMetaData());
            modelBuilder.ApplyConfiguration(new UsuarioMetaData());
           
            base.OnModelCreating(modelBuilder);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entidad in ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted &&
            x.OriginalValues.Properties.Any(p => p.Name.Contains("EstaBorrado"))))
            {
                entidad.State = EntityState.Unchanged;
                entidad.CurrentValues["EstaBorrado"] = true;
            }
  
            return base.SaveChangesAsync();
        }

        public DbSet<Caja> Cajas {get; set;}
        public DbSet<Carrito> Carritos {get; set;}
        public DbSet<Categoria> Categorias  {get; set;}
        public DbSet<Cliente>  Clientes {get; set;}
        public DbSet<DetalleDeCaja> DetalleDeCajas{get; set;}
        public DbSet<DetalleFactura> DetalleFacturas {get; set;}
        public DbSet<Emplead> Empleados {get; set;}
        public DbSet<FacturaVenta> FacturaVentas {get; set;}
        public DbSet<FacturaCompra> FacturaCompras {get; set;}
        public DbSet<FormaPago> FormaPagos {get; set;}

        public DbSet<ListaDePrecios> ListaDePrecios {get; set;}
        public DbSet<Marca> Marcas {get; set;}
        public DbSet<Movimiento> Movimientos {get; set;}
        public DbSet<Orden> Ordens { get; set;}
        public DbSet<Precio> Precios { get; set;}
        public DbSet<PrecioListaPrecio> PrecioListaPrecios { get; set;}
        public DbSet<Producto> Productos { get; set;}
        public DbSet<Proveedor> Proveedors { get; set;}
        public DbSet<Usuario> Usuarios { get; set;}
     










    }
}
