using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class Match
    {

        public int Id { get; set; }

        [Display(Name = "#")]
        public int? MatchNumber { get; set; }

        [Display(Name = "Datum & Tid")]
        public DateTime MatchDateTime { get; set; }

        [Display(Name = "Arena")]
        public Arena Arena { get; set; }
        public int? ArenaId { get; set; }

        [Display(Name = "Hemmalag")]
        public HomeTeam HomeTeam { get; set; }
        public int? HomeTeamId { get; set; }

        [Display(Name = "Bortalag")]
        public AwayTeam AwayTeam { get; set; }
        public int? AwayTeamId { get; set; }

        [Display(Name = "# Datum & Tid   Hemma vs. Borta     Resultat   HD           HD         LD        LD")]
        public string MatchString { get { return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", MatchNumber, MatchDateTime, HomeTeam, " vs ", AwayTeam, Result, Referee1, Referee2, Referee3, Referee4); } }

        [Display(Name = "Mål Hemmalag")]
        public int? HomeTeamScore { get; set; }

        [Display(Name = "Mål Bortalag")]
        public int? AwayTeamScore { get; set; }

        [Display(Name = "Resultat")]
        public string Result { get { return string.Format("{0} {1} {2}", HomeTeamScore, " - ", AwayTeamScore); } }

        [Display(Name = "HD")]
        public Referee Referee { get; set; }
        public int? RefereeId { get; set; }

        [Display(Name = "HD")]
        public Referee1 Referee1 { get; set; }
        public int? Referee1Id { get; set; }

        [Display(Name = "LD")]
        public Referee2 Referee2 { get; set; }
        public int? Referee2Id { get; set; }

        [Display(Name = "LD")]
        public Referee3 Referee3 { get; set; }
        public int? Referee3Id { get; set; }

        [Display(Name = "Supervisor")]
        public Referee4 Referee4 { get; set; }
        public int? Referee4Id { get; set; }

        [Display(Name = "Turnering")]
        public Tournament Tournament { get; set; }
        public int? TournamentId { get; set; }




    }
}
