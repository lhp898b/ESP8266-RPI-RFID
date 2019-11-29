using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID
{
    public partial class Frm_delete : Form
    {   

        public Frm_delete()
        {
            InitializeComponent();
        }

        private void Frm_delete_Load(object sender, EventArgs e)
        {
        //加载数据库信息
        string sqltext1 = "select RFIDNUM,WORKERNAME,WORKERID,SEX,BUMEN from rfesp";
        List.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            if (List.SelectedRows[0].Cells[2].Value != null)
            {
                this.List.AutoGenerateColumns = false; //关闭自动创建列
                long WORKERID = Convert.ToInt64(this.List.SelectedRows[0].Cells[2].Value);
                string sqltext2 = string.Format("DELETE FROM `rfesp` WHERE WORKERID={0}", WORKERID);
                List.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext2, null);

            }
            //加载数据库信息
            string sqltext1 = "select WORKERID,RFIDNUM,WORKERNAME,SEX,BUMEN from rfesp";
            List.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
        }
    }
}
