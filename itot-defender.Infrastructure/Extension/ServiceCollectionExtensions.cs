using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace itot_defender.Infrastructure.Extension;

public static class ServiceCollectionExtensions   {
    public static IServiceCollection AddSwaggerOpenAPI(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "itot_defender API",
                Description = "API documentation for itot_defender"
            });
        });

        return services;
    }
}