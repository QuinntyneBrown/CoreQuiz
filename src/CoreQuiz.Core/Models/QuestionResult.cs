namespace CoreQuiz.Core.Models
{
    public class QuestionResult
    {
        public int QuestionResultId { get; set; }
        public int QuizResultId { get; set; }
        public int QuestionId { get; set; }
        public string Name { get; set; }  
        public int CorrectQuestionOptionId { get; set; }
        public int SelectedQuestionOptionId { get; set; }
        public bool IsCorrect { get; set; }
        public void Reduce(int selectedOptionId)
        {
            if (CorrectQuestionOptionId == selectedOptionId)
                IsCorrect = true;            
        }
    }
}
