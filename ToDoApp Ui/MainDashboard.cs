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
        List<string> Todos = new List<string>();

        public toDoAppDashboard()
        {
            InitializeComponent();
        }

        private void addToDoButton_Click_1(object sender, EventArgs e)
        {
            toDoAppCheckListBox.Items.Add(nameTodoTextBox.Text);
            nameTodoTextBox.Clear();
            descriptionTextBox.Clear();
        }

        private void toDoAppCheckListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void editToDoButton_Click(object sender, EventArgs e)
        {
            //string toedit = toDoAppCheckListBox.Items.ToString();
            //nameTodoTextBox.Text = toedit;
            //toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);

            //e.NewValue = e.CurrentValue;
            //string newText = toDoAppCheckListBox.Items[e.Index].ToString();
            //nameTodoTextBox.Text = newText;

            string toedit = toDoAppCheckListBox.Items[toDoAppCheckListBox.SelectedIndex].ToString();
            toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
            nameTodoTextBox.Text = toedit;
        }

        private void deleteToDoButton_Click(object sender, EventArgs e)
        {
            toDoAppCheckListBox.Items.Remove(toDoAppCheckListBox.SelectedItem);
        }
    }
}
