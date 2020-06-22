namespace LibraryManagement.Periodical
{
    partial class PeriodicalBindingForm
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
            this.dataGridView_Binding = new System.Windows.Forms.DataGridView();
            this.dataGridView_Periodical = new System.Windows.Forms.DataGridView();
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_bindingName = new System.Windows.Forms.Label();
            this.textBox_bindingName = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Binding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Periodical)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Binding
            // 
            this.dataGridView_Binding.AllowUserToAddRows = false;
            this.dataGridView_Binding.AllowUserToDeleteRows = false;
            this.dataGridView_Binding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Binding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Binding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Binding.Location = new System.Drawing.Point(0, 410);
            this.dataGridView_Binding.Name = "dataGridView_Binding";
            this.dataGridView_Binding.ReadOnly = true;
            this.dataGridView_Binding.RowHeadersVisible = false;
            this.dataGridView_Binding.RowHeadersWidth = 51;
            this.dataGridView_Binding.RowTemplate.Height = 27;
            this.dataGridView_Binding.Size = new System.Drawing.Size(1026, 237);
            this.dataGridView_Binding.TabIndex = 0;
            this.dataGridView_Binding.CurrentCellChanged += new System.EventHandler(this.dataGridView_Binding_CurrentCellChanged);
            this.dataGridView_Binding.SelectionChanged += new System.EventHandler(this.dataGridView_Binding_SelectionChanged);
            // 
            // dataGridView_Periodical
            // 
            this.dataGridView_Periodical.AllowUserToAddRows = false;
            this.dataGridView_Periodical.AllowUserToDeleteRows = false;
            this.dataGridView_Periodical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Periodical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Periodical.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Periodical.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Periodical.Name = "dataGridView_Periodical";
            this.dataGridView_Periodical.ReadOnly = true;
            this.dataGridView_Periodical.RowHeadersVisible = false;
            this.dataGridView_Periodical.RowHeadersWidth = 51;
            this.dataGridView_Periodical.RowTemplate.Height = 27;
            this.dataGridView_Periodical.Size = new System.Drawing.Size(1026, 232);
            this.dataGridView_Periodical.TabIndex = 1;
            this.dataGridView_Periodical.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Periodical_CellClick);
            this.dataGridView_Periodical.CurrentCellChanged += new System.EventHandler(this.dataGridView_Periodical_CurrentCellChanged);
            this.dataGridView_Periodical.SelectionChanged += new System.EventHandler(this.dataGridView_Periodical_SelectionChanged);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(112, 280);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(37, 15);
            this.label_Id.TabIndex = 2;
            this.label_Id.Text = "编号";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(155, 275);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(213, 25);
            this.textBox_Id.TabIndex = 3;
            // 
            // label_bindingName
            // 
            this.label_bindingName.AutoSize = true;
            this.label_bindingName.Location = new System.Drawing.Point(112, 330);
            this.label_bindingName.Name = "label_bindingName";
            this.label_bindingName.Size = new System.Drawing.Size(37, 15);
            this.label_bindingName.TabIndex = 4;
            this.label_bindingName.Text = "名称";
            // 
            // textBox_bindingName
            // 
            this.textBox_bindingName.Location = new System.Drawing.Point(155, 325);
            this.textBox_bindingName.Name = "textBox_bindingName";
            this.textBox_bindingName.Size = new System.Drawing.Size(213, 25);
            this.textBox_bindingName.TabIndex = 5;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(479, 271);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(80, 79);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "合订";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(593, 271);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(80, 79);
            this.button_Remove.TabIndex = 6;
            this.button_Remove.Text = "拆分";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // PeriodicalBindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 647);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_bindingName);
            this.Controls.Add(this.label_bindingName);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.dataGridView_Periodical);
            this.Controls.Add(this.dataGridView_Binding);
            this.Name = "PeriodicalBindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "期刊合订";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PeriodicalBindingForm_FormClosing);
            this.Load += new System.EventHandler(this.PeriodicalBindingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Binding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Periodical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Binding;
        private System.Windows.Forms.DataGridView dataGridView_Periodical;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_bindingName;
        private System.Windows.Forms.TextBox textBox_bindingName;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
    }
}