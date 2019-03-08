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
    public partial class Form2 : Form
    {
        private double o = 0.0;

        public string SetText
        {
            set { Text = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (o < 100.0)
            {
                o = o + 3.6;
                float c = Convert.ToSingle(o);
                float f = c / 100;
                Opacity = f;
            }
            else
            {
                Opacity = Convert.ToSingle(100 / 100);
                o = 0.0;
                Timer.Enabled = false;
            }
        }
    }
}
