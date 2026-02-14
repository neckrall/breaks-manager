namespace BreaksManager.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            splitContainer = new SplitContainer();
            dataGridView = new DataGridView();
            copyrightPanel = new Panel();
            copyrightLabel = new Label();
            employeesControl = new GroupBox();
            btnAddEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            copyrightPanel.SuspendLayout();
            employeesControl.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.BorderStyle = BorderStyle.Fixed3D;
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel2;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dataGridView);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(employeesControl);
            splitContainer.Panel2.Controls.Add(copyrightPanel);
            splitContainer.Size = new Size(1129, 626);
            splitContainer.SplitterDistance = 897;
            splitContainer.TabIndex = 0;
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(893, 622);
            dataGridView.TabIndex = 0;
            dataGridView.MultiSelect = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Black,
                ForeColor = Color.White,
            };
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.GridColor = Color.FromArgb(235, 235, 235);
            dataGridView.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;

            dataGridView.RowTemplate.Height = 26;
            // 
            // copyrightPanel
            // 
            copyrightPanel.BackColor = SystemColors.ControlLight;
            copyrightPanel.Controls.Add(copyrightLabel);
            copyrightPanel.Dock = DockStyle.Bottom;
            copyrightPanel.Location = new Point(0, 604);
            copyrightPanel.Name = "copyrightPanel";
            copyrightPanel.Size = new Size(224, 18);
            copyrightPanel.TabIndex = 0;
            // 
            // copyrightLabel
            // 
            copyrightLabel.AutoSize = true;
            copyrightLabel.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            copyrightLabel.ForeColor = SystemColors.WindowFrame;
            copyrightLabel.Location = new Point(3, 3);
            copyrightLabel.Name = "copyrightLabel";
            copyrightLabel.Size = new Size(203, 14);
            copyrightLabel.TabIndex = 0;
            copyrightLabel.Text = "© Данил Ларькин, 2026 | v1.0";
            // 
            // employeesControl
            // 
            employeesControl.Controls.Add(btnAddEmployee);
            employeesControl.Location = new Point(10, 10);
            employeesControl.Name = "employeesControl";
            employeesControl.Size = new Size(204, 56);
            employeesControl.TabIndex = 1;
            employeesControl.TabStop = false;
            employeesControl.Text = "Работа с сотрудниками";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(6, 22);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(192, 23);
            btnAddEmployee.TabIndex = 2;
            btnAddEmployee.Text = "Добавить сотрудника";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 626);
            Controls.Add(splitContainer);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(1145, 665);
            Name = "Main";
            Text = "Менеджер перерывов КЦ";
            WindowState = FormWindowState.Maximized;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            copyrightPanel.ResumeLayout(false);
            copyrightPanel.PerformLayout();
            employeesControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label copyrightLabel;
        private Panel copyrightPanel;
        private DataGridView dataGridView;
        private GroupBox employeesControl;
        private Button btnAddEmployee;
    }
}