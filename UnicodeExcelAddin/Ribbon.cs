using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace UnicodeExcelAddin
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnSelectedText_Click(object sender, RibbonControlEventArgs e)
        {
            Conversion.checkForSelected();
        }

        private void btnWholeText_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btnSearchWord_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btnSorting_Click(object sender, RibbonControlEventArgs e)
        {
            frmSortingOption sop = new frmSortingOption();
            sop.Show();
        }
    }
}
