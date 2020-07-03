namespace School_Management_System
{
    partial class Setting
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.databaseText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSourceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.intergratedCheckBox = new System.Windows.Forms.CheckBox();
            this.dataSourceError = new System.Windows.Forms.Label();
            this.databaseError = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(280, 507);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(742, 507);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.passwordError);
            this.panel6.Controls.Add(this.usernameError);
            this.panel6.Controls.Add(this.databaseError);
            this.panel6.Controls.Add(this.dataSourceError);
            this.panel6.Controls.Add(this.intergratedCheckBox);
            this.panel6.Controls.Add(this.passwordText);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.usernameText);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.saveBtn);
            this.panel6.Controls.Add(this.databaseText);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.dataSourceText);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(280, 467);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(742, 467);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(742, 40);
            this.panel4.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.saveBtn.Location = new System.Drawing.Point(12, 324);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(224, 43);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "&SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // databaseText
            // 
            this.databaseText.Location = new System.Drawing.Point(12, 181);
            this.databaseText.Name = "databaseText";
            this.databaseText.Size = new System.Drawing.Size(224, 21);
            this.databaseText.TabIndex = 8;
            this.databaseText.TextChanged += new System.EventHandler(this.databaseText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Database";
            // 
            // dataSourceText
            // 
            this.dataSourceText.Location = new System.Drawing.Point(12, 135);
            this.dataSourceText.Name = "dataSourceText";
            this.dataSourceText.Size = new System.Drawing.Size(224, 21);
            this.dataSourceText.TabIndex = 6;
            this.dataSourceText.TextChanged += new System.EventHandler(this.dataSourceText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Source";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(12, 270);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(224, 21);
            this.passwordText.TabIndex = 13;
            this.passwordText.UseSystemPasswordChar = true;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(12, 224);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(224, 21);
            this.usernameText.TabIndex = 11;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // intergratedCheckBox
            // 
            this.intergratedCheckBox.AutoSize = true;
            this.intergratedCheckBox.Font = new System.Drawing.Font("Tahoma", 9F);
            this.intergratedCheckBox.Location = new System.Drawing.Point(15, 301);
            this.intergratedCheckBox.Name = "intergratedCheckBox";
            this.intergratedCheckBox.Size = new System.Drawing.Size(133, 18);
            this.intergratedCheckBox.TabIndex = 14;
            this.intergratedCheckBox.Text = "Integrated Security";
            this.intergratedCheckBox.UseVisualStyleBackColor = true;
            this.intergratedCheckBox.CheckedChanged += new System.EventHandler(this.checkedChange);
            // 
            // dataSourceError
            // 
            this.dataSourceError.AutoSize = true;
            this.dataSourceError.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dataSourceError.ForeColor = System.Drawing.Color.Khaki;
            this.dataSourceError.Location = new System.Drawing.Point(174, 118);
            this.dataSourceError.Name = "dataSourceError";
            this.dataSourceError.Size = new System.Drawing.Size(62, 14);
            this.dataSourceError.TabIndex = 16;
            this.dataSourceError.Text = "*Required";
            this.dataSourceError.Visible = false;
            // 
            // databaseError
            // 
            this.databaseError.AutoSize = true;
            this.databaseError.Font = new System.Drawing.Font("Tahoma", 9F);
            this.databaseError.ForeColor = System.Drawing.Color.Khaki;
            this.databaseError.Location = new System.Drawing.Point(174, 164);
            this.databaseError.Name = "databaseError";
            this.databaseError.Size = new System.Drawing.Size(62, 14);
            this.databaseError.TabIndex = 17;
            this.databaseError.Text = "*Required";
            this.databaseError.Visible = false;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Font = new System.Drawing.Font("Tahoma", 9F);
            this.usernameError.ForeColor = System.Drawing.Color.Khaki;
            this.usernameError.Location = new System.Drawing.Point(174, 207);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(62, 14);
            this.usernameError.TabIndex = 18;
            this.usernameError.Text = "*Required";
            this.usernameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Tahoma", 9F);
            this.passwordError.ForeColor = System.Drawing.Color.Khaki;
            this.passwordError.Location = new System.Drawing.Point(174, 253);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(62, 14);
            this.passwordError.TabIndex = 19;
            this.passwordError.Text = "*Required";
            this.passwordError.Visible = false;
            // 
            // Setting
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 507);
            this.ControlBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox databaseText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataSourceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox intergratedCheckBox;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label databaseError;
        private System.Windows.Forms.Label dataSourceError;
    }
}