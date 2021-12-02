using Microsoft.EntityFrameworkCore;
using _03_WebService.Models;


namespace _03_WebService.DataAcces
{
    public class PostgreSqlContext : DbContext
    {
        public DbSet<CatPersonal> catpersonal { get; set; }
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)
        {
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}