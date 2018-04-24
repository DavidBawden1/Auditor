using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auditor.Data.Models;
using Auditor.Data.Repository;
using Auditor.ViewModels;

namespace Auditor.Controllers
{
    public class AuditController
    {
        internal void LogAudit(AuditViewModel auditVM)
        {
            AuditRepository repository = new AuditRepository();
            AuditModel model = new AuditModel
            {
                Id= auditVM.Id, 
                Description = auditVM.Description, 
                AuditReason = auditVM.AuditReason,
                FeelingLevel = auditVM.FeelingLevel,
                AuditDate = auditVM.AuditDate
            };
            repository.LogAudit(model);
        }
    }
}
