using Game.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Game.Persistence.Configuration
{
    public class GamerConfiguration : IEntityTypeConfiguration<Domain.Entities.Gamer>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Gamer> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.UserName).IsRequired().HasMaxLength(50);

        }
    }
}
