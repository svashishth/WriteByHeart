using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity.Mvc5;

namespace _4_KavitaDilSe.Client
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// Dependency of injection
    /// </summary>
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}