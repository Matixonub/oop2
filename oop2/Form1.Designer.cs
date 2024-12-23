namespace oop2
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
            SaveButton = new Button();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            DateTextBox = new TextBox();
            GetPersonAge = new Button();
            GetDaysTillBirthdayButton = new Button();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(304, 154);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save Data";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(108, 103);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(100, 23);
            FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(290, 103);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(100, 23);
            LastNameTextBox.TabIndex = 2;
            // 
            // DateTextBox
            // 
            DateTextBox.Location = new Point(455, 103);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(100, 23);
            DateTextBox.TabIndex = 3;
            // 
            // GetPersonAge
            // 
            GetPersonAge.Location = new Point(108, 294);
            GetPersonAge.Name = "GetPersonAge";
            GetPersonAge.Size = new Size(111, 40);
            GetPersonAge.TabIndex = 4;
            GetPersonAge.Text = "Get Persons Age";
            GetPersonAge.UseVisualStyleBackColor = true;
            GetPersonAge.Click += GetPerson_Click;
            // 
            // GetDaysTillBirthdayButton
            // 
            GetDaysTillBirthdayButton.Location = new Point(290, 294);
            GetDaysTillBirthdayButton.Name = "GetDaysTillBirthdayButton";
            GetDaysTillBirthdayButton.Size = new Size(111, 40);
            GetDaysTillBirthdayButton.TabIndex = 5;
            GetDaysTillBirthdayButton.Text = "Days till birthday";
            GetDaysTillBirthdayButton.UseVisualStyleBackColor = true;
            GetDaysTillBirthdayButton.Click += GetDaysTillBirthdayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GetDaysTillBirthdayButton);
            Controls.Add(GetPersonAge);
            Controls.Add(DateTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(SaveButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox DateTextBox;
        private Button GetPersonAge;
        private Button GetDaysTillBirthdayButton;
    }
}
