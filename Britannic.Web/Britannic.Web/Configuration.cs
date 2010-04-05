using Britannic.Web.Handlers.Artists;
using Britannic.Web.Handlers.Releases;
using Britannic.Web.Resources.Artists;
using Britannic.Web.Resources.Releases;
using OpenRasta.Configuration;
using Britannic.Web.Handlers;
using Britannic.Web.Resources;

namespace Britannic.Web
{
    public class Configuration : IConfigurationSource
    {
        public void Configure()
        {
            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has.ResourcesOfType<HomeResource>()
                    .AtUri("/home")
                    .And.AtUri("/")
                    .HandledBy<HomeHandler>()
                    .RenderedByAspx("~/Views/HomeView.aspx")
                    .And.AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<ArtistListResource>()
                    .AtUri("/artists")
                    .HandledBy<ArtistListHandler>()
                    .RenderedByAspx("~/Views/Artists/List.aspx")
                    .And.AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<ArtistResource>()
                    .AtUri("/artists/{name}")
                    .HandledBy<ArtistHandler>()
                    .RenderedByAspx("~/Views/Artists/Show.aspx")
                    .And.AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<ReleaseResource>()
                    .AtUri("/artists/{name}/{release}")
                    .HandledBy<ReleaseHandler>()
                    .RenderedByAspx("~/Views/Releases/Show.aspx")
                    .And.AsJsonDataContract();
            }
        }
    }
}