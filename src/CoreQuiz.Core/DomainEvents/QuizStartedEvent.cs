using CoreQuiz.Core.Models;
using MediatR;
using System;

namespace CoreQuiz.Core.DomainEvents
{
    public class QuizStartedEvent: INotification
    {
        public Guid QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
