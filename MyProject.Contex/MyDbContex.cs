using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Options;
using MyProject.Repositories;
using System.Reflection.Metadata;
using MyProject.Repositories.Entities;
//namespace EFModeling.EntityProperties.DataAnnotations;
namespace MyProject.Contex
{
    public class MyDbContex : DbContext, IContex
    {       
        public DbSet<Role> Roles { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Claim> Claims { get; set; }

        public DbSet<User> Users { get; set; }

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