using MediatR;
using System;

namespace CoreQuiz.Core.DomainEvents
{
    public class UserCreatedEvent: DomainEvent
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
