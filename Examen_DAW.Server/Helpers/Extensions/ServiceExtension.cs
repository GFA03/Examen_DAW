using Examen_DAW.Server.Repositories.TestRepository;
using Examen_DAW.Server.Services.TestService;

namespace Examen_DAW.Server.Helpers.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITestRepository, TestRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();

            return services;
        }
    }
}
