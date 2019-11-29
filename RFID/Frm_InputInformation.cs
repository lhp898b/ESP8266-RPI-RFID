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
using System.Configuration;

namespace RFID
{
    public partial class Frm_InputInformation : Form
    {
        public Frm_InputInformation()
        {
            InitializeComponent();
        }


        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_entering_Click(object sender, EventArgs e)
        {

            string xuehao;
            string kahao;
            string name;
            string sex;
            string bumen;
            xuehao = txtID.Text.Trim();
            kahao = txtnumber.Text.Trim();
            name = txtname.Text.Trim();
            sex = cmbsex.Text.Trim();
            bumen = cmb_bumen.Text.Trim();
            int flg = 0;

            if (xuehao=="" || kahao=="" || name =="" || sex ==""||bumen=="")
            {
                flg = 0;
            }
            else {
                flg = 1;

                //添加数据
                DataSet ds = new DataSet();
                string sqltext5 = string.Format("INSERT INTO rfesp( WORKERID, RFIDNUM, WORKERNAME, SEX,BUMEN,FLAG ) VALUES ('{0}','{1}','{2}','{3}','{4}',{5})", xuehao, kahao, name, sex, bumen,1);
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext5, null);
            }

            //提示信息
            if (flg == 0) {
                lbl_note.Text= "添加失败！";
            }
            else {
                lbl_note.Text= "添加成功!";
            }
            
            //加载信息
            string sqltext1 = "select RFIDNUM,WORKERNAME,WORKERID,SEX,BUMEN from rfesp";
            SELECT.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
        }

        private void Frm_InputInformation_Load(object sender, EventArgs e)
        {
            //加载数据库信息
            string sqltext1 = "select RFIDNUM,WORKERNAME,WORKERID,SEX,BUMEN from rfesp";
            SELECT.DataSource = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext1, null).Tables[0].DefaultView;
        }
    }
}
