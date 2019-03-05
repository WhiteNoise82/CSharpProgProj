using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch02_08
{
    public partial class Form1 : Form
    {
        int Num = 0;
        string OrgStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = lblStatus.Text;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Num++;
            if (Num > 100)
            {
                Timer.Enabled = false;
                return;
            }
            pbStatus.Value = Num;
            lblStatus.Text = OrgStr + Num.ToString() + "%";
        }
    }
}
