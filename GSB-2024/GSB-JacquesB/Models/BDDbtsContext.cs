using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GSB_JacquesB.Models
{
    public partial class BDDbtsContext : DbContext
    {
        public BDDbtsContext()
        {
        }

        public BDDbtsContext(DbContextOptions<BDDbtsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departement> Departements { get; set; } = null!;
        public virtual DbSet<Medecin> Medecins { get; set; } = null!;
        public virtual DbSet<Specialite> Specialites { get; set; } = null!;
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=BDDbts;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departement>(entity =>
            {
                entity.HasKey(e => e.IdDepartement)
                    .HasName("PK__Departem__1013779ABC16C1F7");

                entity.ToTable("Departement");

                entity.Property(e => e.IdDepartement)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodeRegion)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NomDepartement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomRegionDepartement)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medecin>(entity =>
            {
                entity.HasKey(e => e.IdMedecin)
                    .HasName("PK__Medecin__8371CA435995AC55");

                entity.ToTable("Medecin");

                entity.Property(e => e.AdresseMedecin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartement)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NomMedecin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomMedecin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartementNavigation)
                    .WithMany(p => p.Medecins)
                    .HasForeignKey(d => d.IdDepartement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medecin__IdDepar__2A4B4B5E");

                entity.HasOne(d => d.IdSpecialiteNavigation)
                    .WithMany(p => p.Medecins)
                    .HasForeignKey(d => d.IdSpecialite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Medecin__IdSpeci__29572725");
            });

            modelBuilder.Entity<Specialite>(entity =>
            {
                entity.HasKey(e => e.IdSpecialite)
                    .HasName("PK__Speciali__5C8D4E7C19AE0A56");

                entity.ToTable("Specialite");

                entity.Property(e => e.NomSpecialite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUtilisateur)
                    .HasName("PK__Utilisat__45A4C157AC7BDACE");

                entity.ToTable("Utilisateur");

                entity.Property(e => e.LoginUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotDePasseUtilisateur)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
