namespace ToDoApp_Ui
{
    partial class AddToDoForm
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
            this.namelabelAddToDoForm = new System.Windows.Forms.Label();
            this.desciptionLabelAddToDoForm = new System.Windows.Forms.Label();
            this.deadlineLabelAddToForm = new System.Windows.Forms.Label();
            this.nameTextBoxAddToDoForm = new System.Windows.Forms.TextBox();
            this.descriptionTextBoxAddToDoForm = new System.Windows.Forms.TextBox();
            this.dateTimePickerAddToForm = new System.Windows.Forms.DateTimePicker();
            this.asterix1 = new System.Windows.Forms.Label();
            this.asterix2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelabelAddToDoForm
            // 
            this.namelabelAddToDoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabelAddToDoForm.Location = new System.Drawing.Point(13, 13);
            this.namelabelAddToDoForm.Name = "namelabelAddToDoForm";
            this.namelabelAddToDoForm.Size = new System.Drawing.Size(50, 19);
            this.namelabelAddToDoForm.TabIndex = 0;
            this.namelabelAddToDoForm.Text = "Name: ";
            // 
            // desciptionLabelAddToDoForm
            // 
            this.desciptionLabelAddToDoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desciptionLabelAddToDoForm.Location = new System.Drawing.Point(13, 34);
            this.desciptionLabelAddToDoForm.Name = "desciptionLabelAddToDoForm";
            this.desciptionLabelAddToDoForm.Size = new System.Drawing.Size(73, 20);
            this.desciptionLabelAddToDoForm.TabIndex = 1;
            this.desciptionLabelAddToDoForm.Text = "Description";
            // 
            // deadlineLabelAddToForm
            // 
            this.deadlineLabelAddToForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineLabelAddToForm.Location = new System.Drawing.Point(13, 130);
            this.deadlineLabelAddToForm.Name = "deadlineLabelAddToForm";
            this.deadlineLabelAddToForm.Size = new System.Drawing.Size(73, 19);
            this.deadlineLabelAddToForm.TabIndex = 2;
            this.deadlineLabelAddToForm.Text = "DeadLine:";
            // 
            // nameTextBoxAddToDoForm
            // 
            this.nameTextBoxAddToDoForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBoxAddToDoForm.Location = new System.Drawing.Point(69, 10);
            this.nameTextBoxAddToDoForm.Name = "nameTextBoxAddToDoForm";
            this.nameTextBoxAddToDoForm.Size = new System.Drawing.Size(138, 21);
            this.nameTextBoxAddToDoForm.TabIndex = 3;
            // 
            // descriptionTextBoxAddToDoForm
            // 
            this.descriptionTextBoxAddToDoForm.Location = new System.Drawing.Point(16, 48);
            this.descriptionTextBoxAddToDoForm.Multiline = true;
            this.descriptionTextBoxAddToDoForm.Name = "descriptionTextBoxAddToDoForm";
            this.descriptionTextBoxAddToDoForm.Size = new System.Drawing.Size(191, 66);
            this.descriptionTextBoxAddToDoForm.TabIndex = 4;
            // 
            // dateTimePickerAddToForm
            // 
            this.dateTimePickerAddToForm.Location = new System.Drawing.Point(80, 124);
            this.dateTimePickerAddToForm.Name = "dateTimePickerAddToForm";
            this.dateTimePickerAddToForm.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerAddToForm.TabIndex = 5;
            // 
            // asterix1
            // 
            this.asterix1.AutoSize = true;
            this.asterix1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.asterix1.Location = new System.Drawing.Point(213, 15);
            this.asterix1.Name = "asterix1";
            this.asterix1.Size = new System.Drawing.Size(11, 13);
            this.asterix1.TabIndex = 6;
            this.asterix1.Text = "*";
            // 
            // asterix2
            // 
            this.asterix2.AutoSize = true;
            this.asterix2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.asterix2.Location = new System.Drawing.Point(213, 51);
            this.asterix2.Name = "asterix2";
            this.asterix2.Size = new System.Drawing.Size(11, 13);
            this.asterix2.TabIndex = 7;
            this.asterix2.Text = "*";
            // 
            // AddToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 149);
            this.Controls.Add(this.asterix2);
            this.Controls.Add(this.asterix1);
            this.Controls.Add(this.dateTimePickerAddToForm);
            this.Controls.Add(this.descriptionTextBoxAddToDoForm);
            this.Controls.Add(this.nameTextBoxAddToDoForm);
            this.Controls.Add(this.deadlineLabelAddToForm);
            this.Controls.Add(this.desciptionLabelAddToDoForm);
            this.Controls.Add(this.namelabelAddToDoForm);
            this.MaximizeBox = false;
            this.Name = "AddToDoForm";
            this.Text = "AddToDoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabelAddToDoForm;
        private System.Windows.Forms.Label desciptionLabelAddToDoForm;
        private System.Windows.Forms.Label deadlineLabelAddToForm;
        private System.Windows.Forms.TextBox nameTextBoxAddToDoForm;
        private System.Windows.Forms.TextBox descriptionTextBoxAddToDoForm;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddToForm;
        private System.Windows.Forms.Label asterix1;
        private System.Windows.Forms.Label asterix2;
        private System.Windows.Forms.Button addToMainToDo;
    }
}