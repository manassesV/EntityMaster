using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityMaster.EntityConfigurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasIndex(c => c.id);
            builder.Property(c => c.id)
                .IsRequired();
            
            builder.HasOne(c => c.blog)
                .WithMany(c => c.Posts);

            builder.HasMany(c => c.Tags)
                .WithMany(c => c.posts);
        }
    }
}
