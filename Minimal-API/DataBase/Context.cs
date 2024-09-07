using Microsoft.EntityFrameworkCore;
using Minimal_API.Models;

namespace Minimal_API.DataBase
{
    public class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MinimalApi;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
