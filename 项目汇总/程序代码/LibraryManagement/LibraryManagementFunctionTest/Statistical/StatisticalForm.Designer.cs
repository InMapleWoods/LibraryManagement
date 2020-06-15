namespace LibraryManagementFunctionTest.Statistical
{
    partial class StatisticalForm
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
            this.tablePrintMenuStrip = new System.Windows.Forms.MenuStrip();
            this.chooseTableToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.printTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGV_showStatisticalData = new System.Windows.Forms.DataGridView();
            this.tablePrintMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_showStatisticalData)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePrintMenuStrip
            // 
            this.tablePrintMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tablePrintMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseTableToolStripMenuItem,
            this.printTableToolStripMenuItem});
            this.tablePrintMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.tablePrintMenuStrip.Name = "tablePrintMenuStrip";
            this.tablePrintMenuStrip.Size = new System.Drawing.Size(1067, 32);
            this.tablePrintMenuStrip.TabIndex = 0;
            this.tablePrintMenuStrip.Text = "menuStrip1";
            // 
            // chooseTableToolStripMenuItem
            // 
            this.chooseTableToolStripMenuItem.Name = "chooseTableToolStripMenuItem";
            this.chooseTableToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.chooseTableToolStripMenuItem.Text = "报表选择";
            // 
            // printTableToolStripMenuItem
            // 
            this.printTableToolStripMenuItem.Name = "printTableToolStripMenuItem";
            this.printTableToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.printTableToolStripMenuItem.Text = "打印统计表";
            // 
            // dataGV_showStatisticalData
            // 
            this.dataGV_showStatisticalData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGV_showStatisticalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_showStatisticalData.Location = new System.Drawing.Point(17, 52);
            this.dataGV_showStatisticalData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGV_showStatisticalData.Name = "dataGV_showStatisticalData";
            this.dataGV_showStatisticalData.RowHeadersWidth = 51;
            this.dataGV_showStatisticalData.RowTemplate.Height = 23;
            this.dataGV_showStatisticalData.Size = new System.Drawing.Size(1033, 495);
            this.dataGV_showStatisticalData.TabIndex = 1;
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.dataGV_showStatisticalData);
            this.Controls.Add(this.tablePrintMenuStrip);
            this.MainMenuStrip = this.tablePrintMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StatisticalForm";
            this.Text = "统计报表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticalForm_FormClosing);
            this.tablePrintMenuStrip.ResumeLayout(false);
            this.tablePrintMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_showStatisticalData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip tablePrintMenuStrip;
        private System.Windows.Forms.ToolStripComboBox chooseTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTableToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGV_showStatisticalData;
    }
}