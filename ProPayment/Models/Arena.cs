using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class Arena
    {
        public int Id { get; set; }

        [Display(Name = "Namn")]
        public string ArenaName { get; set; }

        [Display(Name = "Gatuadress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Post Nr")]
        public string ZipCode { get; set; }

        [Display(Name = "Post Ort")]
        public string City { get; set; }

        [Display(Name = "Land")]
        public string Country { get; set; }

        [Display(Name = "E-Post")]
        public string EMail { get; set; }

        [Display(Name = "Telefon Nr")]
        public string PhoneNumber { get; set; }


    }
}
