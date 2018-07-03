namespace 分页
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
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.btnShou = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.lbNum = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToDeleteRows = false;
            this.dgvUserInfo.AllowUserToResizeColumns = false;
            this.dgvUserInfo.AllowUserToResizeRows = false;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvUserInfo.Location = new System.Drawing.Point(22, 12);
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            this.dgvUserInfo.RowHeadersVisible = false;
            this.dgvUserInfo.RowTemplate.Height = 23;
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(444, 190);
            this.dgvUserInfo.TabIndex = 0;
            // 
            // btnShou
            // 
            this.btnShou.Location = new System.Drawing.Point(33, 247);
            this.btnShou.Name = "btnShou";
            this.btnShou.Size = new System.Drawing.Size(75, 23);
            this.btnShou.TabIndex = 1;
            this.btnShou.Text = "首页";
            this.btnShou.UseVisualStyleBackColor = true;
            this.btnShou.Click += new System.EventHandler(this.btnShou_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(149, 247);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 1;
            this.btnS.Text = "上一页";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(265, 247);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "下一页";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(381, 247);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 23);
            this.btnW.TabIndex = 1;
            this.btnW.Text = "尾页";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(193, 215);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(0, 12);
            this.lbNum.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserName";
            this.Column1.HeaderText = "用户名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UserPwd";
            this.Column2.HeaderText = "密码";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 283);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnShou);
            this.Controls.Add(this.dgvUserInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.Button btnShou;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

