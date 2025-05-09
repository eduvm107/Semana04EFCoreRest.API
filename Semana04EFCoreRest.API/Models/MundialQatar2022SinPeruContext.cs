using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Semana04EFCoreRest.API.Models;

public partial class MundialQatar2022SinPeruContext : DbContext
{
    public MundialQatar2022SinPeruContext()
    {
    }

    public MundialQatar2022SinPeruContext(DbContextOptions<MundialQatar2022SinPeruContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Player> Player { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-F898MU7;Database=MundialQatar2022SinPeru;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Player__3214EC07298C0AA6");

            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
