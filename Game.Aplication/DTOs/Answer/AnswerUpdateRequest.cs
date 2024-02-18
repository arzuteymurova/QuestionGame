namespace Game.Aplication.DTOs.Answer
{
    public class AnswerUpdateRequest
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public IsTrue IsTrue { get; set; }
        public int QuestionId { get; set; }

    }
}
