using System.Threading.Tasks;

namespace OrgAE.Grumium.Data
{
    public interface IGrumiumDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
