using System.Collections.Generic;

namespace CoreQuiz.Core.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }           
		public ICollection<Question> Questions { get; set; }
    }
}
