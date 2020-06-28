namespace LibraryManagement.Interview
{
    partial class AcceptanceListForm
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
            this.PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.AcceptanceDataGridView = new System.Windows.Forms.DataGridView();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.AcceptorLabel = new System.Windows.Forms.Label();
            this.AcceptorTextBox = new System.Windows.Forms.TextBox();
            this.label_orderId = new System.Windows.Forms.Label();
            this.comboBox_State = new System.Windows.Forms.ComboBox();
            this.label_State = new System.Windows.Forms.Label();
            this.textBox_orderId = new System.Windows.Forms.TextBox();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseDataGridView
            // 
            this.PurchaseDataGridView.AllowUserToAddRows = false;
            this.PurchaseDataGridView.AllowUserToDeleteRows = false;
            this.PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurchaseDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PurchaseDataGridView.Name = "PurchaseDataGridView";
            this.PurchaseDataGridView.ReadOnly = true;
            this.PurchaseDataGridView.RowHeadersVisible = false;
            this.PurchaseDataGridView.RowHeadersWidth = 51;
            this.PurchaseDataGridView.RowTemplate.Height = 27;
            this.PurchaseDataGridView.Size = new System.Drawing.Size(872, 185);
            this.PurchaseDataGridView.TabIndex = 20;
            this.PurchaseDataGridView.CurrentCellChanged += new System.EventHandler(this.PurchaseDataGridView_CurrentCellChanged);
            this.PurchaseDataGridView.SelectionChanged += new System.EventHandler(this.PurchaseDataGridView_SelectionChanged);
            // 
            // AcceptanceDataGridView
            // 
            this.AcceptanceDataGridView.AllowUserToAddRows = false;
            this.AcceptanceDataGridView.AllowUserToDeleteRows = false;
            this.AcceptanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AcceptanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcceptanceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AcceptanceDataGridView.Location = new System.Drawing.Point(0, 518);
            this.AcceptanceDataGridView.Name = "AcceptanceDataGridView";
            this.AcceptanceDataGridView.ReadOnly = true;
            this.AcceptanceDataGridView.RowHeadersVisible = false;
            this.AcceptanceDataGridView.RowHeadersWidth = 51;
            this.AcceptanceDataGridView.RowTemplate.Height = 27;
            this.AcceptanceDataGridView.Size = new System.Drawing.Size(872, 185);
            this.AcceptanceDataGridView.TabIndex = 21;
            this.AcceptanceDataGridView.CurrentCellChanged += new System.EventHandler(this.AcceptanceDataGridView_CurrentCellChanged);
            this.AcceptanceDataGridView.SelectionChanged += new System.EventHandler(this.AcceptanceDataGridView_SelectionChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(99, 237);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(52, 15);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "清单号";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(172, 234);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(149, 25);
            this.IdTextBox.TabIndex = 23;
            // 
            // AcceptorLabel
            // 
            this.AcceptorLabel.AutoSize = true;
            this.AcceptorLabel.Location = new System.Drawing.Point(464, 237);
            this.AcceptorLabel.Name = "AcceptorLabel";
            this.AcceptorLabel.Size = new System.Drawing.Size(52, 15);
            this.AcceptorLabel.TabIndex = 30;
            this.AcceptorLabel.Text = "验收人";
            // 
            // AcceptorTextBox
            // 
            this.AcceptorTextBox.Location = new System.Drawing.Point(537, 234);
            this.AcceptorTextBox.Name = "AcceptorTextBox";
            this.AcceptorTextBox.Size = new System.Drawing.Size(189, 25);
            this.AcceptorTextBox.TabIndex = 31;
            // 
            // label_orderId
            // 
            this.label_orderId.AutoSize = true;
            this.label_orderId.Location = new System.Drawing.Point(99, 281);
            this.label_orderId.Name = "label_orderId";
            this.label_orderId.Size = new System.Drawing.Size(52, 15);
            this.label_orderId.TabIndex = 35;
            this.label_orderId.Text = "订单号";
            // 
            // comboBox_State
            // 
            this.comboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_State.FormattingEnabled = true;
            this.comboBox_State.Items.AddRange(new object[] {
            "未处理",
            "已编目"});
            this.comboBox_State.Location = new System.Drawing.Point(537, 278);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.Size = new System.Drawing.Size(189, 23);
            this.comboBox_State.TabIndex = 37;
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(464, 281);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(37, 15);
            this.label_State.TabIndex = 36;
            this.label_State.Text = "状态";
            // 
            // textBox_orderId
            // 
            this.textBox_orderId.Location = new System.Drawing.Point(172, 278);
            this.textBox_orderId.Name = "textBox_orderId";
            this.textBox_orderId.ReadOnly = true;
            this.textBox_orderId.Size = new System.Drawing.Size(149, 25);
            this.textBox_orderId.TabIndex = 38;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 428);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(872, 90);
            this.scriptUserControl1.TabIndex = 34;
            // 
            // AcceptanceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 703);
            this.Controls.Add(this.textBox_orderId);
            this.Controls.Add(this.comboBox_State);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.label_orderId);
            this.Controls.Add(this.scriptUserControl1);
            this.Controls.Add(this.AcceptorTextBox);
            this.Controls.Add(this.AcceptorLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AcceptanceDataGridView);
            this.Controls.Add(this.PurchaseDataGridView);
            this.MaximizeBox = false;
            this.Name = "AcceptanceListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "验收清单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AcceptanceListForm_FormClosing);
            this.Load += new System.EventHandler(this.AcceptanceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchaseDataGridView;
        private System.Windows.Forms.DataGridView AcceptanceDataGridView;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label AcceptorLabel;
        private System.Windows.Forms.TextBox AcceptorTextBox;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.Label label_orderId;
        private System.Windows.Forms.ComboBox comboBox_State;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.TextBox textBox_orderId;
    }
}