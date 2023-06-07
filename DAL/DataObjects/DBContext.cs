using System;
using System.Collections.Generic;
using DAL.DataObjects.LogIn;
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

    public virtual DbSet<Actions> Actions { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ConnectionHealth> ConnectionHealths { get; set; }

    public virtual DbSet<ConnectionSafety> ConnectionSafeties { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<Handyman> Handymen { get; set; }

    public virtual DbSet<HealthIssue> HealthIssues { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolesAction> RolesActions { get; set; }

    public virtual DbSet<SafetyIssue> SafetyIssues { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\גרינברג יעל\\Desktop\\aa\\DB\\DB.mdf\";Integrated Security=True;Connect Timeout=30");
*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actions>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Actions__3214EC07F2B9AB7D");

            entity.Property(e => e.Type)
                .HasMaxLength(6)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("type");
            entity.Property(e => e.Url)
                .HasMaxLength(2083)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("url");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC077C0F4D24");

            entity.Property(e => e.Descreption)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NeighborhoodId)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

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
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.Address).WithMany(p => p.Branches)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Branches__Addres__49C3F6B7");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3214EC07E7EF94AE");

            entity.Property(e => e.NameCity)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<ConnectionHealth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__connecti__3214EC07E1C62077");

            entity.ToTable("connection health");

            entity.Property(e => e.BranchId).HasColumnName("branchID");
            entity.Property(e => e.Completed).HasDefaultValueSql("((0))");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("description");
            entity.Property(e => e.IssuesId).HasColumnName("issuesID");
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.Selected)
                .HasDefaultValueSql("((0))")
                .HasColumnName("selected");

            entity.HasOne(d => d.Branch).WithMany(p => p.ConnectionHealths)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__connectio__branc__76969D2E");

            entity.HasOne(d => d.Issues).WithMany(p => p.ConnectionHealths)
                .HasForeignKey(d => d.IssuesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__connectio__issue__75A278F5");
        });

        modelBuilder.Entity<ConnectionSafety>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__connecti__3214EC072FA2D280");

            entity.ToTable("connection safety");

            entity.Property(e => e.BranchId).HasColumnName("branchID");
            entity.Property(e => e.Completed).HasDefaultValueSql("((0))");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("description");
            entity.Property(e => e.IssuesId).HasColumnName("issuesID");
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.Selected)
                .HasDefaultValueSql("((0))")
                .HasColumnName("selected");

            entity.HasOne(d => d.Branch).WithMany(p => p.ConnectionSafeties)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__connectio__branc__7E37BEF6");

            entity.HasOne(d => d.Issues).WithMany(p => p.ConnectionSafeties)
                .HasForeignKey(d => d.IssuesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__connectio__issue__7D439ABD");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Files__3214EC071E4ACC79");

            entity.Property(e => e.NameFile)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("nameFile");
            entity.Property(e => e.PathFile)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UrlFile)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Handyman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Handyman__3214EC07120A61B9");

            entity.ToTable("Handyman");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(225)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PasswordLogin)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Password_login");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.CityNavigation).WithMany(p => p.Handymen)
                .HasForeignKey(d => d.City)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Handyman__City__4D94879B");
        });

        modelBuilder.Entity<HealthIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__health i__3214EC0736D738DA");

            entity.ToTable("health issues");

            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC07E28C7894");

            entity.Property(e => e.Role1)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("role");
        });

        modelBuilder.Entity<RolesAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RolesAct__3214EC07EB94B78B");

            entity.Property(e => e.RoleId).HasColumnName("roleId");

            entity.HasOne(d => d.ActionsNavigation).WithMany(p => p.RolesActions)
                .HasForeignKey(d => d.Actions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RolesActi__Actio__10566F31");

            entity.HasOne(d => d.Role).WithMany(p => p.RolesActions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RolesActi__roleI__114A936A");
        });

        modelBuilder.Entity<SafetyIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__safety i__3214EC0740A987F1");

            entity.ToTable("safety issues");

            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC073D4CBF16");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("name");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC07FED19F07");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRoles__RoleI__123EB7A3");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserRoles__UserI__1332DBDC");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Worker__3214EC07D416F692");

            entity.ToTable("Worker");

            entity.Property(e => e.FirstName)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PasswordLogin)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.AddressBranchNavigation).WithMany(p => p.Workers)
                .HasForeignKey(d => d.AddressBranch)
                .HasConstraintName("FK__Worker__AddressB__5FB337D6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
