using Loft;

namespace Britannic.Web.Infrastructure
{
    public static class CouchDb
    {
        public static Database BuildCouchDb()
        {
            return new Database(new Server("192.168.1.66", 5984), "product_catalog");
        }
    }
}