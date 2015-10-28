using Funq;
using ServiceStack;
using SelfHost.ServiceInterface;
using ServiceStack.Auth;
using ServiceStack.Caching;

namespace SelfHost
{
    public class AppHost : AppSelfHostBase
    {
        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("SelfHost", typeof(MyServices).Assembly)
        {
           
        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        /// <param name="container"></param>
        public override void Configure(Container container)
        {
            Plugins.Add(new AuthFeature(() => new AuthUserSession(), new IAuthProvider[] { new CustomAuthentication(), }));
            container.Register<ICacheClient>(new MemoryCacheClient());
            var userRepository = new InMemoryAuthRepository();
            container.Register<IUserAuthRepository>(userRepository);
        }
    }
}
