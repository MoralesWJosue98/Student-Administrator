using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using TechnicalTest.DDD.Domain;
using TechnicalTest.DDD.Infrastructure.Database;
using TechnicalTest.DDD.Infrastructure.Repositories;

namespace TechnicalTest.DDD.Infrastructure.Extension
{
    public static class UnitOfWorkExtension
    {
        public static IServiceCollection SetupUnitOfWork([NotNullAttribute] this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>(f =>
            {
                var scopeFactory = f.GetRequiredService<IServiceScopeFactory>();
                var context = f.GetService<DatabaseContext>();

                return new UnitOfWork(
                    context,
                    new StudentRepository(context.Students)
                    );
            });

            return serviceCollection;
            
        }

    }
}
