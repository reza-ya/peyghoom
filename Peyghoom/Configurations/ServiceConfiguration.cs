using Peyghoom.Entities.Auth.Infrastructures.Repositories;
using Peyghoom.Services;

using System.Runtime.CompilerServices;

namespace Peyghoom.Configurations
{
    public static class ServiceConfiguration
    {

        public static WebApplicationBuilder AddServiceConfiguration(this WebApplicationBuilder builder)
        {   
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<AuthRepository>();
            return builder;
        }
    }
}
