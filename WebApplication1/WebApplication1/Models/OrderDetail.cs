using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ArtId { get; set; }
        public int Months { get; set; }
        public decimal Price { get; set; }
        public Art Art { get; set; }
        public Order Order { get; set; }
        public bool Returned { get; set; }
    }
}
