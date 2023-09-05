using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipeGenerator.Interfaces;
using RecipeGenerator.Services;

namespace RecipeGenerator
{
	public static class DependencyInjection
	{
        public static IServiceCollection AddInfrastructure(
           this IServiceCollection services)
        {

            
                services.AddScoped<IServiceConfigurations, Configurations>();


            return services;
        }

    }
}

