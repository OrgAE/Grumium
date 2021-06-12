using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace OrgAE.Grumium.EntityFrameworkCore
{
    public static class GrumiumDbContextModelCreatingExtensions
    {
        public static void ConfigureGrumium(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(GrumiumConsts.DbTablePrefix + "YourEntities", GrumiumConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}