namespace LibraryManagement.Circulation
{
    partial class BookDamageForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_stateChange = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label_State = new System.Windows.Forms.Label();
            this.comboBox_State = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button_stateChange
            // 
            this.button_stateChange.Location = new System.Drawing.Point(650, 145);
            this.button_stateChange.Name = "button_stateChange";
            this.button_stateChange.Size = new System.Drawing.Size(135, 80);
            this.button_stateChange.TabIndex = 1;
            this.button_stateChange.Text = "修改";
            this.button_stateChange.UseVisualStyleBackColor = true;
            this.button_stateChange.Click += new System.EventHandler(this.button_stateChange_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(187, 150);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(37, 15);
            this.idLabel.TabIndex = 25;
            this.idLabel.Text = "编号";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(267, 145);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(330, 25);
            this.idTextBox.TabIndex = 24;
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(187, 205);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(37, 15);
            this.label_State.TabIndex = 26;
            this.label_State.Text = "状态";
            // 
            // comboBox_State
            // 
            this.comboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_State.FormattingEnabled = true;
            this.comboBox_State.Items.AddRange(new object[] {
            "已修复",
            "待修复",
            "修复失败"});
            this.comboBox_State.Location = new System.Drawing.Point(267, 200);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.Size = new System.Drawing.Size(330, 23);
            this.comboBox_State.TabIndex = 27;
            // 
            // BookDamageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 608);
            this.Controls.Add(this.comboBox_State);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button_stateChange);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookDamageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书损坏处理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookDamageForm_FormClosing);
            this.Load += new System.EventHandler(this.BookDamageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_stateChange;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.ComboBox comboBox_State;
    }
}