namespace LibraryManagement.Maintainace
{
    partial class DictionaryEditForm
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
            this.comboBox_Dictionary = new System.Windows.Forms.ComboBox();
            this.dataGV_DictionaryShow = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DictionaryShow)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Dictionary
            // 
            this.comboBox_Dictionary.FormattingEnabled = true;
            this.comboBox_Dictionary.Location = new System.Drawing.Point(812, 46);
            this.comboBox_Dictionary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Dictionary.Name = "comboBox_Dictionary";
            this.comboBox_Dictionary.Size = new System.Drawing.Size(160, 23);
            this.comboBox_Dictionary.TabIndex = 0;
            // 
            // dataGV_DictionaryShow
            // 
            this.dataGV_DictionaryShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DictionaryShow.Location = new System.Drawing.Point(17, 46);
            this.dataGV_DictionaryShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGV_DictionaryShow.Name = "dataGV_DictionaryShow";
            this.dataGV_DictionaryShow.RowHeadersWidth = 51;
            this.dataGV_DictionaryShow.RowTemplate.Height = 23;
            this.dataGV_DictionaryShow.Size = new System.Drawing.Size(767, 448);
            this.dataGV_DictionaryShow.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(812, 112);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(173, 44);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "增加";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(812, 179);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(173, 44);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(812, 242);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(173, 44);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "删除";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // DictionaryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGV_DictionaryShow);
            this.Controls.Add(this.comboBox_Dictionary);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DictionaryEditForm";
            this.Text = "DictionaryEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DictionaryEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DictionaryShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Dictionary;
        private System.Windows.Forms.DataGridView dataGV_DictionaryShow;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Change;
    }
}