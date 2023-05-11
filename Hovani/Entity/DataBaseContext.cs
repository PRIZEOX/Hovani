using Hovani.Models;
using Microsoft.EntityFrameworkCore;

namespace Hovani.Entity
{
    public class DataBaseContext:DbContext
    {
         
        private string ConnectionPath =
            "Host=localhost;" +
            "Port=5432;" +
            "Username=Hovani;" +
            "Password=turok2008;" +
            "Database=barbershopDB;";

        /*public DbSet<CinemaModel> Cinema { get; set; }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionPath);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ServiceModel> Service { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceModel>(s => s.ToTable("service"));
            base.OnModelCreating(modelBuilder);
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CinemaModel>(e => e.ToTable("cinema"));
            base.OnModelCreating(modelBuilder);
        }*/
    }
}

