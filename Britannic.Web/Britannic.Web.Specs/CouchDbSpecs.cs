using Britannic.Web.Infrastructure;
using Divan;
using Machine.Specifications;

namespace Britannic.Web.Specs
{
    public class CouchDbSpecs
    {
        protected static ICouchDatabase Database;
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
