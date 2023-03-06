namespace ToDoApp_Ui
{
    partial class toDoAppDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addToDoButton = new System.Windows.Forms.Button();
            this.toDoAppCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.editToDoButton = new System.Windows.Forms.Button();
            this.onHoldToDoButton = new System.Windows.Forms.Button();
            this.completeToDoButton = new System.Windows.Forms.Button();
            this.deleteToDoButton = new System.Windows.Forms.Button();
            this.nameTodoTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.setDeadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addToDoButton
            // 
            this.addToDoButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addToDoButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToDoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addToDoButton.Location = new System.Drawing.Point(24, 324);
            this.addToDoButton.Name = "addToDoButton";
            this.addToDoButton.Size = new System.Drawing.Size(228, 50);
            this.addToDoButton.TabIndex = 0;
            this.addToDoButton.Text = "ADD";
            this.addToDoButton.UseVisualStyleBackColor = true;
            this.addToDoButton.Click += new System.EventHandler(this.addToDoButton_Click_1);
            // 
            // toDoAppCheckListBox
            // 
            this.toDoAppCheckListBox.FormattingEnabled = true;
            this.toDoAppCheckListBox.Location = new System.Drawing.Point(24, 27);
            this.toDoAppCheckListBox.Name = "toDoAppCheckListBox";
            this.toDoAppCheckListBox.Size = new System.Drawing.Size(157, 220);
            this.toDoAppCheckListBox.TabIndex = 1;
            this.toDoAppCheckListBox.SelectedIndexChanged += new System.EventHandler(this.toDoAppCheckListBox_SelectedIndexChanged_1);
            // 
            // editToDoButton
            // 
            this.editToDoButton.Location = new System.Drawing.Point(187, 27);
            this.editToDoButton.Name = "editToDoButton";
            this.editToDoButton.Size = new System.Drawing.Size(65, 37);
            this.editToDoButton.TabIndex = 2;
            this.editToDoButton.Text = "Edit";
            this.editToDoButton.UseVisualStyleBackColor = true;
            this.editToDoButton.Click += new System.EventHandler(this.editToDoButton_Click);
            // 
            // onHoldToDoButton
            // 
            this.onHoldToDoButton.Location = new System.Drawing.Point(187, 113);
            this.onHoldToDoButton.Name = "onHoldToDoButton";
            this.onHoldToDoButton.Size = new System.Drawing.Size(65, 37);
            this.onHoldToDoButton.TabIndex = 4;
            this.onHoldToDoButton.Text = "On-Hold";
            this.onHoldToDoButton.UseVisualStyleBackColor = true;
            // 
            // completeToDoButton
            // 
            this.completeToDoButton.Location = new System.Drawing.Point(187, 70);
            this.completeToDoButton.Name = "completeToDoButton";
            this.completeToDoButton.Size = new System.Drawing.Size(65, 37);
            this.completeToDoButton.TabIndex = 5;
            this.completeToDoButton.Text = "Complete";
            this.completeToDoButton.UseVisualStyleBackColor = true;
            // 
            // deleteToDoButton
            // 
            this.deleteToDoButton.Location = new System.Drawing.Point(187, 208);
            this.deleteToDoButton.Name = "deleteToDoButton";
            this.deleteToDoButton.Size = new System.Drawing.Size(65, 37);
            this.deleteToDoButton.TabIndex = 6;
            this.deleteToDoButton.Text = "Delete";
            this.deleteToDoButton.UseVisualStyleBackColor = true;
            this.deleteToDoButton.Click += new System.EventHandler(this.deleteToDoButton_Click);
            // 
            // nameTodoTextBox
            // 
            this.nameTodoTextBox.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTodoTextBox.Location = new System.Drawing.Point(24, 253);
            this.nameTodoTextBox.Name = "nameTodoTextBox";
            this.nameTodoTextBox.Size = new System.Drawing.Size(157, 21);
            this.nameTodoTextBox.TabIndex = 7;
            this.nameTodoTextBox.Text = "name....";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(24, 280);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(228, 48);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.Text = "description...";
            // 
            // setDeadline
            // 
            this.setDeadline.Location = new System.Drawing.Point(187, 251);
            this.setDeadline.MinDate = new System.DateTime(2023, 3, 6, 0, 0, 0, 0);
            this.setDeadline.Name = "setDeadline";
            this.setDeadline.Size = new System.Drawing.Size(79, 23);
            this.setDeadline.TabIndex = 9;
            // 
            // toDoAppDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 375);
            this.Controls.Add(this.setDeadline);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTodoTextBox);
            this.Controls.Add(this.deleteToDoButton);
            this.Controls.Add(this.completeToDoButton);
            this.Controls.Add(this.onHoldToDoButton);
            this.Controls.Add(this.editToDoButton);
            this.Controls.Add(this.toDoAppCheckListBox);
            this.Controls.Add(this.addToDoButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "toDoAppDashboard";
            this.Text = "To Do App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToDoButton;
        private System.Windows.Forms.CheckedListBox toDoAppCheckListBox;
        private System.Windows.Forms.Button editToDoButton;
        private System.Windows.Forms.Button onHoldToDoButton;
        private System.Windows.Forms.Button completeToDoButton;
        private System.Windows.Forms.Button deleteToDoButton;
        private System.Windows.Forms.TextBox nameTodoTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker setDeadline;
    }
}

