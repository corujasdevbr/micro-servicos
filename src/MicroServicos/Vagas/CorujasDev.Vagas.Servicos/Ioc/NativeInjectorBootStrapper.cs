using Microsoft.Extensions.DependencyInjection;
using  CorujasDev.Vagas.Dominio.Interfaces.Repositorios;
using  CorujasDev.Vagas.Infra.Data.Contexto;
using  CorujasDev.Vagas.Infra.Data.Repositorios;
using  CorujasDev.Vagas.Servicos.Interfaces;
using  CorujasDev.Vagas.Servicos.Servicos;

namespace CorujasDev.Vagas.Servicos.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IVagaServico, VagaServico>();
            services.AddSingleton<IVagaRepositorio, VagaRepositorio>();

            services.AddScoped<VagasContexto>();
        }
    }
}
