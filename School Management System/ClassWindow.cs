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
    public partial class ClassWindow : Base2
    {
        public ClassWindow()
        {
            InitializeComponent();
        }

        private void usernameText_ControlRemoved(object sender, ControlEventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void classesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
