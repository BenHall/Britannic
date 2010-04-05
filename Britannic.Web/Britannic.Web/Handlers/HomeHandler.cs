using System;
using Britannic.Web.Resources;

namespace Britannic.Web.Handlers
{
    public class HomeHandler
    {
        public object Get()
        {
            return new HomeResource();
        }

        public object Get(string name)
        {
            var homeResource = new HomeResource();
            homeResource.Name = name;
            return homeResource;
        }
    }
}