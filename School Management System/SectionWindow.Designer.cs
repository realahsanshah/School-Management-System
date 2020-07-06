namespace School_Management_System
{
    partial class SectionWindow
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
            this.sectionLabel = new System.Windows.Forms.Label();
            this.sectionNameText = new System.Windows.Forms.TextBox();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(280, 503);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(757, 503);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusLbl);
            this.panel6.Controls.Add(this.statusCB);
            this.panel6.Controls.Add(this.sectionNameText);
            this.panel6.Controls.Add(this.sectionLabel);
            this.panel6.Size = new System.Drawing.Size(280, 443);
            this.panel6.Controls.SetChildIndex(this.sectionLabel, 0);
            this.panel6.Controls.SetChildIndex(this.sectionNameText, 0);
            this.panel6.Controls.SetChildIndex(this.statusCB, 0);
            this.panel6.Controls.SetChildIndex(this.statusLbl, 0);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Size = new System.Drawing.Size(757, 460);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(757, 43);
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(13, 56);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(85, 15);
            this.sectionLabel.TabIndex = 1;
            this.sectionLabel.Text = "Section Name";
            // 
            // sectionNameText
            // 
            this.sectionNameText.Location = new System.Drawing.Point(16, 75);
            this.sectionNameText.Name = "sectionNameText";
            this.sectionNameText.Size = new System.Drawing.Size(245, 21);
            this.sectionNameText.TabIndex = 2;
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCB.Location = new System.Drawing.Point(16, 120);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(245, 23);
            this.statusCB.TabIndex = 3;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(13, 102);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(41, 15);
            this.statusLbl.TabIndex = 4;
            this.statusLbl.Text = "Status";
            // 
            // SectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 503);
            this.Name = "SectionWindow";
            this.Text = "Sections";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.TextBox sectionNameText;
        private System.Windows.Forms.Label sectionLabel;
    }
}