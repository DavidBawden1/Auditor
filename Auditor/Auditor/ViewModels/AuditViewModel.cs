using System;

namespace Auditor.ViewModels
{
    public enum AuditReason { Select, Money, HouseChores, GardenChores, Argument, Conversation, Tiredness, Work }
    public enum FeelingLevel { Select, Angry, Unhappy, Normal, Happy, Awesome }
    public class AuditViewModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public FeelingLevel FeelingLevel { get; set; }
        public DateTime AuditDate { get; set; }
        public AuditReason AuditReason { get; set; }
    }
}
