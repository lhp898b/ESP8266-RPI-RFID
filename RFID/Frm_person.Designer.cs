namespace RFID
{
    partial class Frn_person
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frn_person));
            this.rdstatus = new System.Windows.Forms.Label();
            this.textRFID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textrdSex = new System.Windows.Forms.TextBox();
            this.textrdName = new System.Windows.Forms.TextBox();
            this.textrdID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_leave = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rdstatus
            // 
            this.rdstatus.AutoSize = true;
            this.rdstatus.Location = new System.Drawing.Point(108, 395);
            this.rdstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rdstatus.Name = "rdstatus";
            this.rdstatus.Size = new System.Drawing.Size(0, 15);
            this.rdstatus.TabIndex = 50;
            // 
            // textRFID
            // 
            this.textRFID.BackColor = System.Drawing.Color.LavenderBlush;
            this.textRFID.Enabled = false;
            this.textRFID.Location = new System.Drawing.Point(112, 262);
            this.textRFID.Margin = new System.Windows.Forms.Padding(4);
            this.textRFID.Name = "textRFID";
            this.textRFID.ReadOnly = true;
            this.textRFID.Size = new System.Drawing.Size(148, 25);
            this.textRFID.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "卡    号:";
            // 
            // textrdSex
            // 
            this.textrdSex.BackColor = System.Drawing.Color.LavenderBlush;
            this.textrdSex.Enabled = false;
            this.textrdSex.Location = new System.Drawing.Point(112, 348);
            this.textrdSex.Margin = new System.Windows.Forms.Padding(4);
            this.textrdSex.Name = "textrdSex";
            this.textrdSex.ReadOnly = true;
            this.textrdSex.Size = new System.Drawing.Size(148, 25);
            this.textrdSex.TabIndex = 47;
            // 
            // textrdName
            // 
            this.textrdName.BackColor = System.Drawing.Color.LavenderBlush;
            this.textrdName.Enabled = false;
            this.textrdName.Location = new System.Drawing.Point(112, 305);
            this.textrdName.Margin = new System.Windows.Forms.Padding(4);
            this.textrdName.Name = "textrdName";
            this.textrdName.ReadOnly = true;
            this.textrdName.Size = new System.Drawing.Size(148, 25);
            this.textrdName.TabIndex = 46;
            // 
            // textrdID
            // 
            this.textrdID.BackColor = System.Drawing.Color.LavenderBlush;
            this.textrdID.Enabled = false;
            this.textrdID.Location = new System.Drawing.Point(112, 222);
            this.textrdID.Margin = new System.Windows.Forms.Padding(4);
            this.textrdID.Name = "textrdID";
            this.textrdID.ReadOnly = true;
            this.textrdID.Size = new System.Drawing.Size(148, 25);
            this.textrdID.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "当前状态:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "姓    名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "工    号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "性    别:";
            // 
            // btn_leave
            // 
            this.btn_leave.Location = new System.Drawing.Point(47, 448);
            this.btn_leave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_leave.Name = "btn_leave";
            this.btn_leave.Size = new System.Drawing.Size(100, 29);
            this.btn_leave.TabIndex = 51;
            this.btn_leave.Text = "请假";
            this.btn_leave.UseVisualStyleBackColor = true;
            this.btn_leave.Click += new System.EventHandler(this.btn_leave_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(111, 509);
            this.btn_history.Margin = new System.Windows.Forms.Padding(4);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(117, 29);
            this.btn_history.TabIndex = 52;
            this.btn_history.Text = "查看考勤历史";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(181, 448);
            this.btn_out.Margin = new System.Windows.Forms.Padding(4);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(100, 29);
            this.btn_out.TabIndex = 53;
            this.btn_out.Text = "外勤";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(111, 41);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(149, 158);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 44;
            this.pictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frn_person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_leave);
            this.Controls.Add(this.rdstatus);
            this.Controls.Add(this.textRFID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textrdSex);
            this.Controls.Add(this.textrdName);
            this.Controls.Add(this.textrdID);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frn_person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.Frn_person_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rdstatus;
        private System.Windows.Forms.TextBox textRFID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textrdSex;
        private System.Windows.Forms.TextBox textrdName;
        private System.Windows.Forms.TextBox textrdID;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_leave;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}