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
            this.delayedToDoButton = new System.Windows.Forms.Button();
            this.onGoingToDoButton = new System.Windows.Forms.Button();
            this.completeToDoButton = new System.Windows.Forms.Button();
            this.clearToDoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addToDoButton
            // 
            this.addToDoButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.addToDoButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToDoButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addToDoButton.Location = new System.Drawing.Point(24, 274);
            this.addToDoButton.Name = "addToDoButton";
            this.addToDoButton.Size = new System.Drawing.Size(157, 50);
            this.addToDoButton.TabIndex = 0;
            this.addToDoButton.Text = "ADD";
            this.addToDoButton.UseVisualStyleBackColor = true;
            // 
            // toDoAppCheckListBox
            // 
            this.toDoAppCheckListBox.FormattingEnabled = true;
            this.toDoAppCheckListBox.Location = new System.Drawing.Point(24, 27);
            this.toDoAppCheckListBox.Name = "toDoAppCheckListBox";
            this.toDoAppCheckListBox.Size = new System.Drawing.Size(157, 220);
            this.toDoAppCheckListBox.TabIndex = 1;
            // 
            // editToDoButton
            // 
            this.editToDoButton.Location = new System.Drawing.Point(187, 27);
            this.editToDoButton.Name = "editToDoButton";
            this.editToDoButton.Size = new System.Drawing.Size(65, 37);
            this.editToDoButton.TabIndex = 2;
            this.editToDoButton.Text = "Edit";
            this.editToDoButton.UseVisualStyleBackColor = true;
            // 
            // delayedToDoButton
            // 
            this.delayedToDoButton.Location = new System.Drawing.Point(187, 156);
            this.delayedToDoButton.Name = "delayedToDoButton";
            this.delayedToDoButton.Size = new System.Drawing.Size(65, 37);
            this.delayedToDoButton.TabIndex = 3;
            this.delayedToDoButton.Text = "Delayed";
            this.delayedToDoButton.UseVisualStyleBackColor = true;
            // 
            // onGoingToDoButton
            // 
            this.onGoingToDoButton.Location = new System.Drawing.Point(187, 113);
            this.onGoingToDoButton.Name = "onGoingToDoButton";
            this.onGoingToDoButton.Size = new System.Drawing.Size(65, 37);
            this.onGoingToDoButton.TabIndex = 4;
            this.onGoingToDoButton.Text = "On-Going";
            this.onGoingToDoButton.UseVisualStyleBackColor = true;
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
            // clearToDoButton
            // 
            this.clearToDoButton.Location = new System.Drawing.Point(187, 199);
            this.clearToDoButton.Name = "clearToDoButton";
            this.clearToDoButton.Size = new System.Drawing.Size(53, 37);
            this.clearToDoButton.TabIndex = 6;
            this.clearToDoButton.Text = "Clear";
            this.clearToDoButton.UseVisualStyleBackColor = true;
            // 
            // toDoAppDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 375);
            this.Controls.Add(this.clearToDoButton);
            this.Controls.Add(this.completeToDoButton);
            this.Controls.Add(this.onGoingToDoButton);
            this.Controls.Add(this.delayedToDoButton);
            this.Controls.Add(this.editToDoButton);
            this.Controls.Add(this.toDoAppCheckListBox);
            this.Controls.Add(this.addToDoButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "toDoAppDashboard";
            this.Text = "To Do App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addToDoButton;
        private System.Windows.Forms.CheckedListBox toDoAppCheckListBox;
        private System.Windows.Forms.Button editToDoButton;
        private System.Windows.Forms.Button delayedToDoButton;
        private System.Windows.Forms.Button onGoingToDoButton;
        private System.Windows.Forms.Button completeToDoButton;
        private System.Windows.Forms.Button clearToDoButton;
    }
}

