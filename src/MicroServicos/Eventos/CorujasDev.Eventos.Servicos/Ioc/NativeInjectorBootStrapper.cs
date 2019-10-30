using CorujasDev.Eventos.Dominio.Interfaces.Repositorios;
using CorujasDev.Eventos.Infra.Data.Contexto;
using CorujasDev.Eventos.Infra.Data.Repositorios;
using CorujasDev.Eventos.Servicos.Interfaces;
using CorujasDev.Eventos.Servicos.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace CorujasDev.Eventos.Servicos.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IEventoServico, EventoServico>();
            services.AddSingleton<IEventoRepositorio, EventoRepositorio>();

            services.AddScoped<EventosContexto>();
        }
    }
}
