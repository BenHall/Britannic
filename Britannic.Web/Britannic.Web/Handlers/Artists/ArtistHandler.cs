using Britannic.Web.Repositories;
using Britannic.Web.Resources.Artists;

namespace Britannic.Web.Handlers.Artists
{
    public class ArtistHandler
    {
        private readonly IArtistRepository _artistRepository;

        public ArtistHandler(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public object GetByName(string name)
        {
            var resource = new ArtistResource();
            resource.Name = name;
            return resource;
        }
    }
}