using System.Collections.Generic;
using Britannic.Web.Models;
using Loft;

namespace Britannic.Web.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly IDatabase _database;

        public ArtistRepository(IDatabase database)
        {
            _database = database;
        }

        public IList<Artist> GetAllArtists()
        {
            QueryResult couchQuery = _database.Query("artists", "get_all_by_name");
            IList<Artist> artists = couchQuery.Get<Artist>("artist");

            return artists;
        }
    }
}