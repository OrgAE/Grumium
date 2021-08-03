using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrgAE.Grumium.Data;
using Volo.Abp.DependencyInjection;

namespace OrgAE.Grumium.EntityFrameworkCore
{
    public class EntityFrameworkCoreGrumiumDbSchemaMigrator
        : IGrumiumDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreGrumiumDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the GrumiumDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<GrumiumDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
