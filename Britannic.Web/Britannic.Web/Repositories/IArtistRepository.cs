using System.Collections.Generic;
using Britannic.Web.Models;

namespace Britannic.Web.Repositories
{
    public interface IArtistRepository
    {
        IList<Artist> GetAllArtists();
    }
}