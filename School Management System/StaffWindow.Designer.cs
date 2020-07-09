namespace School_Management_System
{
    partial class StaffWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new School_Management_System.schoolDataSet();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.imageAddress = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.usernameError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new School_Management_System.schoolDataSetTableAdapters.rolesTableAdapter();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Size = new System.Drawing.Size(137, 22);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(280, 679);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(749, 679);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.usernameError);
            this.panel6.Controls.Add(this.imageBox);
            this.panel6.Controls.Add(this.passwordText);
            this.panel6.Controls.Add(this.passwordLbl);
            this.panel6.Controls.Add(this.usernameText);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.browseBtn);
            this.panel6.Controls.Add(this.imageAddress);
            this.panel6.Controls.Add(this.imageLabel);
            this.panel6.Controls.Add(this.statusCB);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.roleCB);
            this.panel6.Controls.Add(this.roleLabel);
            this.panel6.Controls.Add(this.phoneText);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.emailText);
            this.panel6.Controls.Add(this.emailLabel);
            this.panel6.Controls.Add(this.nameText);
            this.panel6.Controls.Add(this.nameLbl);
            this.panel6.Size = new System.Drawing.Size(280, 619);
            this.panel6.Controls.SetChildIndex(this.nameLbl, 0);
            this.panel6.Controls.SetChildIndex(this.nameText, 0);
            this.panel6.Controls.SetChildIndex(this.emailLabel, 0);
            this.panel6.Controls.SetChildIndex(this.emailText, 0);
            this.panel6.Controls.SetChildIndex(this.label1, 0);
            this.panel6.Controls.SetChildIndex(this.phoneText, 0);
            this.panel6.Controls.SetChildIndex(this.roleLabel, 0);
            this.panel6.Controls.SetChildIndex(this.roleCB, 0);
            this.panel6.Controls.SetChildIndex(this.label2, 0);
            this.panel6.Controls.SetChildIndex(this.statusCB, 0);
            this.panel6.Controls.SetChildIndex(this.imageLabel, 0);
            this.panel6.Controls.SetChildIndex(this.imageAddress, 0);
            this.panel6.Controls.SetChildIndex(this.browseBtn, 0);
            this.panel6.Controls.SetChildIndex(this.label4, 0);
            this.panel6.Controls.SetChildIndex(this.usernameText, 0);
            this.panel6.Controls.SetChildIndex(this.passwordLbl, 0);
            this.panel6.Controls.SetChildIndex(this.passwordText, 0);
            this.panel6.Controls.SetChildIndex(this.imageBox, 0);
            this.panel6.Controls.SetChildIndex(this.usernameError, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Size = new System.Drawing.Size(749, 619);
            this.panel5.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(749, 60);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Tahoma", 9F);
            this.nameLbl.Location = new System.Drawing.Point(13, 56);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 14);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(16, 73);
            this.nameText.MaxLength = 50;
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(238, 21);
            this.nameText.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.emailLabel.Location = new System.Drawing.Point(13, 187);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(34, 14);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(16, 204);
            this.emailText.MaxLength = 25;
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(238, 21);
            this.emailText.TabIndex = 5;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(16, 246);
            this.phoneText.MaxLength = 14;
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(238, 21);
            this.phoneText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(13, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phone Number";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(13, 270);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(33, 15);
            this.roleLabel.TabIndex = 12;
            this.roleLabel.Text = "Role";
            // 
            // roleCB
            // 
            this.roleCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolesBindingSource, "role_id", true));
            this.roleCB.DataSource = this.rolesBindingSource;
            this.roleCB.DisplayMember = "role_name";
            this.roleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Location = new System.Drawing.Point(16, 289);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(238, 23);
            this.roleCB.TabIndex = 10;
            this.roleCB.ValueMember = "role_id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.schoolDataSet;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(School_Management_System.Role);
            // 
            // statusCB
            // 
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCB.Location = new System.Drawing.Point(16, 335);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(238, 23);
            this.statusCB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(13, 366);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(42, 15);
            this.imageLabel.TabIndex = 16;
            this.imageLabel.Text = "Image";
            // 
            // imageAddress
            // 
            this.imageAddress.Enabled = false;
            this.imageAddress.Location = new System.Drawing.Point(16, 384);
            this.imageAddress.Name = "imageAddress";
            this.imageAddress.Size = new System.Drawing.Size(238, 21);
            this.imageAddress.TabIndex = 14;
            // 
            // browseBtn
            // 
            this.browseBtn.FlatAppearance.BorderSize = 2;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Location = new System.Drawing.Point(16, 412);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(238, 42);
            this.browseBtn.TabIndex = 13;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(16, 161);
            this.passwordText.MaxLength = 15;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(238, 21);
            this.passwordText.TabIndex = 4;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Tahoma", 9F);
            this.passwordLbl.Location = new System.Drawing.Point(13, 144);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(58, 14);
            this.passwordLbl.TabIndex = 21;
            this.passwordLbl.Text = "Password";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(16, 119);
            this.usernameText.MaxLength = 25;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(238, 21);
            this.usernameText.TabIndex = 3;
            this.usernameText.Leave += new System.EventHandler(this.usernameText_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "Username";
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(16, 472);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(238, 135);
            this.imageBox.TabIndex = 23;
            this.imageBox.TabStop = false;
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "openFileDialog1";
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Location = new System.Drawing.Point(117, 101);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(137, 15);
            this.usernameError.TabIndex = 24;
            this.usernameError.Text = "Username not available";
            this.usernameError.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 570);
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
            this.passwordGV,
            this.userIdGV,
            this.nameGV,
            this.usernameGV,
            this.emailGV,
            this.phoneGV,
            this.roleGV,
            this.statusGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 549);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // roleBindingSource1
            // 
            this.roleBindingSource1.DataSource = typeof(School_Management_System.Role);
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.snoGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.snoGV.HeaderText = "S#";
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 48;
            // 
            // passwordGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.passwordGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.passwordGV.HeaderText = "Password";
            this.passwordGV.Name = "passwordGV";
            this.passwordGV.ReadOnly = true;
            this.passwordGV.Visible = false;
            // 
            // userIdGV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userIdGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.userIdGV.HeaderText = "User ID";
            this.userIdGV.Name = "userIdGV";
            this.userIdGV.ReadOnly = true;
            // 
            // nameGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nameGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.nameGV.HeaderText = "Name";
            this.nameGV.Name = "nameGV";
            this.nameGV.ReadOnly = true;
            // 
            // usernameGV
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.usernameGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.usernameGV.HeaderText = "Username";
            this.usernameGV.Name = "usernameGV";
            this.usernameGV.ReadOnly = true;
            // 
            // emailGV
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.emailGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.emailGV.HeaderText = "Email";
            this.emailGV.Name = "emailGV";
            this.emailGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.phoneGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.phoneGV.HeaderText = "Phone #";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // roleGV
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.roleGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.roleGV.HeaderText = "Role";
            this.roleGV.Name = "roleGV";
            this.roleGV.ReadOnly = true;
            // 
            // statusGV
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.statusGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // StaffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 679);
            this.Name = "StaffWindow";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.StaffWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox imageAddress;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource1;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private schoolDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}