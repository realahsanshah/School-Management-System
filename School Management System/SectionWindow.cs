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
    public partial class SectionWindow : Base2
    {

        int edit = 0;
        int sectionId;
        DatabaseDataContext db = new DatabaseDataContext();
        public SectionWindow()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var result = db.section_getSections(); 

            sectionIDGv.DataPropertyName = "ID";
            sectionGV.DataPropertyName = "Section";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = result;
            Helper.CreateSerialNumbers(dataGridView1, "snoGV");
        }

        private void sectionNameText_TextChanged(object sender, EventArgs e)
        {
            if (sectionNameText.Text == "")
                nameErrorLabel.Visible = true;
            else
                nameErrorLabel.Visible = false;
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
            if (!isFilled())
            {
                nameErrorLabel.Visible = true;
                statusErrorLabel.Visible = true;

                Helper.ShowMessage("Fields with * are mandatory", "Error", "Error");
            }

            if (edit == 0)         //code for add
            {
                Section section = new Section();
                section.sec_name = sectionNameText.Text;
                
                if (statusCB.SelectedIndex == 0)
                    section.sec_status = 1;
                else
                    section.sec_status = 0;

                

                db.section_insert(section.sec_name, section.sec_status);

                db.SubmitChanges();
                Helper.ShowMessage($"{sectionNameText.Text} added successfully", "Success", "Success");
                Helper.DisableReset(panel6);
            }
            else if (edit == 1)    //code for update
            {

     

                byte status;
                if (statusCB.SelectedIndex == 0)
                    status = 1;
                else
                    status = 0;

                //db.SubmitChanges();

                db.section_update(sectionNameText.Text, status, sectionId);

                Helper.ShowMessage($"{sectionNameText.Text} updated successfully", "Success", "Success");
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
                    db.section_delete(sectionId);

                    Helper.ShowMessage($"Section# {sectionId} deleted Successfully", "Success", "Success");
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
            var data = db.section_search(searchText.Text);
            sectionIDGv.DataPropertyName = "ID";
            sectionGV.DataPropertyName = "Section";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = data;
            Helper.CreateSerialNumbers(dataGridView1, "snoGV");

        }

        private void statusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusCB.SelectedIndex==-1)
                statusErrorLabel.Visible = true;
            else
                statusErrorLabel.Visible = false;
        }

        public bool isFilled()
        {
            return ((sectionNameText.Text != "") && (statusCB.SelectedIndex != -1));
        }

        private void SectionWindow_Load(object sender, EventArgs e)
        {
            Helper.DisableReset(panel6);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                Helper.DisableReset(panel6);
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                sectionId = Convert.ToInt32(row.Cells["sectionIDGv"].Value.ToString());

                sectionNameText.Text = row.Cells["sectionGV"].Value.ToString();
                statusCB.SelectedItem = row.Cells["statusGV"].Value.ToString();
            }
        }
    }
}
