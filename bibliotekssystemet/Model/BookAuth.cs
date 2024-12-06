using Microsoft.Identity.Client;

namespace Bibliotekssystemet.Model
{
    public class BookAuth
    {
        public int BookID{get; set;}

        public int AuthorID{get; set;}
      
        public Book Book {get; set;}

        public Author Author {get; set;}

    }
}