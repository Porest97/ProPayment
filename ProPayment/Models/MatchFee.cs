using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class MatchFee
    {
        public int Id { get; set; }

        [Display(Name = "Serie")]
        public string Series { get; set; }

        [Display(Name = "Åldersgrupp")]
        public string SeriesAgeGroupe { get; set; }

        [Display(Name = "Matchlängd")]
        public string MatchLength { get; set; }

        [Display(Name ="Serie")]
        public string MatchFeeString { get { return string.Format("{0} {1}", Series, MatchLength); } }

        [Display(Name = "HD")]
        [DataType(DataType.Currency)]
        public int? HDFee { get; set; }

        [Display(Name = "LD")]
        [DataType(DataType.Currency)]
        public int? LDFee { get; set; }

        [Display(Name = "Seriekategori")]
        public string SeriesCategory { get; set; }
    }
}
