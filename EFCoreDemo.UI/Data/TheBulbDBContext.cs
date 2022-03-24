using EFCoreDemo.UI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.UI.Data
{
    public class TheBulbDBContext : DbContext
    {

        public TheBulbDBContext(DbContextOptions<TheBulbDBContext> options) : base(options)
        {
        }

        public DbSet<DotnetFellow> Fellows { get; set; }
        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DotnetFellow>(entity =>
            { 
                entity
                .ToTable("tblDotnetClass")
                .HasKey(d => d.Id);

                entity
                    .HasOne(d => d.State)
                    .WithMany(s => s.DotnetFellows)
                    .HasForeignKey(d => d.StateId);

                entity.Property(d => d.GenderId).HasDefaultValue(3);
            });

            builder.Entity<State>(entity =>
            {
                entity.ToTable("tblState").HasKey(s => s.Id);

                entity.Property(s => s.Name)
                    .HasMaxLength(17)
                    .IsRequired();
            });


            base.OnModelCreating(builder);
        }
    }
}
