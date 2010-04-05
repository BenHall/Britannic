using Britannic.Web.Repositories;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using OpenRasta.DI;
using OpenRasta.DI.Windsor;

namespace Britannic.Web.Infrastructure
{
    public class IoCBootstrapper : IDependencyResolverAccessor
    {
        IWindsorContainer _container;
        public IWindsorContainer WindsorContainer
        {
            get
            {
                if (_container == null)
                    _container = ConfigureContainer();
                return _container;
            }
        }

        IWindsorContainer ConfigureContainer()
        {
            _container = new WindsorContainer();

            _container.Register(
                Component.For<IArtistRepository>()
                    .ImplementedBy<ArtistRepository>());

            return _container;
        }

        public IDependencyResolver Resolver
        {
            get { return new WindsorDependencyResolver(WindsorContainer); }
        }
    }
}