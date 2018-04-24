using Auditor.Controllers;
using Auditor.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditor
{
    public partial class AuditorForm : Form
    {
        public AuditorForm()
        {
            InitializeComponent();
        }

        private void LogAudit_Button_Click(object sender, EventArgs e)
        {
            LogAudit();
        }

        private void LogAudit()
        {
            AuditViewModel auditVM = new AuditViewModel
            {
                Id = new Guid(),
                Description = AuditLog_RichTextBox.Text,
                AuditReason = (AuditReason)AuditReason_ComboBox.SelectedValue,
                FeelingLevel = (int)Feeling_ComboBox.SelectedValue,
                AuditDate = DateTime.Now
            };

            AuditController auditController = new AuditController();
            auditController.LogAudit(auditVM);
        }
    }
}
