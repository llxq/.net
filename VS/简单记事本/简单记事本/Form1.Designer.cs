namespace 简单记事本
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OPenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Txt = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.OPenFile,
            this.SaveFile});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCopy,
            this.ToolPaste,
            this.ToolCut,
            this.ToolDelete,
            this.ToolCheck});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolFont,
            this.ToolColor});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.设置ToolStripMenuItem.Text = "设置(&N)";
            // 
            // NewFile
            // 
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(152, 22);
            this.NewFile.Text = "新建";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // OPenFile
            // 
            this.OPenFile.Name = "OPenFile";
            this.OPenFile.Size = new System.Drawing.Size(152, 22);
            this.OPenFile.Text = "打开";
            this.OPenFile.Click += new System.EventHandler(this.OPenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(152, 22);
            this.SaveFile.Text = "保存";
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ToolCopy
            // 
            this.ToolCopy.Name = "ToolCopy";
            this.ToolCopy.Size = new System.Drawing.Size(152, 22);
            this.ToolCopy.Text = "复制";
            this.ToolCopy.Click += new System.EventHandler(this.ToolCopy_Click);
            // 
            // ToolPaste
            // 
            this.ToolPaste.Name = "ToolPaste";
            this.ToolPaste.Size = new System.Drawing.Size(152, 22);
            this.ToolPaste.Text = "黏贴";
            this.ToolPaste.Click += new System.EventHandler(this.ToolPaste_Click);
            // 
            // ToolCut
            // 
            this.ToolCut.Name = "ToolCut";
            this.ToolCut.Size = new System.Drawing.Size(152, 22);
            this.ToolCut.Text = "剪切";
            this.ToolCut.Click += new System.EventHandler(this.ToolCut_Click);
            // 
            // ToolDelete
            // 
            this.ToolDelete.Name = "ToolDelete";
            this.ToolDelete.Size = new System.Drawing.Size(152, 22);
            this.ToolDelete.Text = "删除";
            this.ToolDelete.Click += new System.EventHandler(this.ToolDelete_Click);
            // 
            // ToolCheck
            // 
            this.ToolCheck.Name = "ToolCheck";
            this.ToolCheck.Size = new System.Drawing.Size(152, 22);
            this.ToolCheck.Text = "全选";
            this.ToolCheck.Click += new System.EventHandler(this.ToolCheck_Click);
            // 
            // ToolFont
            // 
            this.ToolFont.Name = "ToolFont";
            this.ToolFont.Size = new System.Drawing.Size(152, 22);
            this.ToolFont.Text = "字体";
            this.ToolFont.Click += new System.EventHandler(this.ToolFont_Click);
            // 
            // ToolColor
            // 
            this.ToolColor.Name = "ToolColor";
            this.ToolColor.Size = new System.Drawing.Size(152, 22);
            this.ToolColor.Text = "颜色";
            this.ToolColor.Click += new System.EventHandler(this.ToolColor_Click);
            // 
            // Txt
            // 
            this.Txt.Location = new System.Drawing.Point(12, 28);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(690, 374);
            this.Txt.TabIndex = 1;
            this.Txt.Text = "";
            this.Txt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 414);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFile;
        private System.Windows.Forms.ToolStripMenuItem OPenFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolCopy;
        private System.Windows.Forms.ToolStripMenuItem ToolPaste;
        private System.Windows.Forms.ToolStripMenuItem ToolCut;
        private System.Windows.Forms.ToolStripMenuItem ToolDelete;
        private System.Windows.Forms.ToolStripMenuItem ToolCheck;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolFont;
        private System.Windows.Forms.ToolStripMenuItem ToolColor;
        private System.Windows.Forms.RichTextBox Txt;
    }
}

