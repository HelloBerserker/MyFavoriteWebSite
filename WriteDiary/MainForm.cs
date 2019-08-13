using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WriteDiary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("lijinfeng.club,password=wsljf.");
                var db = redis.GetDatabase();
                var flag = db.StringSet("Today", this.richTextBox1.Text);
                if (flag)
                    MessageBox.Show("写入远程服务成功");
                else
                    MessageBox.Show("写入远程服务失败");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
