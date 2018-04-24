using Auditor.Data.Models;
using System;
using System.Configuration;

namespace Auditor.Data.Repository
{
    public class AuditRepository
    {
        internal void LogAudit(AuditModel audit)
        {
            var appsettings = ConfigurationSettings.AppSettings.GetValues("filePath");
            Console.WriteLine($"{appsettings}");
        }
    }
}
