using System.Collections.Generic;
using Britannic.Web.Models;
using Divan;

namespace Britannic.Web.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly ICouchDatabase _database;

        public ArtistRepository(ICouchDatabase database)
        {
            _database = database;
        }

        public IList<Artist> GetAllArtists()
        {
            return null;
        }
    }
}