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
        public SectionWindow()
        {
            InitializeComponent();
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
            Helper.EnableReset(panel6);
        }


        public override void editBtn_Click(object sender, EventArgs e)
        {
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

           
        }


        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {

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
    }
}
