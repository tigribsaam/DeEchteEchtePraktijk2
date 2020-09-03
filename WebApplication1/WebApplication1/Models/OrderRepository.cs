using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Models
{

    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ShoppingCart _shoppingCart;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public string _UserId;

        public OrderRepository(ApplicationDbContext applicationDbContext, ShoppingCart shoppingCart, IHttpContextAccessor httpContextAccessor)
        {
            _applicationDbContext = applicationDbContext;
            _shoppingCart = shoppingCart;
            _httpContextAccessor = httpContextAccessor;
            _UserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }


        public void CreateOrder(Order order, string _userId)
        {

            order.UserId = _UserId;
            //_UserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Art = shoppingCartItem.Art,
                    Months = shoppingCartItem.Months,
                    ArtId = shoppingCartItem.Art.ArtId,
                    Price = shoppingCartItem.Art.PricePerMonth
              
                };

                var selectedArt = _applicationDbContext.Art.FirstOrDefault(a => a.ArtId == orderDetail.ArtId);
                selectedArt.Available = false;

                _applicationDbContext.Update<Art>(selectedArt);

                //orderDetail.Art.Available = false;

                order.OrderDetails.Add(orderDetail);
            }

            _applicationDbContext.Orders.Add(order);

            _applicationDbContext.SaveChanges();
        }



        public List<Order> GetOrdersFromId()
        {
            List<Order> orders = new List<Order>
            {

            };

            // Load all blogs and related posts.
            var AllOrders = _applicationDbContext.Orders
                                .Include("OrderDetails.Art")
                                .ToList();


            foreach (var order in AllOrders)
            {
                if(order.UserId == _UserId)
                {


                    orders.Add(order);
                }
            }

            return orders;
        }

        public void ReturnArt(int artid)
        {
            var selectedArt = _applicationDbContext.Art.FirstOrDefault(a => a.ArtId == artid);
            selectedArt.Available = true;

            _applicationDbContext.Update<Art>(selectedArt);

            _applicationDbContext.SaveChanges();
        }










        public void DeleteAllOrders()
        {
            List<ShoppingCartItem> items = new List<ShoppingCartItem>
            {

            };

            foreach (var Item in _applicationDbContext.ShoppingCartItems)
            {

                    items.Add(Item);
            }

            _applicationDbContext.RemoveRange(items);

            List<OrderDetail> orderdetails = new List<OrderDetail>
            {

            };

            foreach (var Item in _applicationDbContext.OrderDetails)
            {

                orderdetails.Add(Item);
            }

            _applicationDbContext.RemoveRange(orderdetails);


            List<Order> orders = new List<Order>
            {

            };

            foreach (var Item in _applicationDbContext.Orders)
            {

                orders.Add(Item);
            }

            _applicationDbContext.RemoveRange(orders);


            _applicationDbContext.SaveChanges();
        }
    }
}
