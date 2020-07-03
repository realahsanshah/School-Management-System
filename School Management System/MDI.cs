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
    public partial class MDI : Form
    {
        Helper helper = new Helper();
        private Login loginWindow;
        private Setting settingWindow;
        public MDI()
        {
            loginWindow = new Login();
            settingWindow = new Setting();
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path + "\\connect."))
            {
                loginWindow.MdiParent = this;
                loginWindow.WindowState = FormWindowState.Maximized;
                loginWindow.Show();
            }
            else
            {
                settingWindow.MdiParent = this;
                settingWindow.WindowState = FormWindowState.Maximized;
                settingWindow.Show();
            }



        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingWindow.MdiParent = this;
            settingWindow.WindowState = FormWindowState.Maximized;
            settingWindow.Show();
        }
    }
}
