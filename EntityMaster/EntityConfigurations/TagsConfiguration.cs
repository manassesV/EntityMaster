using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityMaster.EntityConfigurations
{
    public class TagsConfiguration : IEntityTypeConfiguration<Tags>
    {
        public void Configure(EntityTypeBuilder<Tags> builder)
        {
            builder.HasKey(x => x.id);

            builder.HasMany(c => c.posts)
                .WithMany(c => c.Tags);
                
        }
    }
}
