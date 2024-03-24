using GD_Extension.Utils;
using GD_Program.SceneModels;
using GD_Program.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GD_Program
{
    public class Program
    {
        /// <summary>
        /// IOC容器
        /// </summary>
        public static IServiceProvider Services = ConfigureServices();
        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var builder = new ServiceCollection();
            AddServices(builder);
            AddSceneModel(builder);
            return builder.BuildServiceProvider();
        }
        /// <summary>
        /// 添加服务，应以Singleton形式添加
        /// </summary>
        /// <param name="service"></param>
        public static void AddServices(ServiceCollection builder)
        {
            builder.AddSingleton<TestService>();
            builder.AddSingleton<NlogHelper>();
            builder.AddSingleton<FreeSqlHelper>();
        }
        /// <summary>
        /// 添加SceneModel，应以Transient添加
        /// </summary>
        /// <param name="service"></param>
        public static void AddSceneModel(ServiceCollection builder)
        {
            builder.AddTransient<MainSceneModel>();
        }
    }
}
