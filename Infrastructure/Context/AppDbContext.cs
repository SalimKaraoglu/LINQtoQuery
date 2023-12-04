using LINQtoQuery.Infrastructure.SeedData;
using LINQtoQuery.Models.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoQuery.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Primary Key Tanımlanması
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });
            //Foreign Key Tanımlanması
            modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Book)
                        .WithMany(b => b.BookAuthors)
                        .HasForeignKey(ba => ba.BookId);

            modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Author)
                        .WithMany(b => b.BookAuthors)
                        .HasForeignKey(ba => ba.AuthorId);


            // Silme Davranışının Kaldırılması
            modelBuilder.ApplyConfiguration(new SeedGenres());
            modelBuilder.ApplyConfiguration(new SeedBooks());
            modelBuilder.ApplyConfiguration(new SeedAuthors());
            modelBuilder.ApplyConfiguration(new SeedBookAuthors());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDb; Database=LibraryDb; Trusted_Connection=True;");
        }
    }
}
