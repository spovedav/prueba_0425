using CORE.CORs;
using Microsoft.EntityFrameworkCore;

namespace INFRE
{
    public class MiBase : DbContext
    {
        public MiBase(DbContextOptions<MiBase> option) : base(option) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            OnModelCreatingSP(modelBuilder);
        }

        public virtual DbSet<ProductoSPResult> SPSEL_DatosCuenta { get; set; }

        public void OnModelCreatingSP(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoSPResult>().HasNoKey().ToView(null);
        }

        public IQueryable<ProductoSPResult> EjecutarObtenerProductoSP()
        {
            return Set<ProductoSPResult>().FromSqlRaw("EXEC ObtenerProductos");
        }
    }
}
