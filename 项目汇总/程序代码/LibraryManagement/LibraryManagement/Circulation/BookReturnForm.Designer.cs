namespace LibraryManagement.Circulation
{
    partial class BookReturnForm
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
            this.borrowDatePicker = new System.Windows.Forms.DateTimePicker();
            this.officialTitleTextBox = new System.Windows.Forms.TextBox();
            this.officialTitleLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.typeNumTextBox = new System.Windows.Forms.TextBox();
            this.typeNumLabel = new System.Windows.Forms.Label();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.chooseValidityTermButton = new System.Windows.Forms.Button();
            this.chooseAppointDateButton = new System.Windows.Forms.Button();
            this.validityTermTextBox = new System.Windows.Forms.TextBox();
            this.appointDateTextBox = new System.Windows.Forms.TextBox();
            this.bookCodeTextBox = new System.Windows.Forms.TextBox();
            this.fineAmountTextBox = new System.Windows.Forms.TextBox();
            this.penaltyMultipleTextBox = new System.Windows.Forms.TextBox();
            this.workplaceTextBox = new System.Windows.Forms.TextBox();
            this.appointmentNumTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.haveAppointedNumTextBox = new System.Windows.Forms.TextBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.borrowNumTextBox = new System.Windows.Forms.TextBox();
            this.fineAmountLabel = new System.Windows.Forms.Label();
            this.borrowCardNumTextBox = new System.Windows.Forms.TextBox();
            this.penaltyMultipleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.workplaceLabel = new System.Windows.Forms.Label();
            this.appointmentNumLabel = new System.Windows.Forms.Label();
            this.haveAppointedNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.borrowNumLabel = new System.Windows.Forms.Label();
            this.bookCodeLabel = new System.Windows.Forms.Label();
            this.validityTermLabel = new System.Windows.Forms.Label();
            this.borrowDateLabel = new System.Windows.Forms.Label();
            this.borrowCardNumLabel = new System.Windows.Forms.Label();
            this.appointDateLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowDatePicker
            // 
            this.borrowDatePicker.Location = new System.Drawing.Point(620, 145);
            this.borrowDatePicker.Name = "borrowDatePicker";
            this.borrowDatePicker.Size = new System.Drawing.Size(330, 25);
            this.borrowDatePicker.TabIndex = 17;
            // 
            // officialTitleTextBox
            // 
            this.officialTitleTextBox.Location = new System.Drawing.Point(620, 115);
            this.officialTitleTextBox.Name = "officialTitleTextBox";
            this.officialTitleTextBox.ReadOnly = true;
            this.officialTitleTextBox.Size = new System.Drawing.Size(330, 25);
            this.officialTitleTextBox.TabIndex = 16;
            // 
            // officialTitleLabel
            // 
            this.officialTitleLabel.AutoSize = true;
            this.officialTitleLabel.Location = new System.Drawing.Point(540, 120);
            this.officialTitleLabel.Name = "officialTitleLabel";
            this.officialTitleLabel.Size = new System.Drawing.Size(52, 15);
            this.officialTitleLabel.TabIndex = 15;
            this.officialTitleLabel.Text = "正题名";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(620, 85);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.ReadOnly = true;
            this.authorTextBox.Size = new System.Drawing.Size(120, 25);
            this.authorTextBox.TabIndex = 14;
            // 
            // typeNumTextBox
            // 
            this.typeNumTextBox.Location = new System.Drawing.Point(830, 85);
            this.typeNumTextBox.Name = "typeNumTextBox";
            this.typeNumTextBox.ReadOnly = true;
            this.typeNumTextBox.Size = new System.Drawing.Size(120, 25);
            this.typeNumTextBox.TabIndex = 14;
            // 
            // typeNumLabel
            // 
            this.typeNumLabel.AutoSize = true;
            this.typeNumLabel.Location = new System.Drawing.Point(755, 90);
            this.typeNumLabel.Name = "typeNumLabel";
            this.typeNumLabel.Size = new System.Drawing.Size(52, 15);
            this.typeNumLabel.TabIndex = 13;
            this.typeNumLabel.Text = "分类号";
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(620, 55);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.ReadOnly = true;
            this.IsbnTextBox.Size = new System.Drawing.Size(330, 25);
            this.IsbnTextBox.TabIndex = 14;
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.Location = new System.Drawing.Point(540, 60);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(63, 15);
            this.IsbnLabel.TabIndex = 13;
            this.IsbnLabel.Text = "I S B N";
            // 
            // chooseValidityTermButton
            // 
            this.chooseValidityTermButton.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseValidityTermButton.Location = new System.Drawing.Point(914, 204);
            this.chooseValidityTermButton.Name = "chooseValidityTermButton";
            this.chooseValidityTermButton.Size = new System.Drawing.Size(36, 25);
            this.chooseValidityTermButton.TabIndex = 10;
            this.chooseValidityTermButton.Text = "...";
            this.chooseValidityTermButton.UseVisualStyleBackColor = true;
            // 
            // chooseAppointDateButton
            // 
            this.chooseAppointDateButton.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseAppointDateButton.Location = new System.Drawing.Point(914, 174);
            this.chooseAppointDateButton.Name = "chooseAppointDateButton";
            this.chooseAppointDateButton.Size = new System.Drawing.Size(36, 25);
            this.chooseAppointDateButton.TabIndex = 10;
            this.chooseAppointDateButton.Text = "...";
            this.chooseAppointDateButton.UseVisualStyleBackColor = true;
            // 
            // validityTermTextBox
            // 
            this.validityTermTextBox.Location = new System.Drawing.Point(620, 205);
            this.validityTermTextBox.Name = "validityTermTextBox";
            this.validityTermTextBox.Size = new System.Drawing.Size(288, 25);
            this.validityTermTextBox.TabIndex = 9;
            // 
            // appointDateTextBox
            // 
            this.appointDateTextBox.Location = new System.Drawing.Point(620, 175);
            this.appointDateTextBox.Name = "appointDateTextBox";
            this.appointDateTextBox.Size = new System.Drawing.Size(288, 25);
            this.appointDateTextBox.TabIndex = 9;
            // 
            // bookCodeTextBox
            // 
            this.bookCodeTextBox.Location = new System.Drawing.Point(620, 25);
            this.bookCodeTextBox.Name = "bookCodeTextBox";
            this.bookCodeTextBox.Size = new System.Drawing.Size(330, 25);
            this.bookCodeTextBox.TabIndex = 9;
            // 
            // fineAmountTextBox
            // 
            this.fineAmountTextBox.Location = new System.Drawing.Point(620, 235);
            this.fineAmountTextBox.Name = "fineAmountTextBox";
            this.fineAmountTextBox.ReadOnly = true;
            this.fineAmountTextBox.Size = new System.Drawing.Size(330, 25);
            this.fineAmountTextBox.TabIndex = 9;
            // 
            // penaltyMultipleTextBox
            // 
            this.penaltyMultipleTextBox.Location = new System.Drawing.Point(115, 235);
            this.penaltyMultipleTextBox.Name = "penaltyMultipleTextBox";
            this.penaltyMultipleTextBox.ReadOnly = true;
            this.penaltyMultipleTextBox.Size = new System.Drawing.Size(330, 25);
            this.penaltyMultipleTextBox.TabIndex = 9;
            // 
            // workplaceTextBox
            // 
            this.workplaceTextBox.Location = new System.Drawing.Point(115, 115);
            this.workplaceTextBox.Name = "workplaceTextBox";
            this.workplaceTextBox.ReadOnly = true;
            this.workplaceTextBox.Size = new System.Drawing.Size(330, 25);
            this.workplaceTextBox.TabIndex = 9;
            // 
            // appointmentNumTextBox
            // 
            this.appointmentNumTextBox.Location = new System.Drawing.Point(115, 175);
            this.appointmentNumTextBox.Name = "appointmentNumTextBox";
            this.appointmentNumTextBox.ReadOnly = true;
            this.appointmentNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.appointmentNumTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(330, 25);
            this.nameTextBox.TabIndex = 9;
            // 
            // haveAppointedNumTextBox
            // 
            this.haveAppointedNumTextBox.Location = new System.Drawing.Point(115, 205);
            this.haveAppointedNumTextBox.Name = "haveAppointedNumTextBox";
            this.haveAppointedNumTextBox.ReadOnly = true;
            this.haveAppointedNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.haveAppointedNumTextBox.TabIndex = 9;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.scriptUserControl1);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowDatePicker);
            this.mainSplitContainer.Panel2.Controls.Add(this.officialTitleTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.officialTitleLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.authorTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.typeNumTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.typeNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.IsbnTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.IsbnLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.chooseValidityTermButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.chooseAppointDateButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.validityTermTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.appointDateTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.bookCodeTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.fineAmountTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.penaltyMultipleTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.workplaceTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.appointmentNumTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.nameTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.haveAppointedNumTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.genderTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowNumTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.fineAmountLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowCardNumTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.penaltyMultipleLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.authorLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.workplaceLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.appointmentNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.haveAppointedNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.nameLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.genderLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.bookCodeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.validityTermLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowDateLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowCardNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.appointDateLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.mainSplitContainer.Size = new System.Drawing.Size(1050, 701);
            this.mainSplitContainer.SplitterDistance = 82;
            this.mainSplitContainer.TabIndex = 5;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(1050, 82);
            this.scriptUserControl1.TabIndex = 0;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(115, 85);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(330, 25);
            this.genderTextBox.TabIndex = 9;
            // 
            // borrowNumTextBox
            // 
            this.borrowNumTextBox.Location = new System.Drawing.Point(115, 145);
            this.borrowNumTextBox.Name = "borrowNumTextBox";
            this.borrowNumTextBox.ReadOnly = true;
            this.borrowNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.borrowNumTextBox.TabIndex = 9;
            // 
            // fineAmountLabel
            // 
            this.fineAmountLabel.AutoSize = true;
            this.fineAmountLabel.Location = new System.Drawing.Point(540, 240);
            this.fineAmountLabel.Name = "fineAmountLabel";
            this.fineAmountLabel.Size = new System.Drawing.Size(67, 15);
            this.fineAmountLabel.TabIndex = 1;
            this.fineAmountLabel.Text = "罚款金额";
            // 
            // borrowCardNumTextBox
            // 
            this.borrowCardNumTextBox.Location = new System.Drawing.Point(115, 25);
            this.borrowCardNumTextBox.Name = "borrowCardNumTextBox";
            this.borrowCardNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.borrowCardNumTextBox.TabIndex = 9;
            // 
            // penaltyMultipleLabel
            // 
            this.penaltyMultipleLabel.AutoSize = true;
            this.penaltyMultipleLabel.Location = new System.Drawing.Point(35, 240);
            this.penaltyMultipleLabel.Name = "penaltyMultipleLabel";
            this.penaltyMultipleLabel.Size = new System.Drawing.Size(67, 15);
            this.penaltyMultipleLabel.TabIndex = 1;
            this.penaltyMultipleLabel.Text = "赔款倍数";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(540, 90);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(37, 15);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "作者";
            // 
            // workplaceLabel
            // 
            this.workplaceLabel.AutoSize = true;
            this.workplaceLabel.Location = new System.Drawing.Point(35, 120);
            this.workplaceLabel.Name = "workplaceLabel";
            this.workplaceLabel.Size = new System.Drawing.Size(37, 15);
            this.workplaceLabel.TabIndex = 1;
            this.workplaceLabel.Text = "单位";
            // 
            // appointmentNumLabel
            // 
            this.appointmentNumLabel.AutoSize = true;
            this.appointmentNumLabel.Location = new System.Drawing.Point(35, 180);
            this.appointmentNumLabel.Name = "appointmentNumLabel";
            this.appointmentNumLabel.Size = new System.Drawing.Size(67, 15);
            this.appointmentNumLabel.TabIndex = 1;
            this.appointmentNumLabel.Text = "可预约数";
            // 
            // haveAppointedNumLabel
            // 
            this.haveAppointedNumLabel.AutoSize = true;
            this.haveAppointedNumLabel.Location = new System.Drawing.Point(35, 210);
            this.haveAppointedNumLabel.Name = "haveAppointedNumLabel";
            this.haveAppointedNumLabel.Size = new System.Drawing.Size(67, 15);
            this.haveAppointedNumLabel.TabIndex = 1;
            this.haveAppointedNumLabel.Text = "已预约数";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(35, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "姓名";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(35, 90);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(37, 15);
            this.genderLabel.TabIndex = 1;
            this.genderLabel.Text = "性别";
            // 
            // borrowNumLabel
            // 
            this.borrowNumLabel.AutoSize = true;
            this.borrowNumLabel.Location = new System.Drawing.Point(35, 150);
            this.borrowNumLabel.Name = "borrowNumLabel";
            this.borrowNumLabel.Size = new System.Drawing.Size(67, 15);
            this.borrowNumLabel.TabIndex = 1;
            this.borrowNumLabel.Text = "可借数目";
            // 
            // bookCodeLabel
            // 
            this.bookCodeLabel.AutoSize = true;
            this.bookCodeLabel.Location = new System.Drawing.Point(540, 30);
            this.bookCodeLabel.Name = "bookCodeLabel";
            this.bookCodeLabel.Size = new System.Drawing.Size(82, 15);
            this.bookCodeLabel.TabIndex = 1;
            this.bookCodeLabel.Text = "书本条码号";
            // 
            // validityTermLabel
            // 
            this.validityTermLabel.AutoSize = true;
            this.validityTermLabel.Location = new System.Drawing.Point(540, 210);
            this.validityTermLabel.Name = "validityTermLabel";
            this.validityTermLabel.Size = new System.Drawing.Size(52, 15);
            this.validityTermLabel.TabIndex = 2;
            this.validityTermLabel.Text = "有效期";
            // 
            // borrowDateLabel
            // 
            this.borrowDateLabel.AutoSize = true;
            this.borrowDateLabel.Location = new System.Drawing.Point(540, 150);
            this.borrowDateLabel.Name = "borrowDateLabel";
            this.borrowDateLabel.Size = new System.Drawing.Size(67, 15);
            this.borrowDateLabel.TabIndex = 2;
            this.borrowDateLabel.Text = "借阅日期";
            // 
            // borrowCardNumLabel
            // 
            this.borrowCardNumLabel.AutoSize = true;
            this.borrowCardNumLabel.Location = new System.Drawing.Point(35, 30);
            this.borrowCardNumLabel.Name = "borrowCardNumLabel";
            this.borrowCardNumLabel.Size = new System.Drawing.Size(67, 15);
            this.borrowCardNumLabel.TabIndex = 1;
            this.borrowCardNumLabel.Text = "借书证号";
            // 
            // appointDateLabel
            // 
            this.appointDateLabel.AutoSize = true;
            this.appointDateLabel.Location = new System.Drawing.Point(540, 180);
            this.appointDateLabel.Name = "appointDateLabel";
            this.appointDateLabel.Size = new System.Drawing.Size(67, 15);
            this.appointDateLabel.TabIndex = 2;
            this.appointDateLabel.Text = "预约日期";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // BookReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 701);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "BookReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookAppointForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookReturnForm_FormClosing);
            this.Load += new System.EventHandler(this.BookReturnForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker borrowDatePicker;
        private System.Windows.Forms.TextBox officialTitleTextBox;
        private System.Windows.Forms.Label officialTitleLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox typeNumTextBox;
        private System.Windows.Forms.Label typeNumLabel;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.Button chooseValidityTermButton;
        private System.Windows.Forms.Button chooseAppointDateButton;
        private System.Windows.Forms.TextBox validityTermTextBox;
        private System.Windows.Forms.TextBox appointDateTextBox;
        private System.Windows.Forms.TextBox bookCodeTextBox;
        private System.Windows.Forms.TextBox fineAmountTextBox;
        private System.Windows.Forms.TextBox penaltyMultipleTextBox;
        private System.Windows.Forms.TextBox workplaceTextBox;
        private System.Windows.Forms.TextBox appointmentNumTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox haveAppointedNumTextBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox borrowNumTextBox;
        private System.Windows.Forms.Label fineAmountLabel;
        private System.Windows.Forms.TextBox borrowCardNumTextBox;
        private System.Windows.Forms.Label penaltyMultipleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label workplaceLabel;
        private System.Windows.Forms.Label appointmentNumLabel;
        private System.Windows.Forms.Label haveAppointedNumLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label borrowNumLabel;
        private System.Windows.Forms.Label bookCodeLabel;
        private System.Windows.Forms.Label validityTermLabel;
        private System.Windows.Forms.Label borrowDateLabel;
        private System.Windows.Forms.Label borrowCardNumLabel;
        private System.Windows.Forms.Label appointDateLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}