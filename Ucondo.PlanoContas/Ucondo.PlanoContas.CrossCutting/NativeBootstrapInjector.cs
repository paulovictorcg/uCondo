using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using uConto.PlanoContas.Data;
using uCondo.PlanoContas.Domain.Interfaces;
using uCondo.PlanoContas.Services;

namespace Ucondo.PlanoContas.CrossCutting
{
    public static class NativeBootstrapInjector
    {
        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<PlanoContasContext>(options =>
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));
        }
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            return services.AddScoped<IContaRepository, ContaRepository>();
        }
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            return services.AddScoped<IContaService, ContaService>();
        }
    }
}
