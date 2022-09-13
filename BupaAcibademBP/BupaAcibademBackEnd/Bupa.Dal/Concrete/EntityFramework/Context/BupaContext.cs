using System;
using Bupa.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bupa.Dal.Concrete.EntityFramework.Context
{
    public partial class BupaContext : DbContext
    {
        public BupaContext()
        {
        }

        public BupaContext(DbContextOptions<BupaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<InstallmentOption> InstallmentOptions { get; set; }
        public virtual DbSet<PolicyOwner> PolicyOwners { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Bupa;Trusted_Connection=True;");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    modelBuilder.Entity<Card>(entity =>
        //    {
        //        entity.Property(e => e.CardHolderFullName)
        //            .IsRequired()
        //            .HasMaxLength(60);

        //        entity.Property(e => e.CardNumber)
        //            .IsRequired()
        //            .HasMaxLength(16)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Cvccode)
        //            .IsRequired()
        //            .HasMaxLength(5)
        //            .IsUnicode(false)
        //            .HasColumnName("CVCCode");

        //        entity.Property(e => e.ExpDate).HasColumnType("date");

        //        entity.HasOne(d => d.Customer)
        //            .WithMany(p => p.Cards)
        //            .HasForeignKey(d => d.CustomerId)
        //            .HasConstraintName("FK_Cards_Customers");
        //    });

        //    modelBuilder.Entity<Customer>(entity =>
        //    {
        //        entity.Property(e => e.Address).HasMaxLength(200);

        //        entity.Property(e => e.BirthofDate).HasColumnType("date");

        //        entity.Property(e => e.CustomerIdentity)
        //            .IsRequired()
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Email).HasMaxLength(50);

        //        entity.Property(e => e.Gender).HasMaxLength(10);

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.Phone)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Surname).HasMaxLength(50);

        //        entity.HasOne(d => d.Insurer)
        //            .WithMany(p => p.Customers)
        //            .HasForeignKey(d => d.InsurerId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Customers_KayitEttiren");
        //    });

        //    modelBuilder.Entity<InstallmentOption>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.InstallmentType)
        //            .IsRequired()
        //            .HasMaxLength(20)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<PolicyOwner>(entity =>
        //    {
        //        //entity.ToTable("PolicyOwners");

        //        entity.Property(e => e.Address).HasMaxLength(200);

        //        entity.Property(e => e.Birthdate)
        //            .HasColumnType("date")
        //            .HasColumnName("birthdate");

        //        entity.Property(e => e.Email).HasMaxLength(50);

        //        entity.Property(e => e.Gender)
        //            .HasMaxLength(10)
        //            .IsUnicode(false);

        //        entity.Property(e => e.InsurerIdentity)
        //            .IsRequired()
        //            .HasMaxLength(11)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.Phone)
        //            .HasMaxLength(11)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Surname)
        //            .IsRequired()
        //            .HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<Order>(entity =>
        //    {
        //        entity.Property(e => e.OrderDate).HasColumnType("date");

        //        entity.HasOne(d => d.Customer)
        //            .WithMany(p => p.Orders)
        //            .HasForeignKey(d => d.CustomerId)
        //            .HasConstraintName("FK_Orders_Customers");

        //        entity.HasOne(d => d.Policy)
        //            .WithMany(p => p.Orders)
        //            .HasForeignKey(d => d.PolicyId)
        //            .HasConstraintName("FK_Orders_Policies");
        //    });

        //    modelBuilder.Entity<OrderDetail>(entity =>
        //    {
        //        entity.HasOne(d => d.Card)
        //            .WithMany(p => p.OrderDetails)
        //            .HasForeignKey(d => d.CardId)
        //            .HasConstraintName("FK_Payments_Cards");

        //        entity.HasOne(d => d.Customer)
        //            .WithMany(p => p.OrderDetails)
        //            .HasForeignKey(d => d.CustomerId)
        //            .HasConstraintName("FK_Payments_Customers");

        //        entity.HasOne(d => d.InstallmentTypeNavigation)
        //            .WithMany(p => p.OrderDetails)
        //            .HasForeignKey(d => d.InstallmentType)
        //            .HasConstraintName("FK_Payments_InstallmentOptions");

        //        entity.HasOne(d => d.Order)
        //            .WithMany(p => p.OrderDetails)
        //            .HasForeignKey(d => d.OrderId)
        //            .HasConstraintName("FK_OrderDetails_Orders");

        //        entity.HasOne(d => d.PaymentTypeNavigation)
        //            .WithMany(p => p.OrderDetails)
        //            .HasForeignKey(d => d.PaymentType)
        //            .HasConstraintName("FK_Payments_PaymentMethods");

        //        entity.HasOne(d => d.Policy)
        //            .WithMany(p => p.OrderDetails)
        //            .HasForeignKey(d => d.PolicyId)
        //            .HasConstraintName("FK_OrderDetails_Policies");
        //    });

        //    modelBuilder.Entity<PaymentMethod>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.Payment)
        //            .IsRequired()
        //            .HasMaxLength(20);
        //    });

        //    modelBuilder.Entity<Policy>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.PolicyName)
        //            .IsRequired()
        //            .HasMaxLength(50);
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
