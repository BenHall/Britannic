using Britannic.Web.Repositories;
using Castle.Facilities.FactorySupport;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using OpenRasta.DI;
using OpenRasta.DI.Windsor;
using Loft;

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
            var facility = new FactorySupportFacility();
            _container.Kernel.AddFacility("factory.support", facility);

            _container.Register(
                Component.For<IArtistRepository>()
                    .ImplementedBy<ArtistRepository>());

            _container.Register(Component.For<IDatabase>().LifeStyle.Transient.UsingFactoryMethod(CouchDb.BuildCouchDb));

            return _container;
        }

        public IDependencyResolver Resolver
        {
            get { return new WindsorDependencyResolver(WindsorContainer); }
        }
    }
}