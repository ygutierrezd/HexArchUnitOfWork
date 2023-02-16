using Estidiante.Dominio.Repositorio;
using Estidiante.Infraestructura.EntityFramework;
using Estidiante.Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Estudiante.Api.Extension
{
    public static class Infraestructura
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddScoped<IAlumnoRepositorio, MySqlEsudianteRepositorio>();
            services.AddScoped<IEstudianteMateriaRepositorio, MySqlEstudianteMateriaRepositorio>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<EstudianteContexto>(options =>
                options.UseMySql(configuration.GetConnectionString("EstudianteDatabase").ToString(), ServerVersion.AutoDetect(configuration.GetConnectionString("EstudianteDatabase").ToString())));
            return services;
        }
    }
}
