namespace School_Management_System
{
    partial class ClassWindow
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
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(280, 500);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(887, 500);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(280, 440);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(887, 440);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(887, 60);
            // 
            // ClassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 500);
            this.Name = "ClassWindow";
            this.Text = "Classes";
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}