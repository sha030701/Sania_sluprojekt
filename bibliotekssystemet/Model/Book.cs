using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bibliotekssystemet.Model;

namespace Bibliotekssystemet.Model
{
    public class Book
    {
        public int BookID {get; set;}
        public string Title {get; set;}
        public int publicationYear{get; set;}
        public ICollection<Author>Authors {get; set;}
        public ICollection<Loan> Loans { get; set; }
        public ICollection<BookAuth> BookAuthors { get; set; } // Relation till författare


    }
}

