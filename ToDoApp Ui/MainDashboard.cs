using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ToDoApp_Ui
{
    public partial class toDoAppDashboard : Form
    {
        private int currentRow = 1;
        string filePath = "C:\\ToDOApp\\mydata.xlsx";

        public toDoAppDashboard()
        {
            InitializeComponent();
            LoadItemsFromExcel();
            SaveAll();
        }

        private void addToDoButton_Click_1(object sender, EventArgs e)
        {
            string nameToDo = nameTodoTextBox.Text;
            string descriptionToDo = descriptionTextBox.Text;
            DateTime Deadline = setDeadline.Value;

            using (var workbook = new XLWorkbook(@"C:\ToDOApp\mydata.xlsx"))
            {
                var worksheet = workbook.Worksheet(1);

                int lastUsedRow = worksheet.LastRowUsed().RowNumber();
                
                worksheet.Cell(lastUsedRow + 1, 1).Value = DateTime.Now.ToString();
                worksheet.Cell(lastUsedRow + 1, 2).Value = nameToDo;
                worksheet.Cell(lastUsedRow + 1, 3).Value = descriptionToDo;
                worksheet.Cell(lastUsedRow + 1, 4).Value = Deadline;

                workbook.Save();
            }

            toDoAppCheckListBox.Items.Add(nameTodoTextBox.Text);
            nameTodoTextBox.Clear();
            descriptionTextBox.Clear();
        }

        private void LoadItemsFromExcel()
        {
            Connection connection = new Connection();

            //string filePath = "C:\\ToDOApp\\mydata.xlsx";

            XLWorkbook workbook;

            if (File.Exists(filePath))
            {
                workbook = new XLWorkbook(filePath);
            }
            else
            {
                workbook = new XLWorkbook();

                // Get the first worksheet
                var worksht = workbook.Worksheets.Add("Sheet1");

                // Add some data to the worksheet
                worksht.Cell("A1").Value = "dateCreated";
                worksht.Cell("B1").Value = "currentToDos";
                worksht.Cell("C1").Value = "description";
                worksht.Cell("D1").Value = "deadline";
                worksht.Cell("E1").Value = "completedToDos";
                worksht.Cell("F1").Value = "deletedToDos";
                worksht.Cell("G1").Value = "dateDeleted/Completed";

                // Save the workbook to a file
                workbook.SaveAs(@"C:\ToDOApp\mydata.xlsx");
            }
            var worksheet = workbook.Worksheet("Sheet1");
            var itemCells = worksheet.Column(2).CellsUsed().Skip(1);

            foreach (var cell in itemCells)
            {
                if (cell.Value.ToString() != "completed" && cell.Value.ToString() != "deleted")
                {
                    toDoAppCheckListBox.Items.Add(cell.Value.ToString());
                }
                //toDoAppCheckListBox.Items.Add(cell.Value.ToString());
            }
            workbook.SaveAs(filePath);
        }

        private void toDoAppCheckListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void editToDoButton_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("Sheet1");

                string selectedItem = toDoAppCheckListBox.SelectedItem.ToString();

                var rowToUpdate = worksheet.RowsUsed().FirstOrDefault(r => r.Cell(2).Value.ToString() == selectedItem);
                string selectedItemsName = rowToUpdate.Cell(2).Value.ToString();
                string selectedItemsDescription = rowToUpdate.Cell(3).Value.ToString();

                    rowToUpdate.Delete();                

                toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
                nameTodoTextBox.Text = selectedItemsName;
                descriptionTextBox.Text = selectedItemsDescription;

                workbook.Save();
            }
        }

        private void deleteToDoButton_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();
            foreach (string item in toDoAppCheckListBox.CheckedItems)
            {
                selectedItems.Add(item);
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("Sheet1");

                foreach (var row in worksheet.RowsUsed())
                {
                    var cellValue = row.Cell(2).GetValue<string>();
                    if (selectedItems.Contains(cellValue))
                    {
                        row.Cell(6).Value = cellValue;
                        row.Cell(2).Clear(XLClearOptions.All);
                        row.Cell(2).Value = "deleted";
                        row.Cell(2).Style.Fill.BackgroundColor = XLColor.Red;
                        row.Cell(7).Value = DateTime.Now;
                    }
                }
                workbook.Save();
            }

            toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
        }

        private void completeToDoButton_Click(object sender, EventArgs e)
        {
            List<string> selectedItems = new List<string>();
            foreach (string item in toDoAppCheckListBox.CheckedItems)
            {
                selectedItems.Add(item);
            }
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("Sheet1");

                foreach (var row in worksheet.RowsUsed())
                {
                    var cellValue = row.Cell(2).GetValue<string>();
                    if (selectedItems.Contains(cellValue))
                    {
                        row.Cell(5).Value = cellValue;
                        row.Cell(2).Clear(XLClearOptions.All);
                        row.Cell(2).Value = "completed";
                        row.Cell(2).Style.Fill.BackgroundColor = XLColor.Green;
                        row.Cell(7).Value = DateTime.Now;
                    }
                }
                workbook.Save();
            }

            toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
        }

        private void openToDoButton_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook(filePath);

            var worksheet = workbook.Worksheet("Sheet1");

            string selectedItem = toDoAppCheckListBox.SelectedItem.ToString();

            var row = worksheet.RowsUsed().FirstOrDefault(r => r.Cell(2).Value.ToString() == selectedItem);

            if (row != null)
            {
                string selectedItemsDescription = row.Cell(3).Value.ToString();

                MessageBox.Show(selectedItemsDescription);
            }
        }

        private void SaveAll()
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet("Sheet1");
                workbook.CalculateMode = XLCalculateMode.Auto;
                workbook.Save();
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string sourceFilePath = filePath;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "*.xlsx|";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string destinationFilePath = save.FileName;

                File.Copy(sourceFilePath, destinationFilePath);
                MessageBox.Show("To-Do Records Downloaded Successfully");
            }
            else
            {
                MessageBox.Show("There was a problem with your download. Try again and if problem persists, see engineer");
            }
        }
    }
}
