using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class HockeyMatch
    {
        public int Id { get; set; }

        [Display(Name = "Match")]
        public string MatchName { get; set; }
    }
}
