using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public string _userId;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, IHttpContextAccessor httpContextAccessor)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _httpContextAccessor = httpContextAccessor;
            _userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public IActionResult CheckOut()
        {
            return View();
        }


        //TODO: set rented art to unavailable
        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if(_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Uw winkelwagen is leeg.");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order, _userId);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        public IActionResult CheckoutComplete()
        { 
            return View();
        }

        public ViewResult Orders()
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.OrdersFromId = _orderRepository.GetOrdersFromId();
            return View(orderViewModel);
        }

        public IActionResult DeleteAllOrders()
        {
            _orderRepository.DeleteAllOrders();
            return View();
        }
    }
}
