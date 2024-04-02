using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _02_Environmental_Emissions.Models;

public partial class MyDataBaseContext : DbContext
{
    public MyDataBaseContext()
    {
    }

    public MyDataBaseContext(DbContextOptions<MyDataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmissionType> EmissionTypes { get; set; }

    public virtual DbSet<Sourse> Sourses { get; set; }

    public virtual DbSet<SourseEmission> SourseEmissions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=192.168.0.138;Initial Catalog=MyDataBase; User ID=sa;Password=165415aaBB;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmissionType>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PK__Emission__516F03B5B422702B");

            entity.HasIndex(e => e.Formula, "UQ__Emission__88639403C6E981E2").IsUnique();

            entity.Property(e => e.Formula)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sourse>(entity =>
        {
            entity.HasKey(e => e.SourceId).HasName("PK__Sourse__16E01919D97A2D4A");

            entity.ToTable("Sourse");

            entity.HasIndex(e => e.SourceName, "UQ__Sourse__3C28DC1734098FB6").IsUnique();

            entity.Property(e => e.SourceId).ValueGeneratedNever();
            entity.Property(e => e.FullAddress)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("UNKHOWN");
            entity.Property(e => e.SourceName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SourseEmission>(entity =>
        {
            entity.HasKey(e => e.EmissionId).HasName("PK__SourseEm__C6A733025E2DBA4E");

            entity.Property(e => e.EmissionId).ValueGeneratedNever();
            entity.Property(e => e.SourceDate).HasColumnType("datetime");
            entity.Property(e => e.SourseId).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.TextDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("No specific description");

            entity.HasOne(d => d.EmissionTypeNavigation).WithMany(p => p.SourseEmissions)
                .HasForeignKey(d => d.EmissionType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SourseEmissions_Sourse");

            entity.HasOne(d => d.Sourse).WithMany(p => p.SourseEmissions)
                .HasForeignKey(d => d.SourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SourseEmi__Sours__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
