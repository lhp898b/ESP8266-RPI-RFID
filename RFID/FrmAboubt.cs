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
    public partial class FrmAboubt : Form
    {
        int x = 18;
        int y = 237;
        public FrmAboubt()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y++;
            if (y == (this.Height - 130))//当出了窗体的下边框后
            {
                y = 237;//横坐标定位到窗体左边框
            }
            label1.Location = new Point(x, y);
        }

        private void FrmAboubt_Load(object sender, EventArgs e)
        {

        }
    }
}
