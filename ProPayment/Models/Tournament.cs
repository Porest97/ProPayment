using System;
using System.ComponentModel.DataAnnotations;

namespace ProPayment.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        [Display(Name ="Turnering")]
        public string TournamentName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }


        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}