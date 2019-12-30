using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace school_management_system
{
    class export
    {
        /// <summary>
        /// expot data from datagridview to excel
        /// </summary>
        /// <param name="dgv">name of datagridview</param>
        /// <param name="filename">excel seve file name</param>
        public void excel(DataGridView dgv, string filename)
        {
            if (dgv.Rows.Count > 0)
            {

                try
                {
                    // creating Excel Application  
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                    // creating new WorkBook within Excel application  
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                    // creating new Excelsheet in workbook  
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                    // see the excel sheet behind the program  
                    app.Visible = true;

                    // get the reference of first sheet. By default its name is Sheet1.  
                    // store its reference to worksheet  
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;

                    // changing the name of active sheet  
                    worksheet.Name = "School Management System";

                    // storing header part in Excel  
                    for (int i = 1; i < dgv.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    }

                    // storing Each row and column value to excel sheet  
                    for (int i = 0; i < dgv.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    // save the application  
                    //                workbook.SaveAs("D:\\excel\\" + filename + ".xls", Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                    //Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                    //Excel.XlSaveConflictResolution.xlUserResolution, true,
                    //Missing.Value, Missing.Value, Missing.Value);
                    // workbook.SaveAs("C:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    // Exit from the application  
                    // app.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
