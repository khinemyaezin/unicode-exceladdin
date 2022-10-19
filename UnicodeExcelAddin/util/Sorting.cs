using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace UnicodeExcelAddin
{
    class Sorting
    {
        
        private frmSortingOption myForm;

        public Sorting(frmSortingOption form)
        {
            
            this.myForm = form;
        }

        public bool check()
        {
            bool show = true;
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
                    //currentCell.Value2 = "got it";
                    if (currentCell != null)
                    {
                        //System.Windows.Forms.MessageBox.Show("converting....0");
                        if (((string)currentCell.Text) != "")
                        {
                            if (((string)currentCell.Text).Contains("၁") ||
                                ((string)currentCell.Text).Contains("၂") ||
                                ((string)currentCell.Text).Contains("၃") ||
                                ((string)currentCell.Text).Contains("၄") ||
                                ((string)currentCell.Text).Contains("၅") ||
                                ((string)currentCell.Text).Contains("၆") ||
                                ((string)currentCell.Text).Contains("၇") ||

                                ((string)currentCell.Text).Contains("၈") ||
                                ((string)currentCell.Text).Contains("၉") ||
                                ((string)currentCell.Text).Contains("၀")
                                )
                            {
                                show = false;
                            }

                        }
                    }
                }
            }
            return show;

        }

        public void ascending()
        {
            List<String> mySortList = new List<String>();
            Range currentCell;
            Worksheet activeWorkSheet = Globals.ThisAddIn.GetActiveWorkSheet();
            Range selected = (Range)activeWorkSheet.Application.Selection;
            Range used = (Range)activeWorkSheet.UsedRange;

       
            #region'test'
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
                       //currentCell.Value2 = "got it";
                       if (currentCell != null)
                       {
                           if (((string)currentCell.Text) != "")
                           {
                               mySortList.Add(currentCell.Value2.ToString());

                           }
                       }
                   }
               }

               mySortList.Sort(new MyUniStringComparer());


               int ListIndex = 0;
               for (int i = 1; i <= totalRows; i++)
               {
                   for (int j = 1; j <= totalColumns; j++)
                   {
                       currentCell = ((Range)selected.Cells[i, j]);

                       if (currentCell != null)
                       {

                           if (((string)currentCell.Text) != "")
                           {
                               currentCell.Value2 = mySortList[ListIndex];
                               ListIndex++;

                           }
                       }
                   }
               }

           this.myForm.Close();
           System.Windows.Forms.MessageBox.Show("Successfully Ascending Sort!");
           
            #endregion
        }

        public sealed class MyUniStringComparer : IComparer<string>
        {
            public int Compare(string a, string b)
            {
                return CollationClassLibrary.CollationCompare.CompareTwoString(a, b);

            }
        }

        public void descending()
        {
            List<String> mySortList = new List<String>();
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
            int totalColumns = selected.Columns.Count;
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
                    //currentCell.Value2 = "got it";
                    if (currentCell != null)
                    {
                        //System.Windows.Forms.MessageBox.Show("converting....0");
                        if (((string)currentCell.Text) != "")
                        {
                            //System.Windows.Forms.MessageBox.Show(i + " converting.... " + j);
                            mySortList.Add(currentCell.Value2.ToString());

                        }
                    }
                }
            }
            mySortList.Sort(new MyUniStringComparer());
            mySortList.Reverse();
            int ListIndex = 0;
            for (int i = 1; i <= totalRows; i++)
            {
                for (int j = 1; j <= totalColumns; j++)
                {
                    currentCell = ((Range)selected.Cells[i, j]);

                    if (currentCell != null)
                    {
                        //System.Windows.Forms.MessageBox.Show("converting....0");
                        if (((string)currentCell.Text) != "")
                        {
                            currentCell.Value2 = mySortList[ListIndex];
                            ListIndex++;

                        }
                    }
                }
            }
            this.myForm.Close();
            System.Windows.Forms.MessageBox.Show("Successfully Descending Sort!");
        }
    }
}
