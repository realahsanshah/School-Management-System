using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class StaffWindow : Base2
    {
        bool edit = false;
        public StaffWindow()
        {
            InitializeComponent();
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {
            Helper.EnableReset(panel6);
            imageAddress.Enabled = false;
            edit = false;
        }


        public override void editBtn_Click(object sender, EventArgs e)
        {
            Helper.Enable(panel6);
            edit = true;
            imageAddress.Enabled = false; 
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if(!isFilled())
            {
                Helper.ShowMessage("Please fill all the values", "Empty Fields", "Error");
                return;
            }
            if (!edit) //for save
            {

            }
            else if(edit) //for update
            {

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

        private void usernameText_Leave(object sender, EventArgs e)
        {
            //Will use to verify if a username is available

        }

        public bool isFilled()
        {
            bool flag = true;
            if (nameText.Text == "" || usernameText.Text == "" || passwordText.Text == "" || emailText.Text == "" || phoneText.Text == "" || roleCB.SelectedIndex == -1 || statusCB.SelectedIndex == -1)
                flag = false;
            return flag;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= imageFileDialog.ShowDialog();
           
            if(dialogResult==DialogResult.OK)
            {
                Image image = new Bitmap(imageFileDialog.FileName);
                imageBox.Image = image;
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageAddress.Text = imageFileDialog.FileName;
            }
        }

        private void StaffWindow_Load(object sender, EventArgs e)
        {
            Helper.DisableReset(panel6);

        }
    }
}
