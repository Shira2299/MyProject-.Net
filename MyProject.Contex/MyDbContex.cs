using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyProject.Repositoties;
using MyProject.Repositoties.Repositories;
using System.Reflection.Metadata;

namespace MyProject.Contex
{
    public class MyDbContex : DbContext, IContex
    {
        //public List<Role> Roles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public List<Claim> Claims { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public List<Permission> Permissions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Claim> Claims { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MyDBName;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //מגדיר לי שהתכונה שם היא שדה חובה והתיאור אורך מקסימלי של 250
        {
            modelBuilder.Entity<Role>().Property(b => b.Name).IsRequired();
            modelBuilder.Entity<Role>().Property(b => b.Description).HasMaxLength(250);
        }

    }
}