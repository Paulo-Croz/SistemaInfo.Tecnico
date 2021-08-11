using Microsoft.EntityFrameworkCore;
using SistemaInfo.Tecnico.Domain.Entities;

namespace SistemaInfo.Tecnico.Data.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
            
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }
        public DbSet<Pesquisa> Pesquisas { get; set; }

        public override int SaveChanges()
        {
            return SaveChanges();
        }
    }
}
