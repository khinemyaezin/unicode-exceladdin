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
    public partial class frmFontConvertOption : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private bool myOption;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmFontConvertOption(bool option)
        {
            InitializeComponent();
            this.myOption = option;
        }

        private void frmFontConvertOption_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFontConvertOption_Load(object sender, EventArgs e)
        {
            string[] s =
            {
                 "Academy","Amyanmar","AvaForever","CE-Family","M-Myanmar-Family","I",
                "MyaZedi","Pinny-Family","Win-Family","Zawgyi-One"
            };
            foreach (string item in s)
            {
                this.combo.Items.Add(item);
            }
            this.combo.SelectedIndex = 9;
            this.comboUnicode.Items.Add("Unicode");
            this.comboUnicode.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            UniConversion.Converter.ConvertOption convertOption;
            switch (this.combo.SelectedIndex)
            {
                case 0: convertOption = UniConversion.Converter.ConvertOption.Academy2Uni; break;
                case 1: convertOption = UniConversion.Converter.ConvertOption.Amyanmar2Uni; break;
                case 2: convertOption = UniConversion.Converter.ConvertOption.Ava2Uni; break;
                //      case 3: convertOption = UniConversion.Converter.ConvertOption.Ayar2Uni; break;
                case 3: convertOption = UniConversion.Converter.ConvertOption.CE2Uni; break;
                case 4: convertOption = UniConversion.Converter.ConvertOption.I2Uni; break;
                //      case 6: convertOption = UniConversion.Converter.ConvertOption.Myanmar2Uni; break;
                case 5: convertOption = UniConversion.Converter.ConvertOption.Myanmar12Uni; break;
                case 6: convertOption = UniConversion.Converter.ConvertOption.MyaZedi2Uni; break;
                case 7: convertOption = UniConversion.Converter.ConvertOption.Pinny52Uni; break;
                case 8: convertOption = UniConversion.Converter.ConvertOption.Win2Uni; break;

                default: convertOption = UniConversion.Converter.ConvertOption.Zawgyi2Uni; break;
            }
            if (this.myOption == true)
            {
                Conversion.convertSelectedText(convertOption);
            }
            else
            {
                Conversion.convertForWhole(convertOption);
            }

            MessageBox.Show("Conversion Process is finished..!");
            this.Close();
        }
    }
}
