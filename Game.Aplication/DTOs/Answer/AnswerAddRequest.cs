namespace Game.Aplication.DTOs.Answer
{
    public class AnswerAddRequest
    {
        public string Answer { get; set; }
        public IsTrue IsTrue { get; set; }
        public int QuestionId { get; set; }
    }
}
