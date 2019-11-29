namespace RFID
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usertextBox = new System.Windows.Forms.TextBox();
            this.textBoxpwd = new System.Windows.Forms.TextBox();
            this.labelclose = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_text = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // usertextBox
            // 
            this.usertextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usertextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertextBox.Font = new System.Drawing.Font("宋体", 25F);
            this.usertextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usertextBox.Location = new System.Drawing.Point(317, 328);
            this.usertextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usertextBox.Name = "usertextBox";
            this.usertextBox.Size = new System.Drawing.Size(308, 48);
            this.usertextBox.TabIndex = 0;
            // 
            // textBoxpwd
            // 
            this.textBoxpwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpwd.Font = new System.Drawing.Font("宋体", 25F);
            this.textBoxpwd.Location = new System.Drawing.Point(317, 402);
            this.textBoxpwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxpwd.Name = "textBoxpwd";
            this.textBoxpwd.PasswordChar = '*';
            this.textBoxpwd.Size = new System.Drawing.Size(308, 48);
            this.textBoxpwd.TabIndex = 1;
            // 
            // labelclose
            // 
            this.labelclose.AutoSize = true;
            this.labelclose.BackColor = System.Drawing.Color.Transparent;
            this.labelclose.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelclose.ForeColor = System.Drawing.Color.Red;
            this.labelclose.Location = new System.Drawing.Point(799, -6);
            this.labelclose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelclose.Name = "labelclose";
            this.labelclose.Size = new System.Drawing.Size(59, 58);
            this.labelclose.TabIndex = 2;
            this.labelclose.Text = "×";
            this.labelclose.Click += new System.EventHandler(this.labelclose_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.LightGray;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginbutton.Location = new System.Drawing.Point(317, 494);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(256, 55);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "登录";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(231, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(231, 416);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "密码:";
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_text.ForeColor = System.Drawing.Color.Black;
            this.lb_text.Location = new System.Drawing.Point(312, 211);
            this.lb_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(253, 30);
            this.lb_text.TabIndex = 11;
            this.lb_text.Text = "皇冠集团有限公司";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(283, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "员工考勤管理系统";
            // 
            // picture_logo
            // 
            this.picture_logo.BackColor = System.Drawing.Color.White;
            this.picture_logo.Image = ((System.Drawing.Image)(resources.GetObject("picture_logo.Image")));
            this.picture_logo.Location = new System.Drawing.Point(347, 15);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(4);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(195, 192);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_logo.TabIndex = 8;
            this.picture_logo.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(853, 585);
            this.Controls.Add(this.textBoxpwd);
            this.Controls.Add(this.usertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_logo);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.labelclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(853, 585);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(853, 585);
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usertextBox;
        private System.Windows.Forms.TextBox textBoxpwd;
        private System.Windows.Forms.Label labelclose;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.PictureBox picture_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label label3;
    }
}

