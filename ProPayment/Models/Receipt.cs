using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class Receipt
    {

        public int Id { get; set; }

        [Display(Name = "Datum & Tid")]
        public DateTime MatchDateTime { get; set; }


        [Display(Name = "Match")]
        public int? HockeyMatchId { get; set; }
        public HockeyMatch HockeyMatch { get; set; }

        [Display(Name = "Domare")]
        public int? RefereeId { get; set; }
        public Referee Referee { get; set; }

        [Display(Name = "Notering")]
        public string MatchName { get; set; }

        [Display(Name = "Arvode")]
        [DataType(DataType.Currency)]
        public double? Fee { get; set; }

        [Display(Name = "Traktamente")]
        [DataType(DataType.Currency)]
        public double? Alowence { get; set; }

        [Display(Name = "Resa")]
        [DataType(DataType.Currency)]
        public double? TravelCost { get; set; }

        [Display(Name = "Sen Matchstart")]
        [DataType(DataType.Currency)]
        public double? LateMatchStart { get; set; }

        [Display(Name ="Att Betala")]
        [DataType(DataType.Currency)]
        public double? TotalPayment { get; set; }

        
    }
}
