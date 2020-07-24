using Facturacion.Conexion;

namespace Infraestructura
{
    using Microsoft.EntityFrameworkCore;
    using System.IO.Compression;
    using System.Linq;
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



    }
}
