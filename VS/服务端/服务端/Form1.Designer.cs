namespace 服务端
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
            this.Iptxt = new System.Windows.Forms.TextBox();
            this.Dktxt = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Receivetxt = new System.Windows.Forms.RichTextBox();
            this.Sendtxt = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Iptxt
            // 
            this.Iptxt.Location = new System.Drawing.Point(35, 20);
            this.Iptxt.Name = "Iptxt";
            this.Iptxt.Size = new System.Drawing.Size(124, 21);
            this.Iptxt.TabIndex = 0;
            this.Iptxt.Text = "172.16.12.91";
            // 
            // Dktxt
            // 
            this.Dktxt.Location = new System.Drawing.Point(177, 20);
            this.Dktxt.Name = "Dktxt";
            this.Dktxt.Size = new System.Drawing.Size(48, 21);
            this.Dktxt.TabIndex = 1;
            this.Dktxt.Text = "50000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(253, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // Receivetxt
            // 
            this.Receivetxt.Location = new System.Drawing.Point(34, 60);
            this.Receivetxt.Name = "Receivetxt";
            this.Receivetxt.Size = new System.Drawing.Size(507, 143);
            this.Receivetxt.TabIndex = 4;
            this.Receivetxt.Text = "";
            // 
            // Sendtxt
            // 
            this.Sendtxt.Location = new System.Drawing.Point(35, 218);
            this.Sendtxt.Name = "Sendtxt";
            this.Sendtxt.Size = new System.Drawing.Size(506, 143);
            this.Sendtxt.TabIndex = 5;
            this.Sendtxt.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 379);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 21);
            this.textBox3.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(416, 378);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(416, 407);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(100, 23);
            this.btnSendFile.TabIndex = 8;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnShake
            // 
            this.btnShake.Location = new System.Drawing.Point(243, 407);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(100, 23);
            this.btnShake.TabIndex = 9;
            this.btnShake.Text = "震动";
            this.btnShake.UseVisualStyleBackColor = true;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(70, 407);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 443);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Sendtxt);
            this.Controls.Add(this.Receivetxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Dktxt);
            this.Controls.Add(this.Iptxt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Iptxt;
        private System.Windows.Forms.TextBox Dktxt;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox Receivetxt;
        private System.Windows.Forms.RichTextBox Sendtxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.Button btnSend;
    }
}

