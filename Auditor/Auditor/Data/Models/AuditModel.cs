using Auditor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditor.Data.Models
{
    public class AuditModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int FeelingLevel { get; set; }
        public DateTime AuditDate { get; set; }
        public AuditReason AuditReason { get; set; }
    }
}
