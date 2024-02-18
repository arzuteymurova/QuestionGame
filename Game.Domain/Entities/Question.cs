namespace Game.Domain.Entities
{
    public class Question : BaseEntity
    {
        public string Content { get; set; }

        //Relations
        public DifficultyLevel DifficultyLevel { get; set; }
        public int DifficultLevelId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public List<Answer> Answers { get; set; }


    }

}
