namespace RFID
{
    partial class FrmAboubt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAboubt));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_about = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picture_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "皇冠集团有限公司员工考勤管理系统\r\n\r\nVersion:1.0\r\n\r\n版权：(C)2019 software  corporation\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_about
            // 
            this.lb_about.AutoSize = true;
            this.lb_about.Location = new System.Drawing.Point(39, 36);
            this.lb_about.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_about.Name = "lb_about";
            this.lb_about.Size = new System.Drawing.Size(0, 15);
            this.lb_about.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picture_logo
            // 
            this.picture_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_logo.Image = global::RFID.Properties.Resources.hg;
            this.picture_logo.Location = new System.Drawing.Point(47, 36);
            this.picture_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(253, 249);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_logo.TabIndex = 5;
            this.picture_logo.TabStop = false;
            this.picture_logo.UseWaitCursor = true;
            // 
            // FrmAboubt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(357, 620);
            this.Controls.Add(this.picture_logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_about);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAboubt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于本软件";
            this.Load += new System.EventHandler(this.FrmAboubt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_about;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picture_logo;
    }
}