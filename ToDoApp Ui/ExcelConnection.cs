using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;


namespace ToDoApp_Ui
{
    public class Connection
    {
        public void ExcelConnection()
        {
            var wb = new XLWorkbook();

            // Get the first worksheet
            var worksheet = wb.Worksheets.Add("Sheet1");

            // Add some data to the worksheet
            worksheet.Cell("A1").Value = "idNumber";
            worksheet.Cell("B1").Value = "currentToDos";
            worksheet.Cell("C1").Value = "Description";
            worksheet.Cell("D1").Value = "Deadline";
            worksheet.Cell("E1").Value = "completedToDos";
            worksheet.Cell("F1").Value = "deletedToDos";

            // Save the workbook to a file
            wb.SaveAs(@"C:\ToDOApp\mydata.xlsx");
        }
    }
}
