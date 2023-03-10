using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ToDoApp_Ui
{
    public partial class toDoAppDashboard : Form
    {
        private int currentRow = 1;
        public toDoAppDashboard()
        {
            InitializeComponent();
        }

        private void addToDoButton_Click_1(object sender, EventArgs e)
        {
            string nameToDo = nameTodoTextBox.Text;
            string descriptionToDo = descriptionTextBox.Text;

            using (var workbook = new XLWorkbook(@"C:\ToDOApp\mydata.xlsx"))
            {
                var worksheet = workbook.Worksheet(1);

                int lastUsedRow = worksheet.LastRowUsed().RowNumber();

                worksheet.Cell(lastUsedRow + 1, 1).Value = nameToDo;
                worksheet.Cell(lastUsedRow + 1, 2).Value = descriptionToDo;

                workbook.Save();
            }

            toDoAppCheckListBox.Items.Add(nameTodoTextBox.Text);
            nameTodoTextBox.Clear();
            descriptionTextBox.Clear();
        }

        private void toDoAppCheckListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void editToDoButton_Click(object sender, EventArgs e)
        {
            string toedit = toDoAppCheckListBox.Items[toDoAppCheckListBox.SelectedIndex].ToString();
            toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
            nameTodoTextBox.Text = toedit;
        }

        private void deleteToDoButton_Click(object sender, EventArgs e)
        {
            toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
        }

        private void completeToDoButton_Click(object sender, EventArgs e)
        {
            toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
        }

        private void openToDoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(descriptionTextBox.Text);
        }

        public string toDoName()
        {
            return nameTodoTextBox.Text;
        }
        public string Description()
        {
            return descriptionTextBox.Text;
        }
        public string Deadline()
        {
            return setDeadline.ToString();
        }
    }
}
