using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Order
    {

        [BindNever]
        public int OrderId { get; set;}

        [BindNever]
        public string UserId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Voer uw voornaam in")]
        [Display(Name = "voornaam")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Voer uw achternaam in")]
        [Display(Name = "achternaam")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Voer uw adres + huisnummer in")]
        [StringLength(100)]
        [Display(Name = "adres + huisnummer")]
        public string AddressAndNumber { get; set; }

        [Required(ErrorMessage = "Voer uw postcode in")]
        [Display(Name = "postcode")]
        [StringLength(10, MinimumLength = 4)]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Voer uw woonplaats in")]
        [Display(Name = "woonplaats")]
        [StringLength(50)]
        public string PlaceOfResidence { get; set; }

        [Required(ErrorMessage = "Voer uw mobiel telefoonnummer in")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Voer uw email adres in")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
    ErrorMessage = "Het email adres is onjuist")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
