using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ms = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;

namespace CoffeeShop
{
    class ThaoTacExcel
    {
        public static void Export2Excel(DataGridView dgr)
        {
            System.Globalization.CultureInfo old = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            ms.Application exa = new ms.Application();
            ms.Workbook wb = exa.Application.Workbooks.Add(ms.XlSheetType.xlWorksheet);
            ms.Worksheet ws = (ms.Worksheet)exa.ActiveSheet;
            exa.Visible = true;
            for (int i = 0; i < dgr.Columns.Count; ++i)
            {
                ws.Cells[1, i + 1] = dgr.Columns[i].HeaderText;
            }
            ms.Range ran = ws.get_Range("a1", "z1");
            ran.Font.Bold = true;
            ran.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Navy);

            for (int i = 0; i < dgr.Rows.Count; ++i)
            {
                for (int j = 0; j < dgr.Columns.Count; ++j)
                {
                    ws.Cells[i + 2, j + 1] = dgr[j, i].Value;
                }
            }
            ws.Columns.AutoFit();
            System.Threading.Thread.CurrentThread.CurrentCulture = old;
        }
    }
}
