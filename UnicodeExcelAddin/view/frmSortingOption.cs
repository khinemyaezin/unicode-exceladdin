using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeExcelAddin
{
    public partial class frmSortingOption : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private bool myOption;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmSortingOption()
        {
            InitializeComponent();
        }

        private void pbAcending_Click(object sender, EventArgs e)
        {
            this.rdAscending.Checked = true;
        }

        private void pbDescending_Click(object sender, EventArgs e)
        {
            this.rdDescending.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Sorting sorting = new Sorting(this);
            if (this.rdAscending.Checked)
            {
                sorting.ascending();
            }
            else
            {
                sorting.descending();
            }
        }

        private void frmSortingOption_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
