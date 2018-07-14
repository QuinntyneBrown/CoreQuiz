using System;
using System.Collections.Generic;
using System.Text;

namespace CoreQuiz.Core.DomainEvents
{
    public class QuestionAnsweredEvent
    {
        public int QuizResultId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public int OptionId { get; set; }
    }
}
