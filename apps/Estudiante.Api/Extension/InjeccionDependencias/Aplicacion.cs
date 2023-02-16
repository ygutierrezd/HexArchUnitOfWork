using Estidiante.Aplicacion;

namespace Estudiante.Api.Extension.InjeccionDependencias
{
    public static class Aplicacion
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<GuardarEstudianteMateria, GuardarEstudianteMateria>();
            return services;
        }
    }
}
