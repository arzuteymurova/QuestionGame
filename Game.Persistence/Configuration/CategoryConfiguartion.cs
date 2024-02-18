using Game.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Game.Persistence.Configuration
{
    public class CategoryConfiguartion : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);

            //relation
            builder.HasMany(c => c.Questions).WithOne(q => q.Category).HasForeignKey(q => q.CategoryId);
          //  builder.HasMany(b => b.DifficultyLevels).WithOne(b => b.Category).HasForeignKey(b => b.CategoryId);


        }
    }
}
