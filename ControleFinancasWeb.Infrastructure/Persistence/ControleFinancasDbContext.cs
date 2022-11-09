using ControleFinancasWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ControleFinancasWeb.Infrastructure.Persistence
{
    public class ControleFinancasDbContext : DbContext
    {
        public ControleFinancasDbContext(DbContextOptions<ControleFinancasDbContext> options) : base(options)
        {

        }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Categoria> Tipos { get; set; }
        public DbSet<SubCategoria> Detalhamentos { get; set; }
        public DbSet<CategoriaSubcategoria> TipoDetalhamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
