using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityMaster.EntityConfigurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasIndex(c => c.id);

            builder.ToTable("Blog").
            HasMany(c => c.Posts)
           .WithOne(c => c.blog)
           .HasForeignKey(c => c.id_blog);

            builder.Property(c => c.id)
                .IsRequired();

            builder.Property(c => c.name)
                .IsRequired()
                .HasMaxLength(50);


        }
    }
}
