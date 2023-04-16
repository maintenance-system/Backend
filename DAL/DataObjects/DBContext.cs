using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataObjects;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Handyman> Handymen { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

   /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\CCC\\DB\\DB.mdf;Integrated Security=True;Connect Timeout=30");
*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC077C0F4D24");

            entity.Property(e => e.Descreption).HasMaxLength(100);
            entity.Property(e => e.Neighborhood).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(50);

            entity.HasOne(d => d.City).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Addresses__CityI__4AB81AF0");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branches__3214EC07143B0872");

            entity.Property(e => e.Symbol)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.Address).WithMany(p => p.Branches)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Branches__Addres__49C3F6B7");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3214EC07E7EF94AE");

            entity.Property(e => e.NameCity).HasMaxLength(50);
        });

        modelBuilder.Entity<Handyman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Handyman__3214EC07120A61B9");

            entity.ToTable("Handyman");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.PasswordLogin)
                .HasMaxLength(100)
                .HasColumnName("Password_login");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.CityNavigation).WithMany(p => p.Handymen)
                .HasForeignKey(d => d.City)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Handyman__City__4D94879B");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Worker__3214EC07D416F692");

            entity.ToTable("Worker");

            entity.Property(e => e.FirstName).HasMaxLength(25);
            entity.Property(e => e.LastName).HasMaxLength(25);
            entity.Property(e => e.PasswordLogin).HasMaxLength(100);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.AddressBranchNavigation).WithMany(p => p.Workers)
                .HasForeignKey(d => d.AddressBranch)
                .HasConstraintName("FK__Worker__AddressB__5FB337D6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
