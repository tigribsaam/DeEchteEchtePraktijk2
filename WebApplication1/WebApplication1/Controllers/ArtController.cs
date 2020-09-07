using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class ArtController : Controller
    {
        private readonly IArtRepository _ArtRepository;

        public ArtController(IArtRepository ArtRepository)
        {
            _ArtRepository = ArtRepository;
        }
       
        // view of all art
        public ViewResult List()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.AllArt = _ArtRepository.AllArt;
            return View(artListViewModel);
        }

        // view of one piece of art
        public IActionResult Details(int id)
        {
            var art = _ArtRepository.GetArtById(id);
            if (art == null)
            {
                return NotFound();
            }
            return View(art);
        }

        // form for new art
        [Authorize]
        public IActionResult NewArt()
        {
            return View();
        }

        // form for new art redirects to list and adds new art if valid
        [HttpPost, Authorize]
        public IActionResult NewArt(NewArtViewModel model)
        {

            if (ModelState.IsValid)
            {
                _ArtRepository.CreateArt(model);
                return RedirectToAction("List");
            }
            return View(model);
        }

        //deletes art
        //TODO: Auth or userID koppelne
        public RedirectToActionResult DeleteArt(int artId)
        {
            var selectedArt = _ArtRepository.AllArt.FirstOrDefault(a => a.ArtId == artId);
            _ArtRepository.DeleteArt(selectedArt);
            return RedirectToAction("List");
        }
    }
}
