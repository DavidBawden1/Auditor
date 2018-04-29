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
            if (string.IsNullOrEmpty(inputFilePath)) throw new ArgumentException("The filepath cannot be null or empty.");
            string fullPath = string.Empty;
            string directoryPath = string.Empty;
            string extension = string.Empty;
            try
            {
                fullPath = Path.GetFullPath(inputFilePath);
                directoryPath = Path.GetDirectoryName(fullPath);
                extension = Path.GetExtension(fullPath);
                if (File.Exists(fullPath)) throw new IOException($"The file {fullPath} already exists.");
                if (!Directory.Exists(directoryPath))
                {
                    CreateDirectory(directoryPath);
                }
            }
            catch (IOException ex)
            {
                throw new IOException($"Failed processing the file. {inputFilePath} {ex}");
            }

            if (extension.Contains("xml"))
            {
                CreateXmlFile(fullPath, date, auditReason, description, feelingLevel, id);
            }
            else
            {
                string fileContent = $"{date.ToString("yyyy/MM/dd/HH:mm:ss")} {auditReason} {description} {feelingLevel} {id}";
                CreateFile(fullPath, fileContent);
            }
        }

        private void CreateFile(string inputFilePath, string fileContent)
        {
            using (var stream = File.Create(inputFilePath))
            {
                try
                {
                    Byte[] content = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true).GetBytes(fileContent);
                    stream.WriteAsync(content, 0, fileContent.Length);
                }
                catch (IOException)
                {
                    throw new IOException($"Failed to create file {inputFilePath}");
                }
            }
        }

        public void CreateXmlFile(string inputFilePath, DateTime date, string auditReason, string description, string feelingLevel, Guid id)
        {
            try
            {
                XmlDocument doc = ConstructXmlDocument(date, auditReason, description, feelingLevel, id);
                doc.Save(inputFilePath);
            }
            catch (XmlException ex)
            {
                throw new XmlException($"Failed to create xml file {inputFilePath} {ex}");
            }
        }

        private static XmlDocument ConstructXmlDocument(DateTime date, string auditReason, string description, string feelingLevel, Guid id)
        {
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
            return doc;
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
