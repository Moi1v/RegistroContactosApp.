namespace RegistroContactosApp_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TextBoxName = new TextBox();
            label2 = new Label();
            TextBoxPhone = new TextBox();
            label3 = new Label();
            TextBoxEmail = new TextBox();
            Add = new Button();
            ClearFields = new Button();
            listBoxContacts = new ListBox();
            Status = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(19, 42);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(220, 23);
            TextBoxName.TabIndex = 1;
            TextBoxName.TextChanged += TextBoxName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(24, 93);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 2;
            label2.Text = "Phone";
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.Location = new Point(19, 115);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(220, 23);
            TextBoxPhone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(19, 190);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(220, 23);
            TextBoxEmail.TabIndex = 5;
            // 
            // Add
            // 
            Add.Location = new Point(24, 264);
            Add.Name = "Add";
            Add.Size = new Size(127, 57);
            Add.TabIndex = 6;
            Add.Text = "Add Contact";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // ClearFields
            // 
            ClearFields.Location = new Point(157, 264);
            ClearFields.Name = "ClearFields";
            ClearFields.Size = new Size(127, 57);
            ClearFields.TabIndex = 7;
            ClearFields.Text = "Clear fields";
            ClearFields.UseVisualStyleBackColor = true;
            ClearFields.Click += ClearFields_Click;
            // 
            // listBoxContacts
            // 
            listBoxContacts.FormattingEnabled = true;
            listBoxContacts.ItemHeight = 15;
            listBoxContacts.Location = new Point(419, 42);
            listBoxContacts.Name = "listBoxContacts";
            listBoxContacts.Size = new Size(161, 184);
            listBoxContacts.TabIndex = 8;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 10F);
            Status.Location = new Point(419, 20);
            Status.Name = "Status";
            Status.Size = new Size(54, 19);
            Status.TabIndex = 9;
            Status.Text = "Status: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Status);
            Controls.Add(listBoxContacts);
            Controls.Add(ClearFields);
            Controls.Add(Add);
            Controls.Add(TextBoxEmail);
            Controls.Add(label3);
            Controls.Add(TextBoxPhone);
            Controls.Add(label2);
            Controls.Add(TextBoxName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextBoxName;
        private Label label2;
        private TextBox TextBoxPhone;
        private Label label3;
        private TextBox TextBoxEmail;
        private Button Add;
        private Button ClearFields;
        private ListBox listBoxContacts;
        private Label Status;
    }
}
