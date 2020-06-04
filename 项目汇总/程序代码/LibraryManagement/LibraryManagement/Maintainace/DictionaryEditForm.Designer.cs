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
            this.comboBox_Dictionary.Location = new System.Drawing.Point(609, 37);
            this.comboBox_Dictionary.Name = "comboBox_Dictionary";
            this.comboBox_Dictionary.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Dictionary.TabIndex = 0;
            // 
            // dataGV_DictionaryShow
            // 
            this.dataGV_DictionaryShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DictionaryShow.Location = new System.Drawing.Point(13, 37);
            this.dataGV_DictionaryShow.Name = "dataGV_DictionaryShow";
            this.dataGV_DictionaryShow.RowTemplate.Height = 23;
            this.dataGV_DictionaryShow.Size = new System.Drawing.Size(575, 358);
            this.dataGV_DictionaryShow.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(609, 90);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(130, 35);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "增加";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(609, 143);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 35);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(609, 194);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(130, 35);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "删除";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // DictionaryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGV_DictionaryShow);
            this.Controls.Add(this.comboBox_Dictionary);
            this.Name = "DictionaryEditForm";
            this.Text = "DictionaryEditForm";
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