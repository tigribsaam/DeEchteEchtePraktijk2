﻿using Microsoft.AspNetCore.Http;
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

        //creates order and saves to database
        public void CreateOrder(Order order, string _userId)
        {

            order.UserId = _UserId;
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            //get all shoppingcartitems and make orderdetails from them
            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Art = shoppingCartItem.Art,
                    Months = shoppingCartItem.Months,
                    ArtId = shoppingCartItem.Art.ArtId,
                    Price = shoppingCartItem.Art.PricePerMonth,
                    Returned = false
              
                };

                //set bought art to unavailable
                var selectedArt = _applicationDbContext.Art.FirstOrDefault(a => a.ArtId == orderDetail.ArtId);
                selectedArt.Available = false;

                _applicationDbContext.Update<Art>(selectedArt);

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
            //reverses order so must recent is first
            orders.Reverse();
            return orders;
        }


        //returns art > set art to avaiable and orderdetail to returned
        public void ReturnArt(int artid, int orderId, int orderDetailId)
        {
            var selectedOrder = _applicationDbContext.Orders.Where(b => b.OrderId == orderId)
                      .Include("OrderDetails")
                      .FirstOrDefault();

            var selectedOrderDetail = selectedOrder.OrderDetails.FirstOrDefault(b => b.OrderDetailId == orderDetailId);
            selectedOrderDetail.Returned = true;


            var selectedArt = _applicationDbContext.Art.FirstOrDefault(a => a.ArtId == artid);
            selectedArt.Available = true;

            _applicationDbContext.Update<Art>(selectedArt);

            _applicationDbContext.SaveChanges();
        }


    }
}
