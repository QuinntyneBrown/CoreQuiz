using System.Collections.Generic;

namespace CoreQuiz.Core.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Description { get; }

        public ICollection<QuestionOption> Options { get; }
        = new HashSet<QuestionOption>();
    }
}
