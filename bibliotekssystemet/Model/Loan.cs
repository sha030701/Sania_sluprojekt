using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotekssystemet.Model
{
    public class Loan
    {
        public int LoanId {get; set;}

        public int BookID{get; set;}

        public string Borrower {get; set;}
        public DateTime LoanDate {get; set;}
        
        public DateTime? ReturnDate{get; set;}
        public Book Book {get; set;}

    }
}