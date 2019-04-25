using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class PaymentVerification
    {
        public int Id { get; set; }

        [Display(Name = "Personnummer")]
        public string Ssn { get; set; }

        [Display(Name = "Domare")]
        public string RefName { get; set; }

        [Display(Name = "Antal Matcher")]
        public int? NumberOfMatches { get; set; }

        [Display(Name = "Antal HD")]
        public int? NumberOfAsHD { get; set; }

        [Display(Name = "Antal LD")]
        public int? NumberOfAsLD { get; set; }

        [Display(Name = "Arvode HD")]
        [DataType(DataType.Currency)]
        public int? FeeHD { get; set; }

        [Display(Name = "Arvode LD")]
        [DataType(DataType.Currency)]
        public int? FeeLD { get; set; }

        [Display(Name = "Arvode")]
        [DataType(DataType.Currency)]
        public int? Fee { get; set; }

        [Display(Name = "Resa")]
        [DataType(DataType.Currency)]
        public int? TravelKost { get; set; }

        [Display(Name = "Sen Matchstart")]
        [DataType(DataType.Currency)]
        public int LateMatchStart { get; set; }

        [Display(Name = "Traktamente")]
        [DataType(DataType.Currency)]
        public int? Alowance { get; set; }

        
        [Display(Name ="Att Betala")]
        [DataType(DataType.Currency)]
        public int? TotalPayment { get; set; }

        [Display(Name = "Bank konto nr")]
        public string BankAccountNumber { get; set; }

        [Display(Name = "Turnering")]
        public Tournament Tournament { get; set; }
        public int? TournamentId { get; set; }
    }
}
