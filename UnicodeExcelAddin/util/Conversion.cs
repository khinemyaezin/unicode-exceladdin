using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace UnicodeExcelAddin
{
    static class Conversion
    {
        public static void checkForSelected()
        {
            Range currentCell;
            Worksheet activeWorkSheet = Globals.ThisAddIn.GetActiveWorkSheet();

            Range selectRange = (Range)activeWorkSheet.Application.Selection;
            Range used = (Range)activeWorkSheet.UsedRange;

            int totalRows = 0;
            if (used.Rows.Count > selectRange.Rows.Count)
            {
                totalRows = selectRange.Rows.Count;
            }
            else
            {
                totalRows = used.Rows.Count;
            }
            int totalColumns = 0;
            if (used.Columns.Count > selectRange.Columns.Count)
            {
                totalColumns = selectRange.Columns.Count;
            }
            else
            {
                totalColumns = used.Columns.Count;
            }
            StringBuilder strBil = new StringBuilder();
            for (int i = 1; i <= totalRows; i++)
            {
                for (int j = 1; j <= totalColumns; j++)
                {
                    currentCell = ((Range)selectRange.Cells[i, j]);
                    strBil.Append((string)currentCell.Value2);
                }
            }
            if (strBil.ToString() == "")
            {
                System.Windows.Forms.MessageBox.Show("Please Select Cell with Texts that you want to Convert..!");
            }
            else
            {
                frmFontConvertOption view = new frmFontConvertOption(true);
                view.Show();
            }
        }

        public static void convertSelectedText(UniConversion.Converter.ConvertOption option)
        {
            Range currentCell;
            Worksheet activeWorkSheet = Globals.ThisAddIn.GetActiveWorkSheet();

            Range selected = (Range)activeWorkSheet.Application.Selection;
            Range used = (Range)activeWorkSheet.UsedRange;
            int totalRows = 0;
            if (used.Rows.Count > selected.Rows.Count)
            {
                totalRows = selected.Rows.Count;
            }
            else
            {
                totalRows = used.Rows.Count;
            }
            int totalColumns = 0;
            if (used.Columns.Count > selected.Columns.Count)
            {
                totalColumns = selected.Columns.Count;
            }
            else
            {
                totalColumns = used.Columns.Count;
            }
            for (int i = 1; i <= totalRows; i++)
            {
                for (int j = 1; j <= totalColumns; j++)
                {
                    currentCell = ((Range)selected.Cells[i, j]);
                    if (currentCell != null)
                    {
                        if (((string)currentCell.Text) != "")
                        {
                            string srcTxt = (string)currentCell.Value2;
                            string uniTxt = UniConversion.Converter.Convert(srcTxt, option);
                            currentCell.Value2 = uniTxt;
                        }
                    }
                }
            }
            selected.Font.Name = "Myanmar3";
            //    mf.Close();
        }

        public static void checkForWhole()
        {
            Range currentCell;
            Worksheet activeWorkSheet = Globals.ThisAddIn.GetActiveWorkSheet();
            Range selected = (Range)activeWorkSheet.Application.Selection;
            Range used = (Range)activeWorkSheet.UsedRange;

            int totalRows = used.Rows.Count;
            int totalColumns = used.Columns.Count;
            if (totalRows == 0)
            {
                System.Windows.Forms.MessageBox.Show("Please Insert Text that you want to Convert..!");
            }
            else
            {
                StringBuilder strBil = new StringBuilder();
                for (int i = 1; i <= totalRows; i++)
                {
                    for (int j = 1; j <= totalColumns; j++)
                    {
                        currentCell = ((Range)used.Cells[i, j]);
                        strBil.Append((string)currentCell.Value2);
                    }
                }
                if (strBil.ToString() == "")
                {
                    System.Windows.Forms.MessageBox.Show("Please Select Cell with Texts that you want to Convert..!");
                }
                else
                {
                    frmFontConvertOption fofs = new frmFontConvertOption(false);
                    fofs.Show();
                }
            }
        }

        public static void convertForWhole(UniConversion.Converter.ConvertOption option)
        {
            Range currentCell;
            Worksheet activeWorkSheet = Globals.ThisAddIn.GetActiveWorkSheet();

            Range selected = (Range)activeWorkSheet.Application.Selection;
            Range usedRange = (Range)activeWorkSheet.UsedRange;

            int totalRows = usedRange.Rows.Count;
            int totalColumns = usedRange.Columns.Count;
            //System.Windows.Forms.MessageBox.Show(totalRows + " , " + totalColumns);

            for (int i = 1; i <= totalRows; i++)
            {
                for (int j = 1; j <= totalColumns; j++)
                {
                    currentCell = ((Range)usedRange.Cells[i, j]);
                    //currentCell.Value2 = "got it";
                    if (currentCell != null)
                    {
                        //System.Windows.Forms.MessageBox.Show("converting....0");
                        if (((string)currentCell.Text) != "")
                        {
                            //System.Windows.Forms.MessageBox.Show(i + " converting.... " + j);
                            string srcTxt = (string)currentCell.Value2;
                            string uniTxt = UniConversion.Converter.Convert(srcTxt, option);
                            currentCell.Value2 = uniTxt;
                            //currentCell.Font.Name = "Myanmar3";
                        }
                    }

                } // end of outer-for

                // set "Myanmar3"to default sript name
                usedRange.Font.Name = "Myanmar3";
            }
            // mf.Close();
        }
    }
}
