using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Loft;
using Britannic.Web.Infrastructure;

namespace Britannic.Web.Specs
{
    public class ArtistRepositorySpecs
    {
        protected static QueryResult Query; 
        protected static IDatabase Database;
    }

    [Subject("Querying artists/get_all_by_name")]
    public class query_view : ArtistRepositorySpecs
    {
        Establish context = () => { Database = CouchDb.BuildCouchDb(); };

        Because of = () => { Query = Database.Query("artists", "get_all_by_name"); };

        It should_have_100_rows = () => Query.Items.Count.ShouldEqual(100);
    }
}
