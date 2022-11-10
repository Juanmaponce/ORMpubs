using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsPubs.Models
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
            : base("name=PubsContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<PubInfo> PubInfo { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Titleauthor> Titleauthors { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Roysched> Royscheds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.Au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.Au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.Au_fname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.Zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Titleauthors)
                .WithRequired(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Emp_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Fname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Minit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Lname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Job_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PubInfo>()
                .Property(e => e.Pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PubInfo>()
                .Property(e => e.Pr_info)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.Pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.Pub_name)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Publisher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Publisher>()
                .HasOptional(e => e.Pub_info)
                .WithRequired(e => e.Publisher);

            modelBuilder.Entity<Sale>()
                .Property(e => e.Stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.Ord_num)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.Payterms)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.Title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Stor_name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Stor_address)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Titleauthor>()
                .Property(e => e.Au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Titleauthor>()
                .Property(e => e.Title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Title1)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.Advance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.Titleauthors)
                .WithRequired(e => e.Title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasOptional(e => e.Roysched)
                .WithRequired(e => e.Title);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Discounttype)
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.Discount1)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Roysched>()
                .Property(e => e.Title_id)
                .IsUnicode(false);
        }
    }
}
