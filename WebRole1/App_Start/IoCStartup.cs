namespace WebRole1
{
    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    using System.Web.Mvc;
    public class IoCStartup
    {
        public static void ConigureSimpleInjector()
        {
            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
            //container.Register<IPoolPriceDS, PoolPriceDS>(Lifestyle.Transient);            

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Register the container as MVC3 IDependencyResolver.
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}