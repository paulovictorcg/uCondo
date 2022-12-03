using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using uCondo.PlanoContas.Domain.Entidades;

namespace uConto.PlanoContas.Data
{
    public class PlanoContasContext : DbContext
    {
        public virtual DbSet<Conta> Contas { get; set; }
        public PlanoContasContext()
        {

        }
        public PlanoContasContext(DbContextOptions<PlanoContasContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conta>().ToTable("Contas");
        }
    }
}
