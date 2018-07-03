namespace 客户端4
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
            this.Sendtxt = new System.Windows.Forms.TextBox();
            this.Receivetxt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sendtxt
            // 
            this.Sendtxt.Location = new System.Drawing.Point(29, 211);
            this.Sendtxt.Multiline = true;
            this.Sendtxt.Name = "Sendtxt";
            this.Sendtxt.Size = new System.Drawing.Size(486, 130);
            this.Sendtxt.TabIndex = 14;
            // 
            // Receivetxt
            // 
            this.Receivetxt.Location = new System.Drawing.Point(29, 65);
            this.Receivetxt.Multiline = true;
            this.Receivetxt.Name = "Receivetxt";
            this.Receivetxt.Size = new System.Drawing.Size(486, 130);
            this.Receivetxt.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 21);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "50000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 21);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "172.17.0.41";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(415, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 24);
            this.button5.TabIndex = 21;
            this.button5.Text = "发送消息";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 394);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sendtxt);
            this.Controls.Add(this.Receivetxt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Sendtxt;
        private System.Windows.Forms.TextBox Receivetxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}

