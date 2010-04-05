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
            return new ArtistListResource();
        }
    }
}