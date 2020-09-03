using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Art
    {
        [BindNever]
        public int ArtId { get; set; }


        public string Name { get; set; }
        public string Artist { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public int PricePerMonth { get; set; }

        [BindNever]
        public bool Available { get; set; }
        // TODO: rented to?? 

        // TODO: user class
        // public User Artist { get; set; }




    }
}
