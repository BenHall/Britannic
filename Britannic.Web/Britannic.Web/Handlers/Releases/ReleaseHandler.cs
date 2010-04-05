using Britannic.Web.Resources.Releases;

namespace Britannic.Web.Handlers.Releases
{
    public class ReleaseHandler
    {
        public object Get()
        {
            return new ReleaseResource();
        }
    }
}