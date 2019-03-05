using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch02_07
{
    public partial class Form1 : Form
    {
        int ImgCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picImg.Image = (Image)imgList.Images[0];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ImgCount++;
            if (ImgCount >= imgList.Images.Count)
                ImgCount = 0;
            picImg.Image = (Image)imgList.Images[ImgCount];
        }
    }
}
