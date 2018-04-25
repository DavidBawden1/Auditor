namespace Auditor
{
    partial class AuditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AuditorControls_GroupBox = new System.Windows.Forms.GroupBox();
            this.Feeling_Label = new System.Windows.Forms.Label();
            this.AuditReason_Label = new System.Windows.Forms.Label();
            this.AuditReason_ComboBox = new System.Windows.Forms.ComboBox();
            this.Feeling_ComboBox = new System.Windows.Forms.ComboBox();
            this.AuditLog_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.LogAudit_Button = new System.Windows.Forms.Button();
            this.AuditorControls_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuditorControls_GroupBox
            // 
            this.AuditorControls_GroupBox.Controls.Add(this.Feeling_Label);
            this.AuditorControls_GroupBox.Controls.Add(this.AuditReason_Label);
            this.AuditorControls_GroupBox.Controls.Add(this.AuditReason_ComboBox);
            this.AuditorControls_GroupBox.Controls.Add(this.Feeling_ComboBox);
            this.AuditorControls_GroupBox.Controls.Add(this.AuditLog_RichTextBox);
            this.AuditorControls_GroupBox.Controls.Add(this.LogAudit_Button);
            this.AuditorControls_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuditorControls_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.AuditorControls_GroupBox.Name = "AuditorControls_GroupBox";
            this.AuditorControls_GroupBox.Size = new System.Drawing.Size(398, 263);
            this.AuditorControls_GroupBox.TabIndex = 0;
            this.AuditorControls_GroupBox.TabStop = false;
            // 
            // Feeling_Label
            // 
            this.Feeling_Label.AutoSize = true;
            this.Feeling_Label.Location = new System.Drawing.Point(195, 16);
            this.Feeling_Label.Name = "Feeling_Label";
            this.Feeling_Label.Size = new System.Drawing.Size(76, 13);
            this.Feeling_Label.TabIndex = 6;
            this.Feeling_Label.Text = "How do I feel?";
            // 
            // AuditReason_Label
            // 
            this.AuditReason_Label.AutoSize = true;
            this.AuditReason_Label.Location = new System.Drawing.Point(6, 16);
            this.AuditReason_Label.Name = "AuditReason_Label";
            this.AuditReason_Label.Size = new System.Drawing.Size(71, 13);
            this.AuditReason_Label.TabIndex = 5;
            this.AuditReason_Label.Text = "Audit Reason";
            // 
            // AuditReason_ComboBox
            // 
            this.AuditReason_ComboBox.FormattingEnabled = true;
            this.AuditReason_ComboBox.Location = new System.Drawing.Point(6, 33);
            this.AuditReason_ComboBox.Name = "AuditReason_ComboBox";
            this.AuditReason_ComboBox.Size = new System.Drawing.Size(183, 21);
            this.AuditReason_ComboBox.TabIndex = 4;
            // 
            // Feeling_ComboBox
            // 
            this.Feeling_ComboBox.FormattingEnabled = true;
            this.Feeling_ComboBox.Location = new System.Drawing.Point(195, 33);
            this.Feeling_ComboBox.Name = "Feeling_ComboBox";
            this.Feeling_ComboBox.Size = new System.Drawing.Size(116, 21);
            this.Feeling_ComboBox.TabIndex = 3;
            // 
            // AuditLog_RichTextBox
            // 
            this.AuditLog_RichTextBox.Location = new System.Drawing.Point(6, 61);
            this.AuditLog_RichTextBox.Name = "AuditLog_RichTextBox";
            this.AuditLog_RichTextBox.Size = new System.Drawing.Size(305, 190);
            this.AuditLog_RichTextBox.TabIndex = 2;
            this.AuditLog_RichTextBox.Text = "";
            // 
            // LogAudit_Button
            // 
            this.LogAudit_Button.Location = new System.Drawing.Point(317, 228);
            this.LogAudit_Button.Name = "LogAudit_Button";
            this.LogAudit_Button.Size = new System.Drawing.Size(75, 23);
            this.LogAudit_Button.TabIndex = 0;
            this.LogAudit_Button.Text = "Log Audit";
            this.LogAudit_Button.UseVisualStyleBackColor = true;
            this.LogAudit_Button.Click += new System.EventHandler(this.LogAudit_Button_Click);
            // 
            // AuditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 263);
            this.Controls.Add(this.AuditorControls_GroupBox);
            this.Name = "AuditorForm";
            this.Text = "Auditor";
            this.Load += new System.EventHandler(this.AuditorForm_Load);
            this.AuditorControls_GroupBox.ResumeLayout(false);
            this.AuditorControls_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AuditorControls_GroupBox;
        private System.Windows.Forms.Button LogAudit_Button;
        private System.Windows.Forms.RichTextBox AuditLog_RichTextBox;
        private System.Windows.Forms.Label Feeling_Label;
        private System.Windows.Forms.Label AuditReason_Label;
        private System.Windows.Forms.ComboBox AuditReason_ComboBox;
        private System.Windows.Forms.ComboBox Feeling_ComboBox;
    }
}

