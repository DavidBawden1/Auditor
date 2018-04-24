using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditor.ViewModels
{
    public enum AuditReason { Money, HouseChores, GardenChores, Argument, Conversation, Tiredness, Work }
    public class AuditViewModel
    {
        public Guid Id { get; set; }
        public string Description  { get; set; }
        public int FeelingLevel { get; set; }
        public DateTime AuditDate { get; set; }
        public AuditReason AuditReason { get; set; }
    }
}
