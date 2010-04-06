using Britannic.Web.Infrastructure;
using Machine.Specifications;
using Loft;

namespace Britannic.Web.Specs
{
    public class CouchDbSpecs
    {
        protected static IDatabase Database;
    }

    [Subject("Creating CouchDB object")]
    public class creating_db_object : CouchDbSpecs
    {
        Establish context = () => { Database = null; };

        Because of = () => { Database = CouchDb.BuildCouchDb(); };

        It should_not_be_null = () => Database.ShouldNotBeNull();

        It should_exist = () => Database.Exists();
    }
}
