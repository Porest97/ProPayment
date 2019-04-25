using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class CupOnlineMatch
    {

        public int Id { get; set; }

        [Display(Name = "#")]
        public int? MatchNumberCupOnline { get; set; }

        [Display(Name = "Beskrivning")]
        public string MatchDescription { get; set; }

        [Display(Name = "Datum & Tid")]
        public DateTime MatchDateTime { get; set; }

        [Display(Name = "Arena")]
        public string Arena { get; set; }

        [Display(Name = "Hemmalag")]
        public string HomeTeam { get; set; }

        [Display(Name = "Bortalag")]
        public string AwayTeam { get; set; }

        [Display(Name = "# Datum & Tid   Hemma vs. Borta     Resultat   HD           HD         LD        LD")]
        public string MatchString { get { return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", MatchNumberCupOnline, MatchDateTime, HomeTeam, " vs ", AwayTeam, Result, Ref1, Ref2, Ref3, Ref4); } }

        [Display(Name = "Mål Hemmalag")]
        public int? ScoreHomeTeam { get; set; }

        [Display(Name = "Mål Bortalag")]
        public int? ScoreAwayTeam { get; set; }

        [Display(Name = "Resultat")]
        public string Result { get { return string.Format("{0} {1} {2}", ScoreHomeTeam," - ", ScoreAwayTeam); } }

        [Display(Name = "HD")]
        public string Ref1 { get; set; }

        [Display(Name = "HD")]
        public string Ref2 { get; set; }

        [Display(Name = "LD")]
        public string Ref3 { get; set; }

        [Display(Name = "LD")]
        public string Ref4 { get; set; }

        public int? TournamentId { get; set; }

        [Display(Name = "Turnering")]
        public Tournament Tournament { get; set; }

        [Display(Name = "TSM Nummer")]
        public int? MatchNumberTSM { get; set; }


    }
}
