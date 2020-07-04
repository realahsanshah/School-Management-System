using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Setting : Base
    {
        public Setting()
        {
            InitializeComponent();
        }


        private void checkedChange(object sender, EventArgs e)
        {
            usernameText.Text = "";
            passwordText.Text = "";
            usernameText.Enabled = !usernameText.Enabled;
            passwordText.Enabled = !passwordText.Enabled;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            if ((dataSourceText.Text == "" || databaseText.Text == "") || ((intergratedCheckBox.Checked == false) && (usernameText.Text == "" || passwordText.Text == "")))
            {
                MessageBox.Show("*Required fields cannot be empty");
                return;
            }
            stringBuilder.Append("Data Source=" + dataSourceText.Text + ";");
            stringBuilder.Append("Initial Catalog=" + databaseText.Text + ";");
            if (!intergratedCheckBox.Checked)
            {
                stringBuilder.Append("User ID=" + usernameText.Text + ";");
                stringBuilder.Append("Password=" + passwordText.Text + ";");
            }
            else
            {
                stringBuilder.Append("Integrated Security=true;");
            }
            File.WriteAllText(Helper.path + "\\connect",stringBuilder.ToString());;

            DialogResult result=MessageBox.Show("Setting Saved Successfully","Success",MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                Login login = new Login();
                Helper.SwitchWindows(login, this, MDI.ActiveForm);

            }

        }

        private void dataSourceText_TextChanged(object sender, EventArgs e)
        {
            if (dataSourceText.Text == "")
            {
                dataSourceError.Text = "*Required";
                dataSourceError.Visible = true;
            }
            else
            {
                dataSourceError.Visible = false;
            }
        }

        private void databaseText_TextChanged(object sender, EventArgs e)
        {
            if (databaseText.Text == "")
            {
                databaseError.Text = "*Required";
                databaseError.Visible = true;
            }
            else
            {
                databaseError.Visible = false;
            }
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            if (intergratedCheckBox.Checked)
                return;
            if (usernameText.Text == "")
            {
                usernameError.Text = "*Required";
                usernameError.Visible = true;
            }
            else
            {
                usernameError.Visible = false;
            }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (intergratedCheckBox.Checked)
                return;
            if (passwordText.Text == "")
            {
                passwordError.Text = "*Required";
                passwordError.Visible = true;
            }
            else
            {
                passwordError.Visible = false;
            }
        }
    }
}
