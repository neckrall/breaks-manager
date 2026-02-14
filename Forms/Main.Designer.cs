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
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            copyrightPanel.SuspendLayout();
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
            splitContainer.Panel2.Controls.Add(copyrightPanel);
            splitContainer.Size = new Size(1129, 626);
            splitContainer.SplitterDistance = 897;
            splitContainer.TabIndex = 0;
            // 
            // dataGridView
            // 
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
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label copyrightLabel;
        private Panel copyrightPanel;
        private DataGridView dataGridView;
    }
}