using ProPayment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.ViewModels
{
    public class ReceiptViewModel
    {

        [Display(Name = "Domare")]
        public Referee Referee { get; set; }
        public int? RefereeId { get; set; }

        [Display(Name = "Datum & Tid")]
        public DateTime MatchDateTime { get; set; }

        [Display(Name = "Arena")]
        public int? ArenaId { get; set; }
        public Arena Arena { get; set; }

        [Display(Name = "Match")]
        public int? PROMatchId { get; set; }
        public PROMatch PROMatch { get; set; }

        [Display(Name = "Arvode")]
        [DataType(DataType.Currency)]
        public double? Fee { get; set; }

        [Display(Name = "Traktamente")]
        [DataType(DataType.Currency)]
        public double? Alowence { get; set; }

        [Display(Name = "Reseersättning / km")]
        [DataType(DataType.Currency)]
        public double? TravelFee { get; set; }

        [Display(Name = "Resa i km")]
        public double? TravelDistance { get; set; }


        [Display(Name = "Resa")]
        [DataType(DataType.Currency)]
        public double? TravelCost { get; set; }

        [Display(Name = "Sen Matchstart")]
        [DataType(DataType.Currency)]
        public double? LateMatchStart { get; set; }

        [Display(Name = "Att Betala")]
        [DataType(DataType.Currency)]
        public double? TotalPayment { get; set; }

    }
}
