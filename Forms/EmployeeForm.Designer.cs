namespace BreaksManager.Forms
{
    partial class EmployeeForm
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
            nameLabel = new Label();
            nameInput = new TextBox();
            inputClockIn = new DateTimePicker();
            inputClockOut = new DateTimePicker();
            labelBetweenClocks = new Label();
            panelBottom = new Panel();
            btnOK = new Button();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(34, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "ФИО";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(12, 27);
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Введите ФИО";
            nameInput.Size = new Size(200, 23);
            nameInput.TabIndex = 1;
            // 
            // inputClockIn
            // 
            inputClockIn.CustomFormat = "HH:mm";
            inputClockIn.Format = DateTimePickerFormat.Custom;
            inputClockIn.Location = new Point(12, 56);
            inputClockIn.Name = "inputClockIn";
            inputClockIn.ShowUpDown = true;
            inputClockIn.Size = new Size(90, 23);
            inputClockIn.TabIndex = 2;
            inputClockIn.Value = new DateTime(2026, 2, 14, 8, 0, 0, 0);
            // 
            // inputClockOut
            // 
            inputClockOut.CustomFormat = "HH:mm";
            inputClockOut.Format = DateTimePickerFormat.Custom;
            inputClockOut.Location = new Point(122, 56);
            inputClockOut.Name = "inputClockOut";
            inputClockOut.ShowUpDown = true;
            inputClockOut.Size = new Size(90, 23);
            inputClockOut.TabIndex = 3;
            inputClockOut.Value = new DateTime(2026, 2, 14, 20, 0, 0, 0);
            // 
            // labelBetweenClocks
            // 
            labelBetweenClocks.AutoSize = true;
            labelBetweenClocks.Location = new Point(105, 61);
            labelBetweenClocks.Name = "labelBetweenClocks";
            labelBetweenClocks.Size = new Size(13, 15);
            labelBetweenClocks.TabIndex = 4;
            labelBetweenClocks.Text = "–";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.ControlLight;
            panelBottom.Controls.Add(btnOK);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 92);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(224, 40);
            panelBottom.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(137, 9);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 132);
            Controls.Add(panelBottom);
            Controls.Add(labelBetweenClocks);
            Controls.Add(inputClockOut);
            Controls.Add(inputClockIn);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сотрудник";
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameInput;
        private DateTimePicker inputClockIn;
        private DateTimePicker inputClockOut;
        private Label labelBetweenClocks;
        private Panel panelBottom;
        private Button btnOK;
    }
}