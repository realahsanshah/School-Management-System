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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.sectionNameText = new System.Windows.Forms.TextBox();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionIDGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(135, 22);
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
            this.panel6.Controls.Add(this.nameErrorLabel);
            this.panel6.Controls.Add(this.statusErrorLabel);
            this.panel6.Size = new System.Drawing.Size(280, 443);
            this.panel6.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.nameErrorLabel, 0);
            this.panel6.Controls.SetChildIndex(this.sectionLabel, 0);
            this.panel6.Controls.SetChildIndex(this.sectionNameText, 0);
            this.panel6.Controls.SetChildIndex(this.statusCB, 0);
            this.panel6.Controls.SetChildIndex(this.statusLbl, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Size = new System.Drawing.Size(757, 460);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
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
            this.sectionNameText.TextChanged += new System.EventHandler(this.sectionNameText_TextChanged);
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusCB.Location = new System.Drawing.Point(16, 120);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(245, 23);
            this.statusCB.TabIndex = 3;
            this.statusCB.SelectedIndexChanged += new System.EventHandler(this.statusCB_SelectedIndexChanged);
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
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.Location = new System.Drawing.Point(241, 56);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.nameErrorLabel.TabIndex = 5;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.Location = new System.Drawing.Point(241, 102);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.statusErrorLabel.TabIndex = 6;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 411);
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
            this.snoGV,
            this.sectionIDGv,
            this.sectionGV,
            this.StatusGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 390);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "S#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 48;
            // 
            // sectionIDGv
            // 
            this.sectionIDGv.HeaderText = "Section ID";
            this.sectionIDGv.Name = "sectionIDGv";
            this.sectionIDGv.ReadOnly = true;
            this.sectionIDGv.Visible = false;
            // 
            // sectionGV
            // 
            this.sectionGV.HeaderText = "Section";
            this.sectionGV.Name = "sectionGV";
            this.sectionGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // SectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 503);
            this.Name = "SectionWindow";
            this.Text = "Sections";
            this.Load += new System.EventHandler(this.SectionWindow_Load);
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

        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.TextBox sectionNameText;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionIDGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}