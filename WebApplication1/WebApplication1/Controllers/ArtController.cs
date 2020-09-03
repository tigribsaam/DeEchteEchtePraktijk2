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
       
        public ViewResult List()
        {
            ArtListViewModel artListViewModel = new ArtListViewModel();
            artListViewModel.AllArt = _ArtRepository.AllArt;
            return View(artListViewModel);
        }

        public IActionResult Details(int id)
        {
            var art = _ArtRepository.GetArtById(id);
            if (art == null)
            {
                return NotFound();
            }
            return View(art);
        }


        [Authorize]
        public IActionResult NewArt()
        {
            return View();
        }


        [HttpPost, Authorize]
        public IActionResult NewArt(Art art)
        {

            if (ModelState.IsValid)
            {
                _ArtRepository.CreateArt(art);
                return RedirectToAction("List");
            }
            return View(art);
        }

        public RedirectToActionResult DeleteArt(int artId)
        {
            var selectedArt = _ArtRepository.AllArt.FirstOrDefault(a => a.ArtId == artId);
            _ArtRepository.DeleteArt(selectedArt);
            return RedirectToAction("List");
        }
    }
}
