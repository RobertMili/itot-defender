

using Microsoft.AspNetCore.Builder;

namespace itot_defender.Infrastructure.Extension;

public static class ConfigureContainer {
    
    
    
    public static void ConfigureSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger();

        app.UseSwaggerUI(setupAction =>
        {
            setupAction.SwaggerEndpoint("/swagger/OpenAPISpecification/swagger.json", "Onion Architecture API");
            setupAction.RoutePrefix = "OpenAPI";
        });
    }
}
