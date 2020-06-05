namespace LibraryManagement.Circulation
{
    partial class CirculationForm
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
            this.bookBorrowButton = new System.Windows.Forms.Button();
            this.bookReturnButton = new System.Windows.Forms.Button();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.defaultHandleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookBorrowButton
            // 
            this.bookBorrowButton.Location = new System.Drawing.Point(92, 149);
            this.bookBorrowButton.Name = "bookBorrowButton";
            this.bookBorrowButton.Size = new System.Drawing.Size(75, 75);
            this.bookBorrowButton.TabIndex = 0;
            this.bookBorrowButton.Text = "图书借阅";
            this.bookBorrowButton.UseVisualStyleBackColor = true;
            this.bookBorrowButton.Click += new System.EventHandler(this.bookBorrowButton_Click);
            // 
            // bookReturnButton
            // 
            this.bookReturnButton.Location = new System.Drawing.Point(237, 149);
            this.bookReturnButton.Name = "bookReturnButton";
            this.bookReturnButton.Size = new System.Drawing.Size(75, 75);
            this.bookReturnButton.TabIndex = 0;
            this.bookReturnButton.Text = "图书归还";
            this.bookReturnButton.UseVisualStyleBackColor = true;
            this.bookReturnButton.Click += new System.EventHandler(this.bookBorrowButton_Click);
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.Location = new System.Drawing.Point(376, 149);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(75, 75);
            this.bookAppointmentButton.TabIndex = 0;
            this.bookAppointmentButton.Text = "图书预约";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            this.bookAppointmentButton.Click += new System.EventHandler(this.bookBorrowButton_Click);
            // 
            // defaultHandleButton
            // 
            this.defaultHandleButton.Location = new System.Drawing.Point(526, 149);
            this.defaultHandleButton.Name = "defaultHandleButton";
            this.defaultHandleButton.Size = new System.Drawing.Size(75, 75);
            this.defaultHandleButton.TabIndex = 0;
            this.defaultHandleButton.Text = "违约处理";
            this.defaultHandleButton.UseVisualStyleBackColor = true;
            this.defaultHandleButton.Click += new System.EventHandler(this.bookBorrowButton_Click);
            // 
            // CirculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.defaultHandleButton);
            this.Controls.Add(this.bookAppointmentButton);
            this.Controls.Add(this.bookReturnButton);
            this.Controls.Add(this.bookBorrowButton);
            this.Name = "CirculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CirculationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CirculationForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bookBorrowButton;
        private System.Windows.Forms.Button bookReturnButton;
        private System.Windows.Forms.Button bookAppointmentButton;
        private System.Windows.Forms.Button defaultHandleButton;
    }
}