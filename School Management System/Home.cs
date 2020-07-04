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
    public partial class Home : Base
    {
        public Home()
        {
            InitializeComponent();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffWindow staff = new StaffWindow();
            Helper.SwitchWindows(staff, this, MDI.ActiveForm);
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            ClassWindow classWindow = new ClassWindow();
            Helper.SwitchWindows(classWindow, this, MDI.ActiveForm);
        }

        private void sectionBtn_Click(object sender, EventArgs e)
        {
            SectionWindow sectionWindow = new SectionWindow();
            Helper.SwitchWindows(sectionWindow, this, MDI.ActiveForm);
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            StudentWindow studentWindow = new StudentWindow();
            Helper.SwitchWindows(studentWindow, this, MDI.ActiveForm);
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {
            RolesWindow rolesWindow = new RolesWindow();
            Helper.SwitchWindows(rolesWindow, this, MDI.ActiveForm);
        }
    }
}
