using Game.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Game.Persistence.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Content).IsRequired();
            //relation
            builder.HasOne(b => b.DifficultyLevel).WithMany(b => b.Questions).HasForeignKey(b => b.DifficultLevelId);
            builder.HasOne(b => b.Category).WithMany(b => b.Questions).HasForeignKey(b=> b.CategoryId);
            builder.HasMany(b => b.Answers).WithOne(b => b.Question).HasForeignKey(b => b.QuestionId);

        }
    }
}
