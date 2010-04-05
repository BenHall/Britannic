using System;
using System.Collections.Generic;
using OpenRasta.Codecs;
using OpenRasta.Codecs.WebForms;
using OpenRasta.Configuration;
using OpenRasta.DI;
using OpenRasta.Web;
using OpenRasta.Web.Codecs;
using OpenRasta.Web.UriDecorators;
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
                    .And.AtUri("/artists/{name}")
                    .HandledBy<HomeHandler>()
                    .RenderedByAspx("~/Views/HomeView.aspx");
            }
        }
    }

}