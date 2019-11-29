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
    public partial class Frm_emergency : Form
    {
        public Frm_emergency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = txt_number.Text.Trim();

            if (a == "") {
                MessageBox.Show("请输入工号！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                long b = Convert.ToInt64(txt_number.Text.Trim());
                DataSet ds = new DataSet();
                string sqltext1 = string.Format("SELECT flaglist.FLAG,rfesp.WORKERID,rfesp.WORKERNAME,rfesp.SEX,rfesp.BUMEN FROM rfesp INNER JOIN flaglist ON rfesp.FLAG = flaglist.FLAGID WHERE rfesp.WORKERID = {0}", b);
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null);

                string WORKERID = ds.Tables[0].Rows[0]["WORKERID"].ToString();
                string WORKERNAME = ds.Tables[0].Rows[0]["WORKERNAME"].ToString();
                string Sex = ds.Tables[0].Rows[0]["SEX"].ToString();
                string Flag = ds.Tables[0].Rows[0]["FLAG"].ToString();
                string department = ds.Tables[0].Rows[0]["BUMEN"].ToString();

                string msg = "";
                msg = msg + String.Format("工号：{0},姓名：{1},性别：{2},出勤状况：{3},部门：{4}", WORKERID, WORKERNAME, Sex, Flag,department);

                //MessageBox.Show(msg,"查找结果",MessageBoxButtons.OKCancel);
                if (MessageBox.Show(msg, "查找结果", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string sqltext2 = string.Format(" UPDATE `rfidesp`.`rfesp` SET `FLAG` = 2,QD=now() WHERE `WORKERID` = {0}", b);
                    MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext2, null);
                    MessageBox.Show("签到完成", "签到", MessageBoxButtons.OK);
                }
                txt_number.Text = "";
            }
        }

    }
}
