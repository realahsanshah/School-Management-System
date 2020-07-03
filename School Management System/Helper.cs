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
        public string path= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void SwitchWindows(Form openingWindow,Form closingWindow,Form MDI)
        {
            closingWindow.Close();

            openingWindow.WindowState = FormWindowState.Maximized;
            openingWindow.MdiParent = MDI;
        }
    }
}
