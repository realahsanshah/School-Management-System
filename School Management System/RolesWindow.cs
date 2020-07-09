using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class RolesWindow : Base2
    {
        int edit = 0;
        DatabaseDataContext db = new DatabaseDataContext();
        
        public RolesWindow()
        {
            InitializeComponent();
        }


        public override void addBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            Helper.EnableReset(panel6);

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            Helper.Enable(panel6);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (roleText.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
            if (statusCB.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (roleErrorLabel.Visible || statusErrorLabel.Visible)
            {
                Helper.ShowMessage("Fields with * are mandatory", "Error", "Error");
                return;
            }

            if (edit == 0)         //code for add
            {
                Role role = new Role();
                role.role_name = roleText.Text;

                if (statusCB.SelectedIndex == 0)
                    role.role_status = 1;
                else
                    role.role_status = 0;

                //db.Roles.InsertOnSubmit(role);

                db.role_insert(role.role_name, role.role_status);

                db.SubmitChanges();
                Helper.ShowMessage($"{roleText.Text} added successfully", "Success", "Success");
                Helper.DisableReset(panel6);
            }
            else if (edit == 1)    //code for update
            {

                //var data = db.Roles.Single(x => x.role_id==roleId);


                //data.role_name = roleText.Text;

                byte status;
                if (statusCB.SelectedIndex == 0)
                     status = 1;
                 else
                     status = 0;

                //db.SubmitChanges();

                db.role_update(roleId,roleText.Text, status);

                Helper.ShowMessage($"{roleText.Text} updated successfully", "Success", "Success");
                Helper.DisableReset(panel6);
            }
            LoadData();
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                if (MessageBox.Show("Do you want to delete the data?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.role_delete(roleId);

                    Helper.ShowMessage($"Role# {roleId} deleted Successfully", "Success", "Success");
                    Helper.DisableReset(panel6);
                }
                LoadData();
            }

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            SearchData();   
        }


        private void SearchData()
        {
            var data = db.role_search(searchText.Text);
            rolesIDGv.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = data;
            Helper.CreateSerialNumbers(dataGridView1, "snoGV");

        }

        private void roleText_TextChanged(object sender, EventArgs e)
        {
            if (roleText.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }

        private void statuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleText.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }

        private void RolesWindow_Load(object sender, EventArgs e)
        {
            Helper.DisableReset(panel6);
        }


        

        private void LoadData()
        {
            var result = db.role_getRoles();

            rolesIDGv.DataPropertyName = "ID";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = result;
            Helper.CreateSerialNumbers(dataGridView1, "snoGV");
        }

        int roleId;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                Helper.DisableReset(panel6);
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleId = Convert.ToInt32(row.Cells["rolesIDGv"].Value.ToString());

                roleText.Text = row.Cells["RoleGV"].Value.ToString();
                statusCB.SelectedItem = row.Cells["statusGV"].Value.ToString();
            }
        }
    }
}
