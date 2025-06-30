using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenHoaiNam_2310900073.Models;

public partial class NguyenHoaiNam2310900073Context : DbContext
{
    public NguyenHoaiNam2310900073Context()
    {
    }

    public NguyenHoaiNam2310900073Context(DbContextOptions<NguyenHoaiNam2310900073Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NhnEmployee> NhnEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6BCLQVC\\MAY1;Database=NguyenHoaiNam_2310900073;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhnEmployee>(entity =>
        {
            entity.HasKey(e => e.NhnEmpId).HasName("PK__NhnEmplo__D3248E921A70E07C");

            entity.ToTable("NhnEmployee");

            entity.Property(e => e.NhnEmpId)
                .ValueGeneratedNever()
                .HasColumnName("NhnEmpId");
            entity.Property(e => e.NhnEmpLevel)
                .HasMaxLength(50)
                .HasColumnName("NhnEmpLevel");
            entity.Property(e => e.NhnEmpName)
                .HasMaxLength(100)
                .HasColumnName("NhnEmpName");
            entity.Property(e => e.NhnEmpStartDate).HasColumnName("NhnEmpStartDate");
            entity.Property(e => e.NhnEmpStatus).HasColumnName("NhnEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
