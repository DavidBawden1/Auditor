using Auditor.Controllers;
using Auditor.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            try
            {
                if (string.IsNullOrEmpty(AuditLog_RichTextBox.Text)) throw new ArgumentException("An audit log must be provided.");
                if (AuditReason_ComboBox.SelectedValue == null || (AuditReason)AuditReason_ComboBox.SelectedValue == AuditReason.Select) throw new ArgumentException("An Audit Reason must be provided.");
                if (Feeling_ComboBox.SelectedValue == null || (FeelingLevel)Feeling_ComboBox.SelectedValue == FeelingLevel.Select) throw new ArgumentException("A feeling level must be provided.");

                AuditViewModel auditVM = new AuditViewModel
                {
                    Id = new Guid(),
                    Description = AuditLog_RichTextBox.Text,
                    AuditReason = (AuditReason)AuditReason_ComboBox.SelectedValue,
                    FeelingLevel = (FeelingLevel)Feeling_ComboBox.SelectedValue,
                    AuditDate = DateTime.Now
                };

                AuditController auditController = new AuditController();
                auditController.LogAudit(auditVM);
                MessageBox.Show("Audit Log created");
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads the enum values into the Audit Reason combo box
        /// </summary>
        private void LoadAuditReasons()
        {
            try
            {
                AuditReason_ComboBox.DataSource = Enum.GetValues(typeof(AuditReason));
            }
            catch (Exception)
            {
                throw new Exception("Failed to initialise Audit Reason values.");
            }
        }

        /// <summary>
        /// Loads the enum values into the Audit Reason combo box
        /// </summary>
        private void LoadFeelingLevels()
        {
            try
            {
                Feeling_ComboBox.DataSource = Enum.GetValues(typeof(FeelingLevel));
            }
            catch (Exception)
            {
                throw new Exception("Failed to initialise Feeling Level values.");
            }
        }

        private void AuditorForm_Load(object sender, EventArgs e)
        {
            LoadAuditReasons();
            LoadFeelingLevels();
        }
    }
}
