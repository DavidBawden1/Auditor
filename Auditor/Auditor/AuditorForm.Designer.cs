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
            this.SuspendLayout();
            // 
            // AuditorControls_GroupBox
            // 
            this.AuditorControls_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuditorControls_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.AuditorControls_GroupBox.Name = "AuditorControls_GroupBox";
            this.AuditorControls_GroupBox.Size = new System.Drawing.Size(344, 235);
            this.AuditorControls_GroupBox.TabIndex = 0;
            this.AuditorControls_GroupBox.TabStop = false;
            this.AuditorControls_GroupBox.Text = "Controls";
            // 
            // AuditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 235);
            this.Controls.Add(this.AuditorControls_GroupBox);
            this.Name = "AuditorForm";
            this.Text = "Auditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AuditorControls_GroupBox;
    }
}

