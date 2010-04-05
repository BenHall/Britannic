using System.Collections.Generic;
using Britannic.Web.Models;
using Britannic.Web.Repositories;
using Britannic.Web.Resources.Artists;

namespace Britannic.Web.Handlers.Artists
{
    public class ArtistListHandler
    {
        private readonly IArtistRepository _artistRepository;

        public ArtistListHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public object Get()
        {
            var artistListResource = new ArtistListResource();
            artistListResource.Artists = new List<Artist> { new Artist { Name = "Bob" }, new Artist { Name = "Bill" } };
            return artistListResource;
        }
    }
}