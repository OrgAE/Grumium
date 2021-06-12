using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OrgAE.Grumium.Data
{
    /* This is used if database provider does't define
     * IGrumiumDbSchemaMigrator implementation.
     */
    public class NullGrumiumDbSchemaMigrator : IGrumiumDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}