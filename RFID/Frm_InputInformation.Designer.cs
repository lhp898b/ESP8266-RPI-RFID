namespace RFID
{
    partial class Frm_InputInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InputInformation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbl_note = new System.Windows.Forms.Label();
            this.btn_entering = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.SELECT = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_bumen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SELECT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "卡号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(61, 28);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(172, 25);
            this.txtID.TabIndex = 5;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(305, 28);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(218, 25);
            this.txtnumber.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(61, 62);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(172, 25);
            this.txtname.TabIndex = 7;
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_note.Location = new System.Drawing.Point(17, 122);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(67, 15);
            this.lbl_note.TabIndex = 10;
            this.lbl_note.Text = "提示信息";
            // 
            // btn_entering
            // 
            this.btn_entering.Location = new System.Drawing.Point(86, 150);
            this.btn_entering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_entering.Name = "btn_entering";
            this.btn_entering.Size = new System.Drawing.Size(100, 42);
            this.btn_entering.TabIndex = 11;
            this.btn_entering.Text = "添加";
            this.btn_entering.UseVisualStyleBackColor = true;
            this.btn_entering.Click += new System.EventHandler(this.btn_entering_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(352, 151);
            this.btn_return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(100, 42);
            this.btn_return.TabIndex = 12;
            this.btn_return.Text = "返回";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbsex.Location = new System.Drawing.Point(305, 65);
            this.cmbsex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(77, 23);
            this.cmbsex.TabIndex = 14;
            // 
            // SELECT
            // 
            this.SELECT.AllowUserToAddRows = false;
            this.SELECT.AllowUserToDeleteRows = false;
            this.SELECT.AllowUserToResizeRows = false;
            this.SELECT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SELECT.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.SELECT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SELECT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SELECT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.卡号,
            this.姓名,
            this.性别,
            this.部门});
            this.SELECT.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SELECT.Location = new System.Drawing.Point(20, 199);
            this.SELECT.Margin = new System.Windows.Forms.Padding(4);
            this.SELECT.MultiSelect = false;
            this.SELECT.Name = "SELECT";
            this.SELECT.ReadOnly = true;
            this.SELECT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SELECT.RowHeadersVisible = false;
            this.SELECT.RowTemplate.Height = 23;
            this.SELECT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SELECT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SELECT.ShowRowErrors = false;
            this.SELECT.Size = new System.Drawing.Size(503, 300);
            this.SELECT.TabIndex = 30;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "WORKERID";
            this.学号.FillWeight = 88.86205F;
            this.学号.HeaderText = "工号";
            this.学号.Name = "学号";
            this.学号.ReadOnly = true;
            // 
            // 卡号
            // 
            this.卡号.DataPropertyName = "RFIDNUM";
            this.卡号.FillWeight = 134.9958F;
            this.卡号.HeaderText = "卡号";
            this.卡号.Name = "卡号";
            this.卡号.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "WORKERNAME";
            this.姓名.FillWeight = 76.14214F;
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 性别
            // 
            this.性别.DataPropertyName = "SEX";
            this.性别.HeaderText = "性别";
            this.性别.Name = "性别";
            this.性别.ReadOnly = true;
            // 
            // 部门
            // 
            this.部门.DataPropertyName = "BUMEN";
            this.部门.HeaderText = "部门";
            this.部门.Name = "部门";
            this.部门.ReadOnly = true;
            // 
            // cmb_bumen
            // 
            this.cmb_bumen.FormattingEnabled = true;
            this.cmb_bumen.Items.AddRange(new object[] {
            "企划部",
            "财务部",
            "人事部",
            "营销部",
            "技术部",
            "采购部"});
            this.cmb_bumen.Location = new System.Drawing.Point(446, 64);
            this.cmb_bumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_bumen.Name = "cmb_bumen";
            this.cmb_bumen.Size = new System.Drawing.Size(77, 23);
            this.cmb_bumen.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "部门：";
            // 
            // Frm_InputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(535, 519);
            this.Controls.Add(this.cmb_bumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SELECT);
            this.Controls.Add(this.cmbsex);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_entering);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(553, 566);
            this.MinimumSize = new System.Drawing.Size(553, 566);
            this.Name = "Frm_InputInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息录入";
            this.Load += new System.EventHandler(this.Frm_InputInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SELECT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Button btn_entering;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.DataGridView SELECT;
        private System.Windows.Forms.ComboBox cmb_bumen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
    }
}