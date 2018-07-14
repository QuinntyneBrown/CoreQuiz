using System.Collections;
using System.Collections.Generic;

namespace CoreQuiz.Core.Models
{
    public class QuizResult
    {
        public int QuizResultId { get; set; }
        public int UserId { get; set; }
        public ICollection<QuestionResult> QuestionResults { get; set; }
        = new HashSet<QuestionResult>();
    }
}
