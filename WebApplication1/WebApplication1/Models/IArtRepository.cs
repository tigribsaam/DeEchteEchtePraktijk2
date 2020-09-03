using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IArtRepository
    {
        IEnumerable<Art> AllArt { get; }
        Art GetArtById(int ArtId);
        void CreateArt(Art art);
        void DeleteArt(Art art);
    }
}
