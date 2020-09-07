using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Art
    {
        [BindNever]
        public int ArtId { get; set; }

        [Required(ErrorMessage = "Voer de naam van het kunstwerk in")]
        [Display(Name = "Naam")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Voer de naam van de kunstenaar in")]
        [Display(Name = "Kunstenaar")]
        public string Artist { get; set; }

        [Required(ErrorMessage = "Voer de Url van de foto van het kunstwerk in")]
        [Display(Name = "Foto URL")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage = "Voer een beschrijving van het kunstwerk in")]
        [Display(Name = "Beschrijving")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Voer de prijs van het kunstwerk in")]
        [Display(Name = "Prijs per maand")]
        public int PricePerMonth { get; set; }

        [BindNever]
        public bool Available { get; set; }

        [BindNever]
        public string UserIdString { get; set; }



    }
}
