namespace LibraryManagement.Circulation
{
    partial class BookCirculationForm
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
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.scriptUserControl1 = new LibraryManagement.Tools.MyUserControl.ScriptUserControl();
            this.officialTitleTextBox = new System.Windows.Forms.TextBox();
            this.officialTitleLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.typeNumTextBox = new System.Windows.Forms.TextBox();
            this.typeNumLabel = new System.Windows.Forms.Label();
            this.IsbnTextBox = new System.Windows.Forms.TextBox();
            this.IsbnLabel = new System.Windows.Forms.Label();
            this.optionComboBox = new System.Windows.Forms.ComboBox();
            this.ordererComboBox = new System.Windows.Forms.ComboBox();
            this.chooseValidityTermButton = new System.Windows.Forms.Button();
            this.chooseBorrowDateButton = new System.Windows.Forms.Button();
            this.chooseAppointDateButton = new System.Windows.Forms.Button();
            this.borrowDateTextBox = new System.Windows.Forms.TextBox();
            this.validityTermTextBox = new System.Windows.Forms.TextBox();
            this.appointDateTextBox = new System.Windows.Forms.TextBox();
            this.bookCodeTextBox = new System.Windows.Forms.TextBox();
            this.penaltyMultipleTextBox = new System.Windows.Forms.TextBox();
            this.workplaceTextBox = new System.Windows.Forms.TextBox();
            this.appointmentNumTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.haveAppointedNumTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.borrowNumTextBox = new System.Windows.Forms.TextBox();
            this.borrowCardNumTextBox = new System.Windows.Forms.TextBox();
            this.penaltyMultipleLabel = new System.Windows.Forms.Label();
            this.borrowCardCodeTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.workplaceLabel = new System.Windows.Forms.Label();
            this.optionLabel = new System.Windows.Forms.Label();
            this.appointmentNumLabel = new System.Windows.Forms.Label();
            this.ordererLabel = new System.Windows.Forms.Label();
            this.haveAppointedNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.borrowNumLabel = new System.Windows.Forms.Label();
            this.bookCodeLabel = new System.Windows.Forms.Label();
            this.validityTermLabel = new System.Windows.Forms.Label();
            this.borrowDateLabel = new System.Windows.Forms.Label();
            this.borrowCardNumLabel = new System.Windows.Forms.Label();
            this.appointDateLabel = new System.Windows.Forms.Label();
            this.borrowCardCodeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fineAmountLabel = new System.Windows.Forms.Label();
            this.fineAmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.mainSplitContainer.Panel2.Controls.Add(this.officialTitleTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.officialTitleLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.authorTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.typeNumTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.typeNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.IsbnTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.IsbnLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.optionComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.ordererComboBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.chooseValidityTermButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.chooseBorrowDateButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.chooseAppointDateButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowDateTextBox);
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
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowCardCodeTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.authorLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.workplaceLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.optionLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.appointmentNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.ordererLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.haveAppointedNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.nameLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.genderLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.bookCodeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.validityTermLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowDateLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowCardNumLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.appointDateLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.borrowCardCodeLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.dataGridView1);
            this.mainSplitContainer.Size = new System.Drawing.Size(1050, 743);
            this.mainSplitContainer.SplitterDistance = 87;
            this.mainSplitContainer.TabIndex = 4;
            // 
            // scriptUserControl1
            // 
            this.scriptUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptUserControl1.Location = new System.Drawing.Point(0, 0);
            this.scriptUserControl1.Name = "scriptUserControl1";
            this.scriptUserControl1.Size = new System.Drawing.Size(1050, 87);
            this.scriptUserControl1.TabIndex = 0;
            // 
            // officialTitleTextBox
            // 
            this.officialTitleTextBox.Location = new System.Drawing.Point(620, 145);
            this.officialTitleTextBox.Name = "officialTitleTextBox";
            this.officialTitleTextBox.Size = new System.Drawing.Size(330, 25);
            this.officialTitleTextBox.TabIndex = 16;
            // 
            // officialTitleLabel
            // 
            this.officialTitleLabel.AutoSize = true;
            this.officialTitleLabel.Location = new System.Drawing.Point(540, 150);
            this.officialTitleLabel.Name = "officialTitleLabel";
            this.officialTitleLabel.Size = new System.Drawing.Size(52, 15);
            this.officialTitleLabel.TabIndex = 15;
            this.officialTitleLabel.Text = "正题名";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(620, 115);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(120, 25);
            this.authorTextBox.TabIndex = 14;
            // 
            // typeNumTextBox
            // 
            this.typeNumTextBox.Location = new System.Drawing.Point(830, 115);
            this.typeNumTextBox.Name = "typeNumTextBox";
            this.typeNumTextBox.Size = new System.Drawing.Size(120, 25);
            this.typeNumTextBox.TabIndex = 14;
            // 
            // typeNumLabel
            // 
            this.typeNumLabel.AutoSize = true;
            this.typeNumLabel.Location = new System.Drawing.Point(755, 120);
            this.typeNumLabel.Name = "typeNumLabel";
            this.typeNumLabel.Size = new System.Drawing.Size(52, 15);
            this.typeNumLabel.TabIndex = 13;
            this.typeNumLabel.Text = "分类号";
            // 
            // IsbnTextBox
            // 
            this.IsbnTextBox.Location = new System.Drawing.Point(830, 85);
            this.IsbnTextBox.Name = "IsbnTextBox";
            this.IsbnTextBox.Size = new System.Drawing.Size(120, 25);
            this.IsbnTextBox.TabIndex = 14;
            // 
            // IsbnLabel
            // 
            this.IsbnLabel.AutoSize = true;
            this.IsbnLabel.Location = new System.Drawing.Point(755, 90);
            this.IsbnLabel.Name = "IsbnLabel";
            this.IsbnLabel.Size = new System.Drawing.Size(63, 15);
            this.IsbnLabel.TabIndex = 13;
            this.IsbnLabel.Text = "I S B N";
            // 
            // optionComboBox
            // 
            this.optionComboBox.FormattingEnabled = true;
            this.optionComboBox.Items.AddRange(new object[] {
            "借阅",
            "归还",
            "预约"});
            this.optionComboBox.Location = new System.Drawing.Point(620, 85);
            this.optionComboBox.Name = "optionComboBox";
            this.optionComboBox.Size = new System.Drawing.Size(120, 23);
            this.optionComboBox.TabIndex = 12;
            // 
            // ordererComboBox
            // 
            this.ordererComboBox.FormattingEnabled = true;
            this.ordererComboBox.Location = new System.Drawing.Point(620, 55);
            this.ordererComboBox.Name = "ordererComboBox";
            this.ordererComboBox.Size = new System.Drawing.Size(330, 23);
            this.ordererComboBox.TabIndex = 12;
            // 
            // chooseValidityTermButton
            // 
            this.chooseValidityTermButton.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseValidityTermButton.Location = new System.Drawing.Point(914, 234);
            this.chooseValidityTermButton.Name = "chooseValidityTermButton";
            this.chooseValidityTermButton.Size = new System.Drawing.Size(36, 25);
            this.chooseValidityTermButton.TabIndex = 10;
            this.chooseValidityTermButton.Text = "...";
            this.chooseValidityTermButton.UseVisualStyleBackColor = true;
            // 
            // chooseBorrowDateButton
            // 
            this.chooseBorrowDateButton.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseBorrowDateButton.Location = new System.Drawing.Point(914, 175);
            this.chooseBorrowDateButton.Name = "chooseBorrowDateButton";
            this.chooseBorrowDateButton.Size = new System.Drawing.Size(36, 25);
            this.chooseBorrowDateButton.TabIndex = 10;
            this.chooseBorrowDateButton.Text = "...";
            this.chooseBorrowDateButton.UseVisualStyleBackColor = true;
            // 
            // chooseAppointDateButton
            // 
            this.chooseAppointDateButton.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseAppointDateButton.Location = new System.Drawing.Point(914, 204);
            this.chooseAppointDateButton.Name = "chooseAppointDateButton";
            this.chooseAppointDateButton.Size = new System.Drawing.Size(36, 25);
            this.chooseAppointDateButton.TabIndex = 10;
            this.chooseAppointDateButton.Text = "...";
            this.chooseAppointDateButton.UseVisualStyleBackColor = true;
            // 
            // borrowDateTextBox
            // 
            this.borrowDateTextBox.Location = new System.Drawing.Point(620, 175);
            this.borrowDateTextBox.Name = "borrowDateTextBox";
            this.borrowDateTextBox.Size = new System.Drawing.Size(288, 25);
            this.borrowDateTextBox.TabIndex = 9;
            // 
            // validityTermTextBox
            // 
            this.validityTermTextBox.Location = new System.Drawing.Point(620, 235);
            this.validityTermTextBox.Name = "validityTermTextBox";
            this.validityTermTextBox.Size = new System.Drawing.Size(288, 25);
            this.validityTermTextBox.TabIndex = 9;
            // 
            // appointDateTextBox
            // 
            this.appointDateTextBox.Location = new System.Drawing.Point(620, 205);
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
            // penaltyMultipleTextBox
            // 
            this.penaltyMultipleTextBox.Location = new System.Drawing.Point(115, 265);
            this.penaltyMultipleTextBox.Name = "penaltyMultipleTextBox";
            this.penaltyMultipleTextBox.Size = new System.Drawing.Size(330, 25);
            this.penaltyMultipleTextBox.TabIndex = 9;
            // 
            // workplaceTextBox
            // 
            this.workplaceTextBox.Location = new System.Drawing.Point(115, 145);
            this.workplaceTextBox.Name = "workplaceTextBox";
            this.workplaceTextBox.Size = new System.Drawing.Size(330, 25);
            this.workplaceTextBox.TabIndex = 9;
            // 
            // appointmentNumTextBox
            // 
            this.appointmentNumTextBox.Location = new System.Drawing.Point(115, 205);
            this.appointmentNumTextBox.Name = "appointmentNumTextBox";
            this.appointmentNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.appointmentNumTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(330, 25);
            this.nameTextBox.TabIndex = 9;
            // 
            // haveAppointedNumTextBox
            // 
            this.haveAppointedNumTextBox.Location = new System.Drawing.Point(115, 235);
            this.haveAppointedNumTextBox.Name = "haveAppointedNumTextBox";
            this.haveAppointedNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.haveAppointedNumTextBox.TabIndex = 9;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(115, 115);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(330, 25);
            this.genderTextBox.TabIndex = 9;
            // 
            // borrowNumTextBox
            // 
            this.borrowNumTextBox.Location = new System.Drawing.Point(115, 175);
            this.borrowNumTextBox.Name = "borrowNumTextBox";
            this.borrowNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.borrowNumTextBox.TabIndex = 9;
            // 
            // borrowCardNumTextBox
            // 
            this.borrowCardNumTextBox.Location = new System.Drawing.Point(115, 55);
            this.borrowCardNumTextBox.Name = "borrowCardNumTextBox";
            this.borrowCardNumTextBox.Size = new System.Drawing.Size(330, 25);
            this.borrowCardNumTextBox.TabIndex = 9;
            // 
            // penaltyMultipleLabel
            // 
            this.penaltyMultipleLabel.AutoSize = true;
            this.penaltyMultipleLabel.Location = new System.Drawing.Point(35, 270);
            this.penaltyMultipleLabel.Name = "penaltyMultipleLabel";
            this.penaltyMultipleLabel.Size = new System.Drawing.Size(67, 15);
            this.penaltyMultipleLabel.TabIndex = 1;
            this.penaltyMultipleLabel.Text = "赔款倍数";
            // 
            // borrowCardCodeTextBox
            // 
            this.borrowCardCodeTextBox.Location = new System.Drawing.Point(115, 25);
            this.borrowCardCodeTextBox.Name = "borrowCardCodeTextBox";
            this.borrowCardCodeTextBox.Size = new System.Drawing.Size(330, 25);
            this.borrowCardCodeTextBox.TabIndex = 9;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(540, 120);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(37, 15);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "作者";
            // 
            // workplaceLabel
            // 
            this.workplaceLabel.AutoSize = true;
            this.workplaceLabel.Location = new System.Drawing.Point(35, 150);
            this.workplaceLabel.Name = "workplaceLabel";
            this.workplaceLabel.Size = new System.Drawing.Size(37, 15);
            this.workplaceLabel.TabIndex = 1;
            this.workplaceLabel.Text = "单位";
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Location = new System.Drawing.Point(540, 90);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(67, 15);
            this.optionLabel.TabIndex = 1;
            this.optionLabel.Text = "流通事件";
            // 
            // appointmentNumLabel
            // 
            this.appointmentNumLabel.AutoSize = true;
            this.appointmentNumLabel.Location = new System.Drawing.Point(35, 210);
            this.appointmentNumLabel.Name = "appointmentNumLabel";
            this.appointmentNumLabel.Size = new System.Drawing.Size(67, 15);
            this.appointmentNumLabel.TabIndex = 1;
            this.appointmentNumLabel.Text = "可预约数";
            // 
            // ordererLabel
            // 
            this.ordererLabel.AutoSize = true;
            this.ordererLabel.Location = new System.Drawing.Point(540, 60);
            this.ordererLabel.Name = "ordererLabel";
            this.ordererLabel.Size = new System.Drawing.Size(52, 15);
            this.ordererLabel.TabIndex = 1;
            this.ordererLabel.Text = "订购人";
            // 
            // haveAppointedNumLabel
            // 
            this.haveAppointedNumLabel.AutoSize = true;
            this.haveAppointedNumLabel.Location = new System.Drawing.Point(35, 240);
            this.haveAppointedNumLabel.Name = "haveAppointedNumLabel";
            this.haveAppointedNumLabel.Size = new System.Drawing.Size(67, 15);
            this.haveAppointedNumLabel.TabIndex = 1;
            this.haveAppointedNumLabel.Text = "已预约数";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(35, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "姓名";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(35, 120);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(37, 15);
            this.genderLabel.TabIndex = 1;
            this.genderLabel.Text = "性别";
            // 
            // borrowNumLabel
            // 
            this.borrowNumLabel.AutoSize = true;
            this.borrowNumLabel.Location = new System.Drawing.Point(35, 180);
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
            this.validityTermLabel.Location = new System.Drawing.Point(540, 240);
            this.validityTermLabel.Name = "validityTermLabel";
            this.validityTermLabel.Size = new System.Drawing.Size(52, 15);
            this.validityTermLabel.TabIndex = 2;
            this.validityTermLabel.Text = "有效期";
            // 
            // borrowDateLabel
            // 
            this.borrowDateLabel.AutoSize = true;
            this.borrowDateLabel.Location = new System.Drawing.Point(540, 180);
            this.borrowDateLabel.Name = "borrowDateLabel";
            this.borrowDateLabel.Size = new System.Drawing.Size(67, 15);
            this.borrowDateLabel.TabIndex = 2;
            this.borrowDateLabel.Text = "借阅日期";
            // 
            // borrowCardNumLabel
            // 
            this.borrowCardNumLabel.AutoSize = true;
            this.borrowCardNumLabel.Location = new System.Drawing.Point(35, 60);
            this.borrowCardNumLabel.Name = "borrowCardNumLabel";
            this.borrowCardNumLabel.Size = new System.Drawing.Size(67, 15);
            this.borrowCardNumLabel.TabIndex = 1;
            this.borrowCardNumLabel.Text = "借书证号";
            // 
            // appointDateLabel
            // 
            this.appointDateLabel.AutoSize = true;
            this.appointDateLabel.Location = new System.Drawing.Point(540, 210);
            this.appointDateLabel.Name = "appointDateLabel";
            this.appointDateLabel.Size = new System.Drawing.Size(67, 15);
            this.appointDateLabel.TabIndex = 2;
            this.appointDateLabel.Text = "预约日期";
            // 
            // borrowCardCodeLabel
            // 
            this.borrowCardCodeLabel.AutoSize = true;
            this.borrowCardCodeLabel.Location = new System.Drawing.Point(35, 30);
            this.borrowCardCodeLabel.Name = "borrowCardCodeLabel";
            this.borrowCardCodeLabel.Size = new System.Drawing.Size(90, 15);
            this.borrowCardCodeLabel.TabIndex = 1;
            this.borrowCardCodeLabel.Text = "借书证条码 ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // fineAmountLabel
            // 
            this.fineAmountLabel.AutoSize = true;
            this.fineAmountLabel.Location = new System.Drawing.Point(540, 270);
            this.fineAmountLabel.Name = "fineAmountLabel";
            this.fineAmountLabel.Size = new System.Drawing.Size(67, 15);
            this.fineAmountLabel.TabIndex = 1;
            this.fineAmountLabel.Text = "赔款倍数";
            // 
            // fineAmountTextBox
            // 
            this.fineAmountTextBox.Location = new System.Drawing.Point(620, 265);
            this.fineAmountTextBox.Name = "fineAmountTextBox";
            this.fineAmountTextBox.Size = new System.Drawing.Size(330, 25);
            this.fineAmountTextBox.TabIndex = 9;
            // 
            // BookCirculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 743);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "BookCirculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借阅";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookCirculationForm_FormClosing);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private Tools.MyUserControl.ScriptUserControl scriptUserControl1;
        private System.Windows.Forms.TextBox borrowCardCodeTextBox;
        private System.Windows.Forms.Label bookCodeLabel;
        private System.Windows.Forms.Label borrowCardCodeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ordererComboBox;
        private System.Windows.Forms.Button chooseAppointDateButton;
        private System.Windows.Forms.TextBox appointDateTextBox;
        private System.Windows.Forms.TextBox bookCodeTextBox;
        private System.Windows.Forms.TextBox penaltyMultipleTextBox;
        private System.Windows.Forms.TextBox workplaceTextBox;
        private System.Windows.Forms.TextBox appointmentNumTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox haveAppointedNumTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox borrowNumTextBox;
        private System.Windows.Forms.TextBox borrowCardNumTextBox;
        private System.Windows.Forms.Label penaltyMultipleLabel;
        private System.Windows.Forms.Label workplaceLabel;
        private System.Windows.Forms.Label appointmentNumLabel;
        private System.Windows.Forms.Label ordererLabel;
        private System.Windows.Forms.Label haveAppointedNumLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label borrowNumLabel;
        private System.Windows.Forms.Label borrowCardNumLabel;
        private System.Windows.Forms.Label appointDateLabel;
        private System.Windows.Forms.ComboBox optionComboBox;
        private System.Windows.Forms.Button chooseValidityTermButton;
        private System.Windows.Forms.TextBox validityTermTextBox;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Label validityTermLabel;
        private System.Windows.Forms.TextBox typeNumTextBox;
        private System.Windows.Forms.Label typeNumLabel;
        private System.Windows.Forms.TextBox IsbnTextBox;
        private System.Windows.Forms.Label IsbnLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox officialTitleTextBox;
        private System.Windows.Forms.Label officialTitleLabel;
        private System.Windows.Forms.Button chooseBorrowDateButton;
        private System.Windows.Forms.TextBox borrowDateTextBox;
        private System.Windows.Forms.Label borrowDateLabel;
        private System.Windows.Forms.TextBox fineAmountTextBox;
        private System.Windows.Forms.Label fineAmountLabel;
    }
}