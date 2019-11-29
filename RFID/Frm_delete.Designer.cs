namespace RFID
{
    partial class Frm_delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_delete));
            this.btn_delete = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卡号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(233, 324);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 45);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // List
            // 
            this.List.AllowUserToAddRows = false;
            this.List.AllowUserToDeleteRows = false;
            this.List.AllowUserToResizeRows = false;
            this.List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.卡号,
            this.姓名,
            this.性别,
            this.部门});
            this.List.Location = new System.Drawing.Point(12, 12);
            this.List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.List.MultiSelect = false;
            this.List.Name = "List";
            this.List.ReadOnly = true;
            this.List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.List.RowHeadersVisible = false;
            this.List.RowTemplate.Height = 27;
            this.List.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List.ShowRowErrors = false;
            this.List.Size = new System.Drawing.Size(587, 294);
            this.List.TabIndex = 33;
            // 
            // 学号
            // 
            this.学号.DataPropertyName = "WORKERID";
            this.学号.HeaderText = "工号";
            this.学号.Name = "学号";
            this.学号.ReadOnly = true;
            // 
            // 卡号
            // 
            this.卡号.DataPropertyName = "RFIDNUM";
            this.卡号.HeaderText = "卡号";
            this.卡号.Name = "卡号";
            this.卡号.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "WORKERNAME";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
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
            // Frm_delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.List);
            this.Controls.Add(this.btn_delete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(630, 433);
            this.MinimumSize = new System.Drawing.Size(630, 433);
            this.Name = "Frm_delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息删除";
            this.Load += new System.EventHandler(this.Frm_delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView List;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卡号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门;
    }
}