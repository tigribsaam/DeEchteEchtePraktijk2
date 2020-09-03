using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Art> Art { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Art>().HasData(
                new Art
                {
                    ArtId = 1,
                    Name = "Bold & Brash",
                    ImageURL = "http://art.ngfiles.com/images/425000/425133_catscr123_bold-and-brash.jpg",
                    Description = "More like belongs in the trash",
                    PricePerMonth = 150,
                    Available = true

                },

                new Art
                {
                    ArtId = 2,
                    Name = "Whistler's Mother",
                    Artist = "James McNeill Whistler",
                ImageURL = "https://www.abc.net.au/news/image/7269490-3x2-700x467.jpg",
                    Description = "Well, firstly, it's quite big, which is excellent. Because if it was really small, you know, microscopic, then hardly anyone would be able to see it, which would be a tremendous shame. Secondly, and I'm getting quite near the end of this... analysis of this painting. Secondly... Why was it worth this man, here, spending fifty million of your American dollars on this portrait? And the answer is... well, this picture is worth such a lot of money, because... it's a picture of Whistler's mother.",
                    PricePerMonth = 300,
                    Available = true

                });
        }


    }
}
