namespace Game.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }
       // public List<DifficultyLevel> DifficultyLevels { get; set; }

    }
}
