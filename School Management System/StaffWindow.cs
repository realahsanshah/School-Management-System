using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class StaffWindow : Base2
    {

        DatabaseDataContext db = new DatabaseDataContext();
        bool edit = false;
        string previousUsername;
        int staffId;

        public StaffWindow()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var data = db.staff_getStaff();
            userIdGV.DataPropertyName = "ID";
            nameGV.DataPropertyName = "Name";
            usernameGV.DataPropertyName = "Username";
            emailGV.DataPropertyName = "Email";
            phoneGV.DataPropertyName = "Phone";
            passwordGV.DataPropertyName = "Password";
            roleGV.DataPropertyName = "Role";
            statusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = data;
            Helper.CreateSerialNumbers(dataGridView1, "snoGV");

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
            if(!IsFilled())
            {
                Helper.ShowMessage("Please fill all the values", "Empty Fields", "Error");
                return;
            }

            if (!edit) //for save
            {

                if(usernameError.Visible)
                {
                    Helper.ShowMessage($"Username must be unique", "Error", "Error");
                }

                byte status = statusCB.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);

                String roleText = roleCB.GetItemText(roleCB.SelectedItem);


                int roleValue = db.Roles.SingleOrDefault(role => role.role_name == roleText).role_id;
                
                            
                if (imageAddress.Text =="")
                {
                    db.staff_insertWithoutImage(nameText.Text, emailText.Text, usernameText.Text, passwordText.Text, phoneText.Text, roleValue, status);
                    Helper.ShowMessage($"{nameText.Text} added successfully", "Success", "Success");
                }
                else
                {
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    byte[] imageArray = memoryStream.ToArray();

                    db.staff_insert(nameText.Text, emailText.Text, usernameText.Text, passwordText.Text, phoneText.Text, roleValue, status,imageArray);
                    Helper.ShowMessage($"{nameText.Text} added successfully", "Success", "Success");
                }
                Helper.DisableReset(panel6);
            }


            else if(edit) //for update
            {
                string previousUsername = db.Staffs.SingleOrDefault(s => s.staff_id == staffId).staff_username;

                if (!IsUsernameAvailable(usernameText.Text, previousUsername))
                {
                    Helper.ShowMessage("Please fill all the values", "Empty Fields", "Error");
                    return;
                }

                byte status = statusCB.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);

                String roleText = roleCB.GetItemText(roleCB.SelectedItem);


                int roleValue = db.Roles.SingleOrDefault(role => role.role_name == roleText).role_id;


                if (imageAddress.Text == "")
                {  
                    db.staff_updateWithoutImage(nameText.Text, emailText.Text, usernameText.Text, passwordText.Text, phoneText.Text, roleValue, status,staffId);
                    Helper.ShowMessage($"{nameText.Text} Updated successfully", "Success", "Success");
                }
                else
                {
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    byte[] imageArray = memoryStream.ToArray();

                    db.staff_update(nameText.Text, emailText.Text, usernameText.Text, passwordText.Text, phoneText.Text, roleValue, status,imageArray, staffId);
                    Helper.ShowMessage($"{nameText.Text} Updated successfully", "Success", "Success");
                }
                Helper.DisableReset(panel6);

            }
            imageBox.Image = null;
            LoadData();
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if(edit)
            {
                if (MessageBox.Show("Do you want to delete the data?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.staff_deleteStaff(staffId);
                    Helper.ShowMessage($"{nameText.Text} Deleted successfully", "Success", "Success");
                    Helper.DisableReset(panel6);
                    imageBox.Image = null;
                }
            }
            LoadData();
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
            var data = db.staff_search(searchText.Text);
            userIdGV.DataPropertyName = "ID";
            nameGV.DataPropertyName = "Name";
            usernameGV.DataPropertyName = "Username";
            emailGV.DataPropertyName = "Email";
            phoneGV.DataPropertyName = "Phone";
            passwordGV.DataPropertyName = "Password";
            roleGV.DataPropertyName = "Role";
            statusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = data;
            Helper.CreateSerialNumbers(dataGridView1, "snoGV");

        }

        private void usernameText_Leave(object sender, EventArgs e)
        {
            //Will use to verify if a username is available
            if (!edit) //for save
            {
                if (IsUsernameAvailable(usernameText.Text))
                    usernameError.Visible = false;
                else
                    usernameError.Visible = true;
            }
            else if(edit)
            {
                string previousUsername = db.Staffs.SingleOrDefault(s => s.staff_id == staffId).staff_username;

                if(IsUsernameAvailable(usernameText.Text,previousUsername))
                    usernameError.Visible = false;
                else
                    usernameError.Visible = true;
            }

        }
        public bool IsUsernameAvailable(string username)
        {
                bool result = false;
              
                bool isPresent = db.Staffs.Any(staff => staff.staff_username == username);
                result = !isPresent;
  

                return result;
        }

        public bool IsUsernameAvailable(string username,string previousUsername)
        {
            bool result = false;

            if (username.Equals(previousUsername))
                return true;

            //Staff previous = db.Staffs.Single(s => s.staff_username == previousUsername);

            bool isPresent = db.Staffs.Where(s=>s.staff_id!=staffId).Any(s => s.staff_username == username);

            result = !isPresent;

            return result;
        }


        public bool IsFilled()
        {
            bool flag = true;
            if (nameText.Text == "" || usernameText.Text == "" || passwordText.Text == "" || emailText.Text == "" || phoneText.Text == "" || roleCB.SelectedIndex == -1 || statusCB.SelectedIndex == -1)
                flag = false;
            return flag;
        }
        Image image;
        private void browseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= imageFileDialog.ShowDialog();
           
            if(dialogResult==DialogResult.OK)
            {
                image= new Bitmap(imageFileDialog.FileName);
                imageBox.Image = image;
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageAddress.Text = imageFileDialog.FileName;
            }
        }

        private void StaffWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.schoolDataSet.roles);
            Helper.DisableReset(panel6);

        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = true;
            if(e.RowIndex!=-1&&e.ColumnIndex!=-1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffId = Convert.ToInt32(row.Cells["userIdGV"].Value.ToString());
                nameText.Text = row.Cells["nameGV"].Value.ToString();
                usernameText.Text = row.Cells["usernameGV"].Value.ToString();
                emailText.Text = row.Cells["emailGV"].Value.ToString();
                phoneText.Text = row.Cells["phoneGV"].Value.ToString();

                passwordText.Text = row.Cells["passwordGV"].Value.ToString();
                roleCB.SelectedIndex = roleCB.FindStringExact(row.Cells["roleGV"].Value.ToString());
                statusCB.SelectedItem = row.Cells["statusGV"].Value.ToString();

                Staff staff = db.Staffs.SingleOrDefault(s => s.staff_id == staffId);
                var im = staff.staff_image;

                if (im != null)
                {
                    byte[] arr = im.ToArray();
                    MemoryStream memory = new MemoryStream(arr);
                    image = Image.FromStream(memory);
                    imageBox.Image = image;
                    imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    imageBox.Image = null;
                }
            }
        }
    }

}
