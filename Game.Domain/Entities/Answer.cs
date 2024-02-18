namespace Game.Domain.Entities
{
    public class Answer : BaseEntity
    {
        public string Value { get; set; }
        public IsTrue IsTrue { get; set; }

        public Question Question { get; set; }
        public int QuestionId { get; set; }

    }
}
