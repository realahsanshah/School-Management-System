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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sectionLbl = new System.Windows.Forms.Label();
            this.sectionCB = new System.Windows.Forms.ComboBox();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.classesList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rolesIDGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel6.Controls.Add(this.classesList);
            this.panel6.Controls.Add(this.addSectionButton);
            this.panel6.Controls.Add(this.sectionCB);
            this.panel6.Controls.Add(this.sectionLbl);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Size = new System.Drawing.Size(280, 440);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.textBox1, 0);
            this.panel6.Controls.SetChildIndex(this.sectionLbl, 0);
            this.panel6.Controls.SetChildIndex(this.sectionCB, 0);
            this.panel6.Controls.SetChildIndex(this.addSectionButton, 0);
            this.panel6.Controls.SetChildIndex(this.classesList, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(887, 440);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(887, 60);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 21);
            this.textBox1.TabIndex = 2;
            // 
            // sectionLbl
            // 
            this.sectionLbl.AutoSize = true;
            this.sectionLbl.Location = new System.Drawing.Point(13, 98);
            this.sectionLbl.Name = "sectionLbl";
            this.sectionLbl.Size = new System.Drawing.Size(48, 15);
            this.sectionLbl.TabIndex = 3;
            this.sectionLbl.Text = "Section";
            // 
            // sectionCB
            // 
            this.sectionCB.FormattingEnabled = true;
            this.sectionCB.Location = new System.Drawing.Point(16, 116);
            this.sectionCB.Name = "sectionCB";
            this.sectionCB.Size = new System.Drawing.Size(258, 23);
            this.sectionCB.TabIndex = 4;
            // 
            // addSectionButton
            // 
            this.addSectionButton.FlatAppearance.BorderSize = 2;
            this.addSectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSectionButton.Location = new System.Drawing.Point(16, 145);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(258, 39);
            this.addSectionButton.TabIndex = 5;
            this.addSectionButton.Text = "ADD";
            this.addSectionButton.UseVisualStyleBackColor = true;
            // 
            // classesList
            // 
            this.classesList.FormattingEnabled = true;
            this.classesList.ItemHeight = 15;
            this.classesList.Location = new System.Drawing.Point(16, 190);
            this.classesList.Name = "classesList";
            this.classesList.Size = new System.Drawing.Size(258, 94);
            this.classesList.TabIndex = 6;
            this.classesList.SelectedIndexChanged += new System.EventHandler(this.classesList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 391);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolesIDGv,
            this.snoGV,
            this.RoleGV,
            this.StatusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(881, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // rolesIDGv
            // 
            this.rolesIDGv.HeaderText = "Role ID";
            this.rolesIDGv.Name = "rolesIDGv";
            this.rolesIDGv.ReadOnly = true;
            this.rolesIDGv.Visible = false;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "S#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 48;
            // 
            // RoleGV
            // 
            this.RoleGV.HeaderText = "Role";
            this.RoleGV.Name = "RoleGV";
            this.RoleGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
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
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label sectionLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox classesList;
        private System.Windows.Forms.Button addSectionButton;
        private System.Windows.Forms.ComboBox sectionCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesIDGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}