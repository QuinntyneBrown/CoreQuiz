using System;

namespace CoreQuiz.Core.Models
{
    public class DomainEvent
    {
        public int DomainEventId { get; set; }             
        public string Data { get; set; }
        public DateTime CreateOn { get; set; }
        public string Type { get; set; }
        public string DotNetType { get; set; }
    }
}
