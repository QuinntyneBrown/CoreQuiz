using System;

namespace CoreQuiz.Core.DomainEvents
{
    public class QuestionAnsweredEvent
    {
        public Guid QuizResultId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid UserId { get; set; }
        public Guid OptionId { get; set; }
    }
}
