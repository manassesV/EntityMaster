using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityMaster.EntityConfigurations
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasIndex(c => c.Id);

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.OwnsOne(c => c.Person, owned =>
            {
                owned.Property(p => p.FirstName).HasColumnName("FirstName");
                owned.Property(p => p.LastName).HasColumnName("LastName");
            });

            builder.OwnsOne(c => c.address, owned =>
            {
                owned.Property(c => c.Street).HasColumnName("Street");
                owned.Property(c => c.Number).HasColumnName("Number");
            });
        }
    }
}
