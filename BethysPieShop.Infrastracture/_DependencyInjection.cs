using BethysPieShop.Domain.Repositories;
using BethysPieShop.Infrastracture.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BethysPieShop.Infrastracture;

public static class InfrastractureDependencyInjection
{
    public static IServiceCollection AddInfrastractureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPieRepository, MockedPieRepository>();
        services.AddScoped<ICategoryRepository, MockedCategoryRepository>();

        return services;
    }
}