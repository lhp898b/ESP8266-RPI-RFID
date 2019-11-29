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
    
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string username, password;
                string sqltext2;
                username = usertextBox.Text;
                password = textBoxpwd.Text;
                sqltext2 = "select password from login where user='" + username + "'";
                ds = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, sqltext2, null);
                if (ds.Tables[0].Rows.Count < 1)
                {
                    MessageBox.Show("用户名不存在");
                }
                else
                {
                    string truepwd = ds.Tables[0].Rows[0]["password"].ToString();
                    if (truepwd.CompareTo(password) == 0)
                    {
                        Frm_Main mainform = new Frm_Main();
                        this.Hide();
                        mainform.Show();
                    }
                    else
                        MessageBox.Show("密码错误");
                }
            }
           catch (Exception)
            {
                
                throw;
            }
            
        }

    }
}
