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
    public partial class AddToDoForm : Form
    {
        private toDoAppDashboard mainDashboard = new toDoAppDashboard();
        public AddToDoForm()
        {
            InitializeComponent();
        }
        public string NameTextBoxValue
        {
            get { return nameTextBoxAddToDoForm.Text; }
        }
        public string DescriptionTextBoxValue
        {
            get { return descriptionTextBoxAddToDoForm.Text; }
        }
        public DateTime DeadlinePicked
        {
            get { return dateTimePickerAddToForm.Value; }
        }
        private void addToMainToDo_Click(object sender, EventArgs e)
        {
            AddToDoForm addToDoForm = new AddToDoForm();
            this.nameTextBoxAddToDoForm.Clear();
            this.descriptionTextBoxAddToDoForm.Clear();
            addToDoForm.Close();
        }
    }
}
