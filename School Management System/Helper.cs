using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;

namespace School_Management_System
{
    class Helper
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void SwitchWindows(Form openingWindow, Form closingWindow, Form MDI)
        {
            closingWindow.Close();

            openingWindow.WindowState = FormWindowState.Maximized;
            openingWindow.MdiParent = MDI;
            openingWindow.Show();
        }

        public static DialogResult ShowMessage(string msg, string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DisableReset(Panel p)
        {
            foreach (Control control in p.Controls)
            {
                if(control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = false;
                }
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = false;
                    textBox.Text = "";
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = false;
                    component.SelectedIndex = -1;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = false;
                    component.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = false;
                    component.Value = DateTime.Now;
                }

                
            }
        }
        public static void DisableReset(GroupBox p)
        {
            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = false;
                }

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = false;
                    textBox.Text = "";
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = false;
                    component.SelectedIndex = -1;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = false;
                    component.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = false;
                    component.Value = DateTime.Now;
                }
            }
        }

        public static void Disable(Panel p)
        {
            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = false;
                }

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = false;
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = false;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = false;
                }
            }
        }

        public static void Disable(GroupBox p)
        {
            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = false;
                }

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = false;
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = false;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = false;
                }
            }
        }


        public static void EnableReset(Panel p)
        {
            foreach (Control control in p.Controls)
            {

                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                }

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = true;
                    textBox.Text = "";
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = true;
                    component.SelectedIndex = -1;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = true;
                    component.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = false;
                    component.Value = DateTime.Now;
                }
            }
        }

        public static void EnableReset(GroupBox p)
        {
            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                }

                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = true;
                    textBox.Text = "";
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = true;
                    component.SelectedIndex = -1;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = true;
                    component.Checked = false;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = false;
                    component.Value = DateTime.Now;
                }
            }
        }

        public static void Enable(Panel p)
        {
            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                }


                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = true;
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = true;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = true;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = true;
                }
            }
        }

        public static void Enable(GroupBox p)
        {
            foreach (Control control in p.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                }


                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Enabled = true;
                }

                if (control is ComboBox)
                {
                    ComboBox component = (ComboBox)control;
                    component.Enabled = true;
                }

                if (control is RadioButton)
                {
                    RadioButton component = (RadioButton)control;
                    component.Enabled = true;
                }
                if (control is DateTimePicker)
                {
                    DateTimePicker component = (DateTimePicker)control;
                    component.Enabled = true;
                }
            }
        }

        public static void CreateSerialNumbers(DataGridView gridView, string columnName)
        {
            int count = 1;
            foreach(DataGridViewRow row in gridView.Rows)
            {
                row.Cells[columnName].Value = count;
                count++;
            }

        }
    }

}
