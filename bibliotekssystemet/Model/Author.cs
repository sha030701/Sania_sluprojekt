using System.Collections.Generic;


namespace Bibliotekssystemet.Model
{

    public class Author
    {
        public int ID {get; set;}

        public string FirstName {get; set;}

        public string LastName{get; set;}

        public string DateOfBirth {get; set;}

        public ICollection<BookAuth> BookAuthors {get; set;} 

    }



}