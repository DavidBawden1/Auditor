using Auditor.Data.Models;
using System;
using System.Configuration;
using Auditor.Common.Files;
using System.IO;

namespace Auditor.Data.Repository
{
    public class AuditRepository
    {
        internal void LogAudit(AuditModel audit)
        {
            string filePath = ConfigurationSettings.AppSettings["filePath"];
            if (string.IsNullOrEmpty(filePath)) throw new Exception("The filePath must be configured. Please check the application config file.");
            FileManager fileManager = new FileManager();
            try
            {
                fileManager.CreateFile(filePath, audit.AuditDate, audit.AuditReason.ToString(),  audit.Description, audit.FeelingLevel.ToString(), audit.Id);
            }
            catch (IOException e)
            {
                throw e;
            }
        }
    }
}
