using LINQtoQuery.Models.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoQuery.Infrastructure.SeedData
{
    public class SeedAuthors : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
                (
                new Author { Id = 2, FirstName = "Stephen e.", LastName = "Ambrose" },
                new Author { Id = 1, FirstName = "Michelle", LastName = "Alexander" },
                new Author { Id = 3, FirstName = "Margaret", LastName = "Atwood" },
                new Author { Id = 4, FirstName = "Jane", LastName = "Austen" },
                new Author { Id = 5, FirstName = "James", LastName = "Baldwin" },
                new Author { Id = 6, FirstName = "Emily", LastName = "Bronte" },
                new Author { Id = 7, FirstName = "Agatha", LastName = "Chistia" },
                new Author { Id = 8, FirstName = "Ta-Nehishi", LastName = "Coates" },
                new Author { Id = 9, FirstName = "Jared", LastName = "Diamond" },
                new Author { Id = 10, FirstName = "Joa", LastName = "Didion" },
                new Author { Id = 11, FirstName = "Daphne", LastName = "Du Maurier" },
                new Author { Id = 12, FirstName = "Tina", LastName = "Fey" },
                new Author { Id = 13, FirstName = "Roxane", LastName = "Gay" },
                new Author { Id = 14, FirstName = "Dashiel", LastName = "Hamment" },
                new Author { Id = 15, FirstName = "Frank", LastName = "Harbert" },
                new Author { Id = 16, FirstName = "Aldous", LastName = "Huxley" },
                new Author { Id = 17, FirstName = "Stieg", LastName = "Larsson" },
                new Author { Id = 18, FirstName = "David", LastName = "MsCullogh" },
                new Author { Id = 19, FirstName = "Toni", LastName = "Morrison" },
                new Author { Id = 20, FirstName = "George", LastName = "Orwell" },
                new Author { Id = 21, FirstName = "Mary", LastName = "Shelly" },
                new Author { Id = 22, FirstName = "Sun", LastName = "Tzu" },
                new Author { Id = 23, FirstName = "Augusten", LastName = "Burroughs" },
                new Author { Id = 25, FirstName = "JK", LastName = "Rowling" },
                new Author { Id = 26, FirstName = "Seth", LastName = "Grahame-Smith" }
                );
        }
    }
}
