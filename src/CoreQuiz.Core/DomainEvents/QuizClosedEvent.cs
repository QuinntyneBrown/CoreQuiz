using System;

namespace CoreQuiz.Core.DomainEvents
{
    public class QuizClosedEvent
    {
        public Guid QuizId { get; set; }
    }
}
