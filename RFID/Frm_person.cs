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
    public partial class Frn_person : Form
    {
        public Frn_person()
        {
            InitializeComponent();
        }
        public string id;             
        public string rfid;
        public string name;
        public string xingbie;
        public string flg;

        private void Frn_person_Load(object sender, EventArgs e)
        {
            textrdID.Text = id;
            textRFID.Text = rfid;
            textrdName.Text = name;
            textrdSex.Text = xingbie;
            pictureBox.Image = Image.FromFile(string.Format(Application.StartupPath + "\\image\\{0}.jpg", id));
            label5.Text = flg;
            if (label5.Text == "在岗")
            {
                label5.ForeColor = Color.Lime;
            }
            else
            {
                label5.ForeColor = Color.Red;
            }
            timer1.Stop();
        }


        private Frm_history history = null;
        private void btn_history_Click(object sender, EventArgs e)
        {
            if (history == null || history.IsDisposed)
            {
                // 显示窗体
                Frm_history history = new  Frm_history();
                history.TopMost = true;
                history.qq=this.id;
                history.Show();
            }
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            string sqltext3;
            if (label5.Text!="请假")
            {
                sqltext3 = string.Format("UPDATE rfesp SET FLAG=4 WHERE WORKERID={0}",id );
                MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext3, null);
            }
            timer1.Enabled = true;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sqltext3;
            DataSet ds = new DataSet();
            sqltext3 = string.Format("SELECT flaglist.FLAG,flaglist.FLAGID,rfesp.FLAG,rfesp.RFIDNUM,rfesp.WORKERID,rfesp.WORKERNAME,rfesp.SEX FROM rfesp INNER JOIN flaglist ON rfesp.FLAG = flaglist.FLAGID WHERE rfesp.WORKERID ={0}", id);
            ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext3, null);
            textrdID.Text = ds.Tables[0].Rows[0]["WORKERID"].ToString();
            textRFID.Text = ds.Tables[0].Rows[0]["RFIDNUM"].ToString();
            textrdName.Text = ds.Tables[0].Rows[0]["WORKERNAME"].ToString();
            textrdSex.Text = ds.Tables[0].Rows[0]["SEX"].ToString();
            label5.Text = ds.Tables[0].Rows[0]["FLAG"].ToString();
            pictureBox.Image = Image.FromFile(string.Format(Application.StartupPath + "\\image\\{0}.jpg", id));
            if (label5.Text == "在岗")
            {
                label5.ForeColor = Color.Lime;
            }
            else
            {
                label5.ForeColor = Color.Red;
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            string sqltext3;
            if (label5.Text != "外勤")
            {
                sqltext3 = string.Format("UPDATE rfesp SET FLAG=5 WHERE WORKERID={0}", id);
                MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext3, null);
            }
            timer1.Enabled = true;
        }
    }
}
