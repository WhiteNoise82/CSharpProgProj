using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch03_02
{
    public partial class Form3 : Form
    {
        public string SetText
        {
            set { Text = value; }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            Opacity = Convert.ToSingle(100 / 100);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Size.Width > 300 && Size.Height > 300)
            {
                Timer.Enabled = false;
            }
            else
            {
                Size += new Size(10, 10);
            }
        }
    }
}
