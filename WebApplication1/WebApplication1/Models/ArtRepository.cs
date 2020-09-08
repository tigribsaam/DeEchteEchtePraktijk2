using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.ViewModels;

namespace WebApplication1.Models
{
    public class ArtRepository: IArtRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public string _UserId;


        public ArtRepository(ApplicationDbContext applicationDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _appDbContext = applicationDbContext;
            _httpContextAccessor = httpContextAccessor;
            //find userId from httpcontext
            _UserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

        }

        //returns all art from database
        public IEnumerable<Art> AllArt
        {
            get
            {
                return _appDbContext.Art;
            }
        }

        //gets art by id
        public Art GetArtById(int ArtId)
        {
            return _appDbContext.Art.FirstOrDefault(async => async.ArtId == ArtId);
        }

        //create new art object
        public void CreateArt(NewArtViewModel model)
        {
            string uniqueFileName = UploadedFile(model.ImageURL);

            Art newArt = new Art
            {
                Name = model.Name,
                Artist = model.Artist,
                ImageURL = uniqueFileName,
                Description = model.Description,
                PricePerMonth = model.PricePerMonth,
                Available = true,
                UserIdString = _UserId
            };

            _appDbContext.Art.Add(newArt);
            _appDbContext.SaveChanges();

        }

        //upload img to wwwroot/images and gives it a unique name
        //returns unique name
        private string UploadedFile(IFormFile ufile)
        {
            string uniqueFileName = null;

            if (ufile != null)
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ufile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ufile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }






        //deletes art from database
        public void DeleteArt(Art art)
        {
            List<ShoppingCartItem> items = new List<ShoppingCartItem>
            {

            };

            foreach (var Item in _appDbContext.ShoppingCartItems)
            {
                if (Item.Art == art)
                {
                    items.Add(Item);
                }
            }
            var selectedArt = _appDbContext.ShoppingCartItems.FirstOrDefault(a => a.Art == art);

            _appDbContext.RemoveRange(items);

            _appDbContext.Remove<Art>(art);
            _appDbContext.SaveChanges();
        }
    }
}
