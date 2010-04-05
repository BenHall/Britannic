using Divan;

namespace Britannic.Web.Infrastructure
{
    public static class CouchDb
    {
        public static ICouchDatabase BuildCouchDb()
        {
            return new CouchDatabase(new CouchServer("192.168.1.66", 5984));
        }
    }
}