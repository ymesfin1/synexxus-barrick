using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace synexxusbarrick.Entities
{
    public partial class BarrickOperationsContext : DbContext
    {
        public virtual DbSet<Operations> Operations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-HUVI8V7Q\MSSQLSERVER01;Initial Catalog=barrick;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operations>(entity =>
            {
                entity.HasKey(e => e.Test1)
                    .HasName("PK_operations");

                entity.ToTable("operations");

                entity.Property(e => e.Test1)
                    .HasColumnName("test1")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Test2)
                    .HasColumnName("test2")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Test3)
                    .HasColumnName("test3")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Test4)
                    .HasColumnName("test4")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Test5)
                    .HasColumnName("test5")
                    .HasColumnType("varchar(45)");
            });
        }
    }
}