using IMDB.Recommendations.Application.Contracts.Data;
using IMDB.Recommendations.Infrastructure.DataProviders.IMDB;
using Microsoft.Extensions.DependencyInjection;

namespace IMDB.Recommendations.Infrastructure
{
    public static class InfrastructureServiceRegistrations
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IMoviesDataProvider, MoviesDataProvider>();
            return services;
        }
    }
}