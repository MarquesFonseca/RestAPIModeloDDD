using Microsoft.EntityFrameworkCore;
using RestAPIModeloDDD.Domain.Entities;

namespace RestAPIModeloDDD.Infrastructure.Data
{
    public class Infrastructure_Data_SqlServerContext : DbContext
    {
        public Infrastructure_Data_SqlServerContext()
        { }

        public Infrastructure_Data_SqlServerContext(DbContextOptions<Infrastructure_Data_SqlServerContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}