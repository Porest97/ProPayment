using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class RefereeReceipt
    {
        public int Id { get; set; }

        [Display(Name = "Match")]
        public HockeyMatch Match { get; set; }
        public int HockeyMatchId { get; set; }

        [Display(Name = "Domare")]
        public Referee Referee { get; set; }
        public int RefereeId { get; set; }

        [Display(Name ="Arvode")]
        [DataType(DataType.Currency)]
        public RefereeFee RefereeFee { get; set; }
        public int RefereeFeeId { get; set; }

    }
}
