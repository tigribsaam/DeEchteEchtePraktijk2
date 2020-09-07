using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class ArtViewModel
    {
        public int ArtId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public int PricePerMonth { get; set; }
        public bool Available { get; set; }
        public string UserId { get; set; }
        public bool AllowedToEdit { get; set; }
    }
}
