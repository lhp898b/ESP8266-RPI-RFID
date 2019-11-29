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
    public partial class Frm_Main : Form
    {



        int Aflag = 0;
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //出勤率
            string sqltext1 = "SELECT COUNT(*) as count FROM rfesp";
            DataSet dataSet = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null);
            float count = int.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString());
            float chuqing = int.Parse(MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "SELECT COUNT(rfesp.FLAG) as count FROM rfesp WHERE rfesp.FLAG =5 OR  rfesp.FLAG =2 ", null).Tables[0].Rows[0].ItemArray[0].ToString());
            lbl_data.Text = (chuqing / count * 100).ToString() + "%";


            //出勤人信息
            try
            {
                sqltext1 = "SELECT rfesp.BUMEN,rfesp.WORKERNAME,rfesp.WORKERID,flaglist.FLAG FROM rfesp INNER JOIN flaglist ON rfesp.FLAG = flaglist.FLAGID WHERE rfesp.FLAG=2 OR rfesp.FLAG=5 OR rfesp.FLAG=1 OR rfesp.FLAG=3";
                dgvReader.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;

                string sqltxt2 = "SELECT rfesp.BUMEN,rfesp.WORKERNAME,rfesp.WORKERID,flaglist.FLAG FROM rfesp INNER JOIN flaglist ON rfesp.FLAG = flaglist.FLAGID WHERE  rfesp.FLAG=4";
                dgvReader1.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltxt2, null).Tables[0].DefaultView;

                Aflag = 1;

            }
            catch (Exception)
            {
                Aflag = 0;
                throw;
            }
            if (Aflag == 0)
            {
                DatabaseStatus.Text = "数据库连接异常";
                DatabaseStatus.ForeColor = Color.Red;
            }
            else
            {
                DatabaseStatus.Text = "数据库连接正常";
                DatabaseStatus.ForeColor = Color.LimeGreen;
            }
            this.tssTime.Text = "当前时间：" + DateTime.Now.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet ds = new DataSet();
                string sqltext1 = "SELECT max(ID) FROM rfesp ";
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null);
                string maxid = ds.Tables[0].Rows[0]["max(ID)"].ToString();

                for (int i = 1; i <= int.Parse(maxid); i++)
                {
                    string sqltext2 = string.Format(" UPDATE `rfidesp`.`rfesp` SET `FLAG` = 1 WHERE `ID` = {0}", i);
                    MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext2, null);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.dgvReader.SelectedRows.Count > 0)
            {
                if (this.dgvReader.SelectedRows[0].Cells[1].Value != null)
                {
                    string sqltext3;
                    long WORKERID = Convert.ToInt64(this.dgvReader.SelectedRows[0].Cells[2].Value);
                    DataSet ds = new DataSet();
                    sqltext3 = string.Format("SELECT flaglist.FLAG,flaglist.FLAGID,rfesp.FLAG,rfesp.RFIDNUM,rfesp.WORKERID,rfesp.WORKERNAME,rfesp.SEX FROM rfesp INNER JOIN flaglist ON rfesp.FLAG = flaglist.FLAGID WHERE rfesp.WORKERID ={0}", WORKERID);
                    ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext3, null);
                    string workid = ds.Tables[0].Rows[0]["WORKERID"].ToString();
                    string rfidnumber = ds.Tables[0].Rows[0]["RFIDNUM"].ToString();
                    string workname = ds.Tables[0].Rows[0]["WORKERNAME"].ToString();
                    string sex = ds.Tables[0].Rows[0]["SEX"].ToString();
                    string flag = ds.Tables[0].Rows[0]["FLAG"].ToString();
                    // 显示窗体
                    Frn_person person = new Frn_person();
                    person.id = Convert.ToString(workid);
                    person.rfid = Convert.ToString(rfidnumber);
                    person.name = workname;
                    person.xingbie = sex;
                    person.flg = flag;
                    person.Show();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmAboubt frm = new FrmAboubt();
            frm.Show();
        }

        private void dgvReader_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvReader.ClearSelection();
        }
        //查找按钮
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string sqltext4;
            long studentnum;
            studentnum = long.Parse(WORKERIDtext.Text);
            DataSet ds = new DataSet();
            sqltext4 = string.Format("SELECT flaglist.FLAG,rfesp.RFIDNUM,rfesp.WORKERID,rfesp.WORKERNAME,rfesp.SEX FROM rfesp INNER JOIN flaglist ON rfesp.FLAG = flaglist.FLAGID WHERE rfesp.WORKERID = {0}", studentnum);
            ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext4, null);
            string workid = ds.Tables[0].Rows[0]["WORKERID"].ToString();
            string rfidnumber = ds.Tables[0].Rows[0]["RFIDNUM"].ToString();
            string workname = ds.Tables[0].Rows[0]["WORKERNAME"].ToString();
            string sex = ds.Tables[0].Rows[0]["SEX"].ToString();
            string flag = ds.Tables[0].Rows[0]["FLAG"].ToString();
            // 显示窗体
            Frn_person person = new Frn_person();
            person.id = Convert.ToString(workid);
            person.rfid = Convert.ToString(rfidnumber);
            person.name = workname;
            person.xingbie = sex;
            person.flg = flag;
            person.Show();

            //清空
            WORKERIDtext.Text = "";
        }

        //只显示一个窗体
        private Frm_InputInformation I_frm = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (I_frm == null || I_frm.IsDisposed)
            {
                I_frm = new Frm_InputInformation();
                I_frm.TopMost = true;
                I_frm.Show();
            }
        }


        private Frm_delete d_frm = null;
        private void button4_Click(object sender, EventArgs e)
        {
            if (d_frm == null || d_frm.IsDisposed)
            {
                d_frm = new Frm_delete();
                d_frm.TopMost = true;
                d_frm.Show();
            }
        }

        private FrmAboubt A_frm = null;
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (A_frm == null || A_frm.IsDisposed) //是否有释放
            {
                A_frm = new FrmAboubt();
                A_frm.TopMost = true;
                A_frm.Show();
            }
        }

        private Frm_emergency E_frm = null;
        private void button5_Click(object sender, EventArgs e)
        {
            if (E_frm == null || E_frm.IsDisposed)
            {
                E_frm = new Frm_emergency();
                E_frm.TopMost = true;
                E_frm.Show();
            }
        }

        private void dgvReader1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvReader1.SelectedRows.Count > 0)
            {
                if (this.dgvReader1.SelectedRows[0].Cells[1].Value != null)
                {
                    string sqltext3;
                    long WORKERID = Convert.ToInt64(this.dgvReader1.SelectedRows[0].Cells[2].Value);
                    DataSet ds = new DataSet();
                    sqltext3 = string.Format("SELECT flaglist.FLAG,flaglist.FLAGID,rfesp.FLAG,rfesp.RFIDNUM,rfesp.WORKERID,rfesp.WORKERNAME,rfesp.SEX FROM rfesp INNER JOIN flaglist ON rfesp.FLAG = flaglist.FLAGID WHERE rfesp.WORKERID ={0}", WORKERID);
                    ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext3, null);
                    string workid = ds.Tables[0].Rows[0]["WORKERID"].ToString();
                    string rfidnumber = ds.Tables[0].Rows[0]["RFIDNUM"].ToString();
                    string workname = ds.Tables[0].Rows[0]["WORKERNAME"].ToString();
                    string sex = ds.Tables[0].Rows[0]["SEX"].ToString();
                    string flag = ds.Tables[0].Rows[0]["FLAG"].ToString();
                    // 显示窗体
                    Frn_person person = new Frn_person();
                    person.id = Convert.ToString(workid);
                    person.rfid = Convert.ToString(rfidnumber);
                    person.name = workname;
                    person.xingbie = sex;
                    person.flg = flag;
                    person.Show();
                }
            }
        }

        private Frm_Leave F_Leave = null;
        private void button6_Click(object sender, EventArgs e)
        {
            if (F_Leave == null || F_Leave.IsDisposed)
            {
                F_Leave = new  Frm_Leave();
                F_Leave.TopMost = true;
                F_Leave.Show();
            }
        }
        private Frm_Signoff Signoff = null;
        private void button7_Click(object sender, EventArgs e)
        {
            if (Signoff == null || Signoff.IsDisposed)
            {
                Signoff = new  Frm_Signoff();
                Signoff.TopMost = true;
                Signoff.Show();
            }
        }
    }
}
