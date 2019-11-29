namespace RFID
{
    partial class Frm_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_history));
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.rdstatus = new System.Windows.Forms.Label();
            this.textRFID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textrdSex = new System.Windows.Forms.TextBox();
            this.textrdName = new System.Windows.Forms.TextBox();
            this.textrdID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出勤情况 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工作时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReader
            // 
            this.dgvReader.AllowUserToAddRows = false;
            this.dgvReader.AllowUserToDeleteRows = false;
            this.dgvReader.AllowUserToResizeRows = false;
            this.dgvReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReader.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvReader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日期,
            this.出勤情况,
            this.工作时间});
            this.dgvReader.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvReader.Location = new System.Drawing.Point(45, 70);
            this.dgvReader.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReader.MultiSelect = false;
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.ReadOnly = true;
            this.dgvReader.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReader.RowHeadersVisible = false;
            this.dgvReader.RowTemplate.Height = 23;
            this.dgvReader.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvReader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReader.ShowRowErrors = false;
            this.dgvReader.Size = new System.Drawing.Size(652, 444);
            this.dgvReader.TabIndex = 30;
            // 
            // rdstatus
            // 
            this.rdstatus.AutoSize = true;
            this.rdstatus.Location = new System.Drawing.Point(814, 449);
            this.rdstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rdstatus.Name = "rdstatus";
            this.rdstatus.Size = new System.Drawing.Size(0, 15);
            this.rdstatus.TabIndex = 50;
            // 
            // textRFID
            // 
            this.textRFID.BackColor = System.Drawing.Color.LavenderBlush;
            this.textRFID.Enabled = false;
            this.textRFID.Location = new System.Drawing.Point(818, 316);
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
            this.label6.Location = new System.Drawing.Point(731, 320);
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
            this.textrdSex.Location = new System.Drawing.Point(818, 401);
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
            this.textrdName.Location = new System.Drawing.Point(818, 359);
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
            this.textrdID.Location = new System.Drawing.Point(818, 276);
            this.textrdID.Margin = new System.Windows.Forms.Padding(4);
            this.textrdID.Name = "textrdID";
            this.textrdID.ReadOnly = true;
            this.textrdID.Size = new System.Drawing.Size(148, 25);
            this.textrdID.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 362);
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
            this.label2.Location = new System.Drawing.Point(731, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "工    号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 405);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "性    别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "员工姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "员工满勤率为：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "名字";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "%";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(818, 110);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(149, 158);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 44;
            this.pictureBox.TabStop = false;
            // 
            // 日期
            // 
            this.日期.DataPropertyName = "DATE";
            this.日期.FillWeight = 88.86205F;
            this.日期.HeaderText = "日期";
            this.日期.Name = "日期";
            this.日期.ReadOnly = true;
            // 
            // 出勤情况
            // 
            this.出勤情况.DataPropertyName = "FLAG";
            this.出勤情况.FillWeight = 76.14214F;
            this.出勤情况.HeaderText = "状态情况";
            this.出勤情况.Name = "出勤情况";
            this.出勤情况.ReadOnly = true;
            this.出勤情况.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 工作时间
            // 
            this.工作时间.DataPropertyName = "WORKTIME";
            this.工作时间.FillWeight = 134.9958F;
            this.工作时间.HeaderText = "工作时间";
            this.工作时间.Name = "工作时间";
            this.工作时间.ReadOnly = true;
            // 
            // Frm_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 533);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdstatus);
            this.Controls.Add(this.textRFID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textrdSex);
            this.Controls.Add(this.textrdName);
            this.Controls.Add(this.textrdID);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1046, 580);
            this.MinimumSize = new System.Drawing.Size(1046, 580);
            this.Name = "Frm_history";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工考勤历史";
            this.Load += new System.EventHandler(this.Frm_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Label rdstatus;
        private System.Windows.Forms.TextBox textRFID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textrdSex;
        private System.Windows.Forms.TextBox textrdName;
        private System.Windows.Forms.TextBox textrdID;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出勤情况;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工作时间;
    }
}