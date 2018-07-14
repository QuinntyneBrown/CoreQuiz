using CoreQuiz.Core.Models;
using MediatR;

namespace CoreQuiz.Core.DomainEvents
{
    public class QuizStartedEvent: INotification
    {
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
