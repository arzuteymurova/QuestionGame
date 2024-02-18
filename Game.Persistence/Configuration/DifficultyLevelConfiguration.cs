using Game.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Game.Persistence.Configuration
{
    public class DifficultyLevelConfiguration : IEntityTypeConfiguration<DifficultyLevel>
    {
        public void Configure(EntityTypeBuilder<DifficultyLevel> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Difficulty).IsRequired().HasMaxLength(50);

            builder.HasMany(b => b.Questions).WithOne(b => b.DifficultyLevel).HasForeignKey(b => b.DifficultLevelId);
           // builder.HasOne(b => b.Category).WithMany(b => b.DifficultyLevels).HasForeignKey(b => b.CategoryId);
        }
    }
}
