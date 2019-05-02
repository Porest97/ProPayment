using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class MatchTest
    {
        public int Id { get; set; }

        public DateTime MatchDateTime { get; set; }
        [Required]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set;}
        
        [Required]
        [ForeignKey("TeamId")]
        public virtual int? HomeTeam { get; set; }
        [Required]
        [ForeignKey("TeamId")]
        public virtual int? AwayTeam { get; set; }
        
        public int? ScoreHomeTeam { get; set; }

        public int? AwayHomeTeam { get; set; }
        [Required]
        [ForeignKey("RefereeId")]
        public virtual int? Ref1 { get; set; }
        [Required]
        [ForeignKey("RefereeId")]
        public virtual int? Ref2 { get; set; }
        [Required]
        [ForeignKey("RefereeId")]
        public virtual int? Ref3 { get; set; }
        [Required]
        [ForeignKey("RefereeId")]
        public virtual int? Ref4 { get; set; }
        [Required]
        [ForeignKey("RefereeId")]
        public virtual int? Ref5 { get; set; }

        [Required]
        [ForeignKey("TournamentId")]
        public int? Tournament { get; set; }


        public int? TournamentId { get; set; }

        public int? ArenaId { get; set; }

        public int? RefereeId { get; set; }

        public int? TeamId { get; set; }
    }
}
