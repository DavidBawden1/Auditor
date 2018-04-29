using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Auditor.Common.Files
{
    public class FileManager
    {
        public void CreateFile(string inputFilePath, DateTime date, string auditReason, string description, string feelingLevel, Guid id)
        {
            string fullPath = Path.GetFullPath(inputFilePath);
            if (string.IsNullOrEmpty(fullPath)) throw new ArgumentException("The filepath cannot be null or empty.");
            if (File.Exists(inputFilePath)) throw new IOException($"The file {fullPath} already exists.");
            if (!Directory.Exists(fullPath))
            {
                CreateDirectory(fullPath);
            }
            string fileContent = $"{date.ToString()} {auditReason} {description} {feelingLevel} {id}";
            using (var stream = File.Create(fullPath))
            {
                try
                {
                    Byte[] content = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetBytes("fileContent");
                    stream.WriteAsync(content, 0, content.Length);
                }
                catch (IOException)
                {
                    throw new IOException($"Failed to create file {inputFilePath}");
                }
            }
        }

        public void CreateXmlFile(string inputFilePath, DateTime date, string auditReason, string description, string feelingLevel, Guid id)
        {
            string fullPath = Path.GetFullPath(inputFilePath);
            if (string.IsNullOrEmpty(fullPath)) throw new ArgumentException("The filepath cannot be null or empty.");
            string directoryPath = Path.GetDirectoryName(fullPath);
            if (File.Exists(inputFilePath)) throw new IOException($"The file {fullPath} already exists.");
            if (!Directory.Exists(directoryPath))
            {
                CreateDirectory(directoryPath);
            }

            XmlDocument doc = new XmlDocument();
            XmlNode declarationNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(declarationNode);

            XmlNode auditsNode = doc.CreateElement("Audits");
            doc.AppendChild(auditsNode);

            XmlNode auditNode = doc.CreateElement("Audit");
            auditsNode.AppendChild(auditNode);

            XmlAttribute logIdXml = doc.CreateAttribute("AuditId");
            logIdXml.Value = id.ToString();
            auditNode.Attributes.Append(logIdXml);
            XmlAttribute reasonXml = doc.CreateAttribute("AuditReason");
            reasonXml.Value = auditReason;
            auditNode.Attributes.Append(reasonXml);
            XmlAttribute descriptionXml = doc.CreateAttribute("AuditDescription");
            descriptionXml.Value = description;
            auditNode.Attributes.Append(descriptionXml);
            XmlAttribute feelingLevelXml = doc.CreateAttribute("AuditFeeling");
            feelingLevelXml.Value = feelingLevel;
            auditNode.Attributes.Append(feelingLevelXml);
            XmlAttribute dateXml = doc.CreateAttribute("AuditDate");
            dateXml.Value = date.ToString("yyyy/dd/MM/HH:mm:ss");
            auditNode.Attributes.Append(dateXml);

            auditsNode.AppendChild(auditNode);
            doc.Save(fullPath);
        }

        internal void CreateDirectory(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentException("The filepath cannot be null or empty.");
            try
            {
                Directory.CreateDirectory(filePath);
            }
            catch (IOException e)
            {
                throw new Exception($"Failed to create the directory(s) in {filePath} {e}");
            }
        }
    }
}
