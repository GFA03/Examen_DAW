using Examen_DAW.Server.Repositories.MaterieRepository;
using Examen_DAW.Server.Repositories.ProfesorRepository;
using Examen_DAW.Server.Repositories.TestRepository;
using Examen_DAW.Server.Services.MaterieService;
using Examen_DAW.Server.Services.ProfesorMaterieService;
using Examen_DAW.Server.Services.ProfesorService;
using Examen_DAW.Server.Services.TestService;

namespace Examen_DAW.Server.Helpers.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITestRepository, TestRepository>();
            services.AddTransient<IMaterieRepository, MaterieRepository>();
            services.AddTransient<IProfesorRepository, ProfesorRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<IMaterieService, MaterieService>();
            services.AddTransient<IProfesorService, ProfesorService>();
            services.AddTransient<IProfesorMaterieService, ProfesorMaterieService>();

            return services;
        }
    }
}
