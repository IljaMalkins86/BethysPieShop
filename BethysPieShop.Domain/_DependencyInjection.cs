using BethysPieShop.Domain.Services;
using BethysPieShop.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BethysPieShop.Domain;

public static class DomainDependencyInjection
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IPieService, PieService>();
        services.AddScoped<ICategoryService, CategoryService>();

        return services;
    }
}