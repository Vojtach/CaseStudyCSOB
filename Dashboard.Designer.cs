
namespace CaseStudyCSOB
{
    partial class Dashboard
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
            this.CreatePersonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeletePersonButton = new System.Windows.Forms.Button();
            this.PeopleListbox = new System.Windows.Forms.ListBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearTextFieldsButton = new System.Windows.Forms.Button();
            this.CheckEnableResetButton = new System.Windows.Forms.CheckBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.EmployeeIdInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreatePersonButton
            // 
            this.CreatePersonButton.Location = new System.Drawing.Point(947, 274);
            this.CreatePersonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreatePersonButton.Name = "CreatePersonButton";
            this.CreatePersonButton.Size = new System.Drawing.Size(129, 32);
            this.CreatePersonButton.TabIndex = 0;
            this.CreatePersonButton.TabStop = false;
            this.CreatePersonButton.Text = "Create Person";
            this.CreatePersonButton.UseVisualStyleBackColor = true;
            this.CreatePersonButton.Click += new System.EventHandler(this.CreatePersonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(774, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "ČSOB Case Study";
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(675, 201);
            this.EmployeeIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeeIdTextBox.MaxLength = 6;
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(184, 31);
            this.EmployeeIdTextBox.TabIndex = 10;
            this.EmployeeIdTextBox.TextChanged += new System.EventHandler(this.EmployeeIdTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(675, 123);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(184, 31);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(892, 123);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(184, 31);
            this.SurnameTextBox.TabIndex = 9;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Location = new System.Drawing.Point(892, 201);
            this.DepartmentTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(184, 31);
            this.DepartmentTextBox.TabIndex = 11;
            this.DepartmentTextBox.TextChanged += new System.EventHandler(this.DepartmentTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(946, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "EmployeeID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(934, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Department";
            // 
            // DeletePersonButton
            // 
            this.DeletePersonButton.Location = new System.Drawing.Point(439, 450);
            this.DeletePersonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeletePersonButton.Name = "DeletePersonButton";
            this.DeletePersonButton.Size = new System.Drawing.Size(129, 32);
            this.DeletePersonButton.TabIndex = 16;
            this.DeletePersonButton.TabStop = false;
            this.DeletePersonButton.Text = "Delete Person";
            this.DeletePersonButton.UseVisualStyleBackColor = true;
            this.DeletePersonButton.Click += new System.EventHandler(this.DeletePersonButton_Click);
            // 
            // PeopleListbox
            // 
            this.PeopleListbox.FormattingEnabled = true;
            this.PeopleListbox.ItemHeight = 23;
            this.PeopleListbox.Location = new System.Drawing.Point(12, 12);
            this.PeopleListbox.Name = "PeopleListbox";
            this.PeopleListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.PeopleListbox.Size = new System.Drawing.Size(556, 418);
            this.PeopleListbox.TabIndex = 17;
            this.PeopleListbox.TabStop = false;
            this.PeopleListbox.SelectedIndexChanged += new System.EventHandler(this.PeopleListbox_SelectedIndexChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(886, 443);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(129, 39);
            this.ResetButton.TabIndex = 18;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(811, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Reset My Database";
            // 
            // ClearTextFieldsButton
            // 
            this.ClearTextFieldsButton.Location = new System.Drawing.Point(865, 274);
            this.ClearTextFieldsButton.Name = "ClearTextFieldsButton";
            this.ClearTextFieldsButton.Size = new System.Drawing.Size(75, 32);
            this.ClearTextFieldsButton.TabIndex = 21;
            this.ClearTextFieldsButton.TabStop = false;
            this.ClearTextFieldsButton.Text = "Clear";
            this.ClearTextFieldsButton.UseVisualStyleBackColor = true;
            this.ClearTextFieldsButton.Click += new System.EventHandler(this.ClearTextFieldsButton_Click);
            // 
            // CheckEnableResetButton
            // 
            this.CheckEnableResetButton.AutoSize = true;
            this.CheckEnableResetButton.Location = new System.Drawing.Point(753, 450);
            this.CheckEnableResetButton.Name = "CheckEnableResetButton";
            this.CheckEnableResetButton.Size = new System.Drawing.Size(126, 29);
            this.CheckEnableResetButton.TabIndex = 22;
            this.CheckEnableResetButton.TabStop = false;
            this.CheckEnableResetButton.Text = "Enable reset";
            this.CheckEnableResetButton.UseVisualStyleBackColor = true;
            this.CheckEnableResetButton.CheckedChanged += new System.EventHandler(this.CheckEnableResetButton_CheckedChanged);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(675, 61);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 25);
            this.WarningLabel.TabIndex = 23;
            // 
            // EmployeeIdInfoLabel
            // 
            this.EmployeeIdInfoLabel.AutoSize = true;
            this.EmployeeIdInfoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeIdInfoLabel.Location = new System.Drawing.Point(655, 234);
            this.EmployeeIdInfoLabel.Name = "EmployeeIdInfoLabel";
            this.EmployeeIdInfoLabel.Size = new System.Drawing.Size(443, 15);
            this.EmployeeIdInfoLabel.TabIndex = 24;
            this.EmployeeIdInfoLabel.Text = "Notice: Our company uses 6 character IDs for every employee.  Example : \"AB3456\"";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 536);
            this.Controls.Add(this.EmployeeIdInfoLabel);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CheckEnableResetButton);
            this.Controls.Add(this.ClearTextFieldsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.PeopleListbox);
            this.Controls.Add(this.DeletePersonButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreatePersonButton);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "CSOBCaseStudy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePersonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeletePersonButton;
        private System.Windows.Forms.ListBox PeopleListbox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearTextFieldsButton;
        private System.Windows.Forms.CheckBox CheckEnableResetButton;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label EmployeeIdInfoLabel;
    }
}

