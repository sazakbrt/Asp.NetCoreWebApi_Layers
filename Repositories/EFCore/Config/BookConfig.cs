using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "Title",
                    Price = 75
                },
                new Book
                {
                    Id = 2,
                    Title = "Title2",
                    Price = 85
                },
                new Book
                {
                    Id = 3,
                    Title = "Title3",
                    Price = 95
                }
                );
        }
    }
}
