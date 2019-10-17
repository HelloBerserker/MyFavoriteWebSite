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
       public readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("lijinfeng.club,password=wsljf.");
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {               
                var db = redis.GetDatabase();
                var flag = db.StringSet("Today", this.richTextBox1.Text);
                if (flag)
                    lblMsg.Text="写入远程服务成功";
                else
                    lblMsg.Text = "写入远程服务失败";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error:" + ex.Message;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var db= redis.GetDatabase();
            string value = db.StringGet("Today");
            this.richTextBox1.Text = value;
        }
    }
}
