using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Bibliotekssystemet.Model;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Bibliotekssystemet
{
    class program
    {
        static void Main(string[]args)
        {
            System.Console.WriteLine("welcome to library");
            System.Console.WriteLine("1. Add book");
            
            System.Console.WriteLine("2.Add an Author ");
            
            System.Console.WriteLine("3.List all Books ");
          
            System.Console.WriteLine("4.Add a loan for Books ");
            System.Console.WriteLine("5.List all loan");
            System.Console.WriteLine("6.Return book");
            System.Console.WriteLine("7.Exit ");
            
            System.Console.WriteLine("Select an option:  ");

            var input = Console.ReadLine();
            switch (input)
            {
                
               case "1":
                    AddBook();
                    break;
                case "2":
                    AddAuthor();
                    break;
                case "3":
                    List_all_Book();
                    break;
                case "4":
                    AddLoan();
                    break;
                case "5":
                    ListLoan();
                    break;
                case "6":
                    ReturnBook();
                    break;
                case "7":
                   break;
                case "8":
                    break;
            }
           
        }

        private static void ReturnBook()
        {
            throw new NotImplementedException();
        }

        private static void ListLoan()
        {
            throw new NotImplementedException();
        }

        private static void AddLoan()
        {
            throw new NotImplementedException();
        }

        private static void List_all_Book()
        {
            throw new NotImplementedException();
        }

        private static void AddAuthor()
        {
            using (var context = new AppDbContext())
            {
                System.Console.WriteLine("Write Author First Name");
                var authorName = Console.ReadLine();
                System.Console.WriteLine("Write Author Last Name");
                var authorLast = Console.ReadLine();
                System.Console.WriteLine("Author's Date of Bith (yyyy-MM-dd) ");
                var birthDateInput = Console.ReadLine();

              
                Console.WriteLine("Write author's Biography:");
                var biography = Console.ReadLine();

                var author = new Author
                {
                    FirstName = authorName,
                    LastName = authorLast,
                    DateOfBirth = birthDateInput,
                    
                };

                context.Authors.Add(author);
                context.SaveChanges();
                Console.WriteLine($"Author {authorName} {authorLast} added successfully!");
            }
        }

        private static void AddBook()
        {
            using (var context = new AppDbContext())
            {
                Console.WriteLine("Enter Book name:");
                var bookName = Console.ReadLine();
                Console.WriteLine("Enter Book publicationYear (yyyy):");
                var bookReleaseDate = Console.ReadLine();
                if(!int.TryParse(bookReleaseDate, out var releaseDate))
                {
                    Console.WriteLine("Invalid date form. Please use yyyy ");
                    return;
                }
               

                var book = new Book 
                {
                    Title = bookName,
                    publicationYear = releaseDate,
                    

                };
                context.Books.Add(book);
                context.SaveChanges();

                Console.WriteLine($"Book {bookName} add successfully!");
            
            }
        }
    }
}