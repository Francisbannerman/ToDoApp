using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp_Ui
{
    public partial class toDoAppDashboard : Form
    {
        AddToDoForm _addToDoForm = new AddToDoForm();
        public toDoAppDashboard()
        {
            InitializeComponent();
        }
        private void addToDoButton_Click(object sender, EventArgs e)
        {
            _addToDoForm.Show();
        }
        private void todoAppCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_addToDoForm != null)
            {
                string todo = _addToDoForm.NameTextBoxValue;
                toDoAppCheckListBox.Items.Add(todo);
            }
        }
    }
}
