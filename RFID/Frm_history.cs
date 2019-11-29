using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RFID
{
    public partial class Frm_history : Form
    {
        public Frm_history()
        {
            InitializeComponent();
        }

        public string qq;
        private void Frm_history_Load(object sender, EventArgs e)
        {
            string sqltext3;
            DataSet ds = new DataSet();
            sqltext3 = string.Format("SELECT RFIDNUM,WORKERID,WORKERNAME,SEX FROM rfesp where WORKERID={0}", qq);
            ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext3, null);
            textrdID.Text = ds.Tables[0].Rows[0]["WORKERID"].ToString();
            textRFID.Text = ds.Tables[0].Rows[0]["RFIDNUM"].ToString();
            textrdName.Text = ds.Tables[0].Rows[0]["WORKERNAME"].ToString();
            textrdSex.Text = ds.Tables[0].Rows[0]["SEX"].ToString();
            pictureBox.Image = Image.FromFile(string.Format(Application.StartupPath + "\\image\\{0}.jpg", qq));
            label7.Text= ds.Tables[0].Rows[0]["WORKERNAME"].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sqltext1;
            sqltext1 = string.Format("SELECT historylist.DATE,historylist.WORKTIME,flag.Flag FROM flag INNER JOIN historylist ON historylist.FLAG = flag.Flagid WHERE historylist.WORKERID = {0}", qq);
            dgvReader.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
            
            //满勤率
            string sqltext2 = string.Format("SELECT COUNT(*) as count FROM historylist WHERE WORKERID={0}",qq);
            DataSet dataSet = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext2, null);
            float count = int.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString());

            string sqltext3 = string.Format("SELECT COUNT(historylist.FLAG) as count FROM historylist WHERE historylist.WORKERID={0} and historylist.FLAG =3 or historylist.WORKERID={1} AND historylist.FLAG =5 ", qq,qq);
            DataSet dateSet = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext3, null);
            float chuqin = int.Parse(dateSet.Tables[0].Rows[0].ItemArray[0].ToString());
            //float chuqin = int.Parse(MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "SELECT COUNT(historylist.FLAG) as count FROM historylist WHERE historylist.WORKERID={0} AND historylist.FLAG =3 or historylist.FLAG =4", qq).Tables[0].Rows[0].ItemArray[0].ToString());
            label8.Text =  (chuqin / count * 100).ToString() + "%";
        }
    }
}
