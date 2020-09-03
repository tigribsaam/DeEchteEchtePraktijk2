using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Art Art { get; set; }
        public int Months { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
