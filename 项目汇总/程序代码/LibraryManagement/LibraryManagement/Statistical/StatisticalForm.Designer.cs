namespace LibraryManagement.Statistical
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.报表选择ToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.打印统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGV_showStatisticalData = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_showStatisticalData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.报表选择ToolStripMenuItem,
            this.打印统计表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 报表选择ToolStripMenuItem
            // 
            this.报表选择ToolStripMenuItem.Name = "报表选择ToolStripMenuItem";
            this.报表选择ToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.报表选择ToolStripMenuItem.Text = "报表选择";
            // 
            // 打印统计表ToolStripMenuItem
            // 
            this.打印统计表ToolStripMenuItem.Name = "打印统计表ToolStripMenuItem";
            this.打印统计表ToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.打印统计表ToolStripMenuItem.Text = "打印统计表";
            // 
            // dataGV_showStatisticalData
            // 
            this.dataGV_showStatisticalData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGV_showStatisticalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_showStatisticalData.Location = new System.Drawing.Point(13, 42);
            this.dataGV_showStatisticalData.Name = "dataGV_showStatisticalData";
            this.dataGV_showStatisticalData.RowTemplate.Height = 23;
            this.dataGV_showStatisticalData.Size = new System.Drawing.Size(775, 396);
            this.dataGV_showStatisticalData.TabIndex = 1;
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGV_showStatisticalData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StatisticalForm";
            this.Text = "统计报表";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_showStatisticalData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox 报表选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印统计表ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGV_showStatisticalData;
    }
}