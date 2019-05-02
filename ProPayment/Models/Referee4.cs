using System.ComponentModel.DataAnnotations;

namespace ProPayment.Models
{
    public class Referee4
    {
        public int Id { get; set; }

        [Display(Name = "Personnummer")]
        public string Ssn { get; set; }

        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(Name = "Gatuadress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Post Ort")]
        public string City { get; set; }

        [Display(Name = "Post Nr")]
        public string ZipCode { get; set; }

        [Display(Name = "Land")]
        public string Country { get; set; }

        [Display(Name = "E-Post")]
        public string EMail { get; set; }

        [Display(Name = "Domarnummer")]
        public int? RefNumber { get; set; }

        [Display(Name = "Telefon Nr")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Namn")]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [Display(Name = "Adress")]
        public string RefereeAddress { get { return string.Format("{0} {1} {2} ", StreetAddress, ZipCode, City); } }

        [Display(Name = "E-Post & Telefonnummer")]
        public string RefereePhoneAndEmail { get { return string.Format("{0} {1}", EMail, PhoneNumber); } }

        [Display(Name = "Domare")]
        public string RefereeString { get { return string.Format("{0} {1} {2} ", FullName, RefereeAddress, RefereePhoneAndEmail); } }
    }
}