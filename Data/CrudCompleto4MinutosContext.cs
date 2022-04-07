#nullable disable
using CrudCompleto4Minutos.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudCompleto4Minutos.Data
{
    public class CrudCompleto4MinutosContext : DbContext
    {
        public CrudCompleto4MinutosContext(DbContextOptions<CrudCompleto4MinutosContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
            //mudei qualquer coisa
            //Isso vai dar ruim
            //mudei na branxe
            base.OnModelCreating(modelBuilder);
            //outra coisa não vai dar ruim
        }
    }
}
