namespace CoreQuiz.Core.Models
{
    public class QuestionOption
    {
        public int QuestionOptionId { get; set; }           
		public string Description { get; set; }
        public bool IsCorrect { get; set; }
    }
}
