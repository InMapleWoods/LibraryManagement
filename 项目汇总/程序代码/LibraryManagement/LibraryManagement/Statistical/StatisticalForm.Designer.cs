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
            this.dataGV_showStatisticalData = new System.Windows.Forms.DataGridView();
            this.comboBox_ChooseTable = new System.Windows.Forms.ComboBox();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_showStatisticalData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV_showStatisticalData
            // 
            this.dataGV_showStatisticalData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGV_showStatisticalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_showStatisticalData.Location = new System.Drawing.Point(13, 42);
            this.dataGV_showStatisticalData.Name = "dataGV_showStatisticalData";
            this.dataGV_showStatisticalData.RowHeadersWidth = 51;
            this.dataGV_showStatisticalData.RowTemplate.Height = 23;
            this.dataGV_showStatisticalData.Size = new System.Drawing.Size(775, 396);
            this.dataGV_showStatisticalData.TabIndex = 1;
            // 
            // comboBox_ChooseTable
            // 
            this.comboBox_ChooseTable.FormattingEnabled = true;
            this.comboBox_ChooseTable.Location = new System.Drawing.Point(13, 12);
            this.comboBox_ChooseTable.Name = "comboBox_ChooseTable";
            this.comboBox_ChooseTable.Size = new System.Drawing.Size(121, 20);
            this.comboBox_ChooseTable.TabIndex = 2;
            this.comboBox_ChooseTable.SelectedIndexChanged += new System.EventHandler(this.comboBox_ChooseTable_SelectedIndexChanged);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(151, 9);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "打印";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.comboBox_ChooseTable);
            this.Controls.Add(this.dataGV_showStatisticalData);
            this.Name = "StatisticalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统计报表";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticalForm_FormClosing);
            this.Load += new System.EventHandler(this.StatisticalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_showStatisticalData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGV_showStatisticalData;
        private System.Windows.Forms.ComboBox comboBox_ChooseTable;
        private System.Windows.Forms.Button btn_Print;
    }
}