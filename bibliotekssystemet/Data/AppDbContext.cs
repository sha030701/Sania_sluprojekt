using Microsoft.EntityFrameworkCore;
using Bibliotekssystemet.Model;

namespace Bibliotekssystemet
{
    public class AppDbContext :  DbContext
    {
        public DbSet<Book> Books {get; set;}
        public DbSet<Author> Authors {get; set;}

        public DbSet<Loan> Loans {get; set;}

        public DbSet<BookAuth> BookAuths {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=bibliotekssystemet;User Id=sa;Password=Sania123; Encrypt=False");
 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<BookAuth>()
                .HasKey(ba => new {ba.BookID, ba.AuthorID});

           modelBuilder.Entity<BookAuth>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookID);
            
           modelBuilder.Entity<BookAuth>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => ba.AuthorID);

           modelBuilder.Entity<Loan>()
                .HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookID);

            
        }

    }

}