using System;
using Microsoft.EntityFrameworkCore;
using PlanoFitApi.Models;

namespace PlanoFitApi.Models
{
    public class PlanoFitContext : DbContext
    {
        public PlanoFitContext(DbContextOptions<PlanoFitContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<PerfilFitness> PerfilFitness { get; set; }
        public DbSet<Plano> Planos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);

            modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd();
            modelBuilder
                .Entity<User>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder
                .Entity<User>()
                .Property(u => u.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate()
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
