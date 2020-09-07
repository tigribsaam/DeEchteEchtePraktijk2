using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace WebApplication1.Models
{
    //interface for ArtRepository
    public interface IArtRepository
    {
        IEnumerable<Art> AllArt { get; }
        Art GetArtById(int ArtId);
        void CreateArt(NewArtViewModel model);
        void DeleteArt(Art art);
    }
}
