using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IArtRepository _artRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IArtRepository artRepository, ShoppingCart shoppingCart)
        {
            _artRepository = artRepository;
            _shoppingCart = shoppingCart;
        }

        // view of shoppingcart
        public ViewResult index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var ShoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(ShoppingCartViewModel);
        }

        //action to add item to shoppingcart or increase months
        public RedirectToActionResult AddToShoppingCart(int artId)
        {
            var selectedArt = _artRepository.AllArt.FirstOrDefault(a => a.ArtId == artId);

            if(selectedArt != null && selectedArt.Available)
            {
                _shoppingCart.AddToCart(selectedArt, 3);
            }
            return RedirectToAction("Index");
        }

        //action to remove item from shoppingcart or decrease months
        public RedirectToActionResult RemoveFromShoppingCart(int artId)
        {
            var selectedArt = _artRepository.AllArt.FirstOrDefault(a => a.ArtId == artId);

            if (selectedArt != null)
            {
                _shoppingCart.RemoveFromCart(selectedArt);
            }
            return RedirectToAction("Index");
        }

    }
}
