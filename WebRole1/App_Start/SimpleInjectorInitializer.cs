[assembly: WebActivator.PostApplicationStartMethod(typeof(WebRole1.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace WebRole1.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Logging;
    using Logging.NLog;
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            container.Verify();
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<ILogger, NLogger>(Lifestyle.Scoped);
        }
    }
}