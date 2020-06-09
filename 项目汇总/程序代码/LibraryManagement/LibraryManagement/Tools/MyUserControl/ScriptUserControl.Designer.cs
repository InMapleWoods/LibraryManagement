namespace LibraryManagement.Tools.MyUserControl
{
    partial class ScriptUserControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.operatePanel = new System.Windows.Forms.TableLayoutPanel();
            this.createButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.emptyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.operatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // operatePanel
            // 
            this.operatePanel.ColumnCount = 9;
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.operatePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.operatePanel.Controls.Add(this.createButton, 0, 0);
            this.operatePanel.Controls.Add(this.changeButton, 2, 0);
            this.operatePanel.Controls.Add(this.addButton, 1, 0);
            this.operatePanel.Controls.Add(this.emptyButton, 3, 0);
            this.operatePanel.Controls.Add(this.saveButton, 4, 0);
            this.operatePanel.Controls.Add(this.previousButton, 5, 0);
            this.operatePanel.Controls.Add(this.nextButton, 6, 0);
            this.operatePanel.Controls.Add(this.helpButton, 7, 0);
            this.operatePanel.Controls.Add(this.exitButton, 8, 0);
            this.operatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatePanel.Location = new System.Drawing.Point(0, 0);
            this.operatePanel.Name = "operatePanel";
            this.operatePanel.RowCount = 1;
            this.operatePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.operatePanel.Size = new System.Drawing.Size(1000, 150);
            this.operatePanel.TabIndex = 1;
            // 
            // createButton
            // 
            this.createButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createButton.Location = new System.Drawing.Point(3, 3);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(94, 144);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "新增";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // changeButton
            // 
            this.changeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeButton.Location = new System.Drawing.Point(203, 3);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(94, 144);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "修改记录";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(103, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 144);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "增加";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // emptyButton
            // 
            this.emptyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyButton.Enabled = false;
            this.emptyButton.Location = new System.Drawing.Point(303, 3);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(94, 144);
            this.emptyButton.TabIndex = 3;
            this.emptyButton.Text = "删除记录";
            this.emptyButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(403, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 144);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "保存记录";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousButton.Location = new System.Drawing.Point(503, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(94, 144);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "上一条";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.Location = new System.Drawing.Point(603, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(94, 144);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "下一条";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpButton.Location = new System.Drawing.Point(703, 3);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(94, 144);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "帮助";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Location = new System.Drawing.Point(803, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(194, 144);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // ScriptUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.operatePanel);
            this.Name = "ScriptUserControl";
            this.Size = new System.Drawing.Size(1000, 150);
            this.operatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel operatePanel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button emptyButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
    }
}
