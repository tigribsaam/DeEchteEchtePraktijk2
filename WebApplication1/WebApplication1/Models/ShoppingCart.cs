using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(ApplicationDbContext appDbContext)
        {
            _applicationDbContext = appDbContext;
        }

        //returns shoppingcart
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        //adds items to shoppingcart or increases month
        public void AddToCart(Art art, int months)
        {
            var shoppingCartItem =
                    _applicationDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Art.ArtId == art.ArtId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Art = art,
                    Months = months
                };

                _applicationDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            //prevents users from renting art for more than 12 months
            else if(shoppingCartItem.Months < 12)
            {
                shoppingCartItem.Months++;
            }
            _applicationDbContext.SaveChanges();
        }


        // removes items from shoppingcart or decreases month
        public int RemoveFromCart(Art art)
        {
            var shoppingCartItem =
                    _applicationDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Art.ArtId == art.ArtId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                //prevents users from renting art less than 3 months
                if (shoppingCartItem.Months >= 4)
                {
                    shoppingCartItem.Months--;
                    localAmount = shoppingCartItem.Months;
                }
                else
                {
                    _applicationDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _applicationDbContext.SaveChanges();

            return localAmount;
        }

        //returns shoppingcartitems
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                    (ShoppingCartItems =
                        _applicationDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                            .Include(s => s.Art)
                            .ToList());
        }

        //clears shoppingcart in database
        public void ClearCart()
        {
            var cartItems = _applicationDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _applicationDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _applicationDbContext.SaveChanges();
        }

        //returns the total price of all art in shoppingcart
        public decimal GetShoppingCartTotal()
        { 
            var total = _applicationDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Art.PricePerMonth * c.Months).Sum();
            return total;
        }
    }
}
