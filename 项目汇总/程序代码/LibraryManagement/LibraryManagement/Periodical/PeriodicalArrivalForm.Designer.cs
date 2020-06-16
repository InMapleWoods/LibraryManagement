namespace LibraryManagement.Periodical
{
    partial class PeriodicalArrivalForm
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
            this.arrivalDataGridView = new System.Windows.Forms.DataGridView();
            this.arrivalButton = new System.Windows.Forms.Button();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.orderIdLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.circulationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // arrivalDataGridView
            // 
            this.arrivalDataGridView.AllowUserToAddRows = false;
            this.arrivalDataGridView.AllowUserToDeleteRows = false;
            this.arrivalDataGridView.AllowUserToResizeRows = false;
            this.arrivalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrivalDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.arrivalDataGridView.Location = new System.Drawing.Point(0, 438);
            this.arrivalDataGridView.Name = "arrivalDataGridView";
            this.arrivalDataGridView.ReadOnly = true;
            this.arrivalDataGridView.RowHeadersVisible = false;
            this.arrivalDataGridView.RowHeadersWidth = 51;
            this.arrivalDataGridView.RowTemplate.Height = 27;
            this.arrivalDataGridView.Size = new System.Drawing.Size(982, 250);
            this.arrivalDataGridView.TabIndex = 0;
            this.arrivalDataGridView.CurrentCellChanged += new System.EventHandler(this.arrivalDataGridView_CurrentCellChanged);
            this.arrivalDataGridView.SelectionChanged += new System.EventHandler(this.arrivalDataGridView_SelectionChanged);
            // 
            // arrivalButton
            // 
            this.arrivalButton.Enabled = false;
            this.arrivalButton.Location = new System.Drawing.Point(603, 284);
            this.arrivalButton.Name = "arrivalButton";
            this.arrivalButton.Size = new System.Drawing.Size(76, 75);
            this.arrivalButton.TabIndex = 1;
            this.arrivalButton.Text = "登到";
            this.arrivalButton.UseVisualStyleBackColor = true;
            this.arrivalButton.Click += new System.EventHandler(this.arrivalButton_Click);
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(267, 310);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.ReadOnly = true;
            this.orderIdTextBox.Size = new System.Drawing.Size(229, 25);
            this.orderIdTextBox.TabIndex = 2;
            // 
            // orderIdLabel
            // 
            this.orderIdLabel.AutoSize = true;
            this.orderIdLabel.Location = new System.Drawing.Point(195, 315);
            this.orderIdLabel.Name = "orderIdLabel";
            this.orderIdLabel.Size = new System.Drawing.Size(67, 15);
            this.orderIdLabel.TabIndex = 3;
            this.orderIdLabel.Text = "订单编号";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(195, 380);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(37, 15);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "状态";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "完好",
            "退回",
            "待退"});
            this.stateComboBox.Location = new System.Drawing.Point(267, 375);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(229, 23);
            this.stateComboBox.TabIndex = 4;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AllowUserToResizeRows = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.RowHeadersVisible = false;
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(982, 228);
            this.orderDataGridView.TabIndex = 5;
            this.orderDataGridView.CurrentCellChanged += new System.EventHandler(this.orderDataGridView_CurrentCellChanged);
            this.orderDataGridView.SelectionChanged += new System.EventHandler(this.orderDataGridView_SelectionChanged);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(685, 284);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(76, 75);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "修改状态";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(767, 284);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(76, 75);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "删除登到";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(267, 244);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(229, 25);
            this.idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(195, 250);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(37, 15);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "编号";
            // 
            // circulationButton
            // 
            this.circulationButton.Location = new System.Drawing.Point(59, 285);
            this.circulationButton.Name = "circulationButton";
            this.circulationButton.Size = new System.Drawing.Size(76, 75);
            this.circulationButton.TabIndex = 1;
            this.circulationButton.Text = "完好期刊\r\n全部入库";
            this.circulationButton.UseVisualStyleBackColor = true;
            this.circulationButton.Click += new System.EventHandler(this.circulationButton_Click);
            // 
            // PeriodicalArrivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 688);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.orderIdLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.circulationButton);
            this.Controls.Add(this.arrivalButton);
            this.Controls.Add(this.arrivalDataGridView);
            this.Name = "PeriodicalArrivalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "期刊登到";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PeriodicalArrivalForm_FormClosing);
            this.Load += new System.EventHandler(this.PeriodicalArrivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrivalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView arrivalDataGridView;
        private System.Windows.Forms.Button arrivalButton;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.Label orderIdLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button circulationButton;
    }
}