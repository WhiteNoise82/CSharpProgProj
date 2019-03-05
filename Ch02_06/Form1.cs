using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhiteNoise.MsgBox;

namespace Ch02_06
{
    public partial class Form1 : Form
    {
        string strName, strAge, strWork;

        private void lvView_Click(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count == 0)
                MessageBox.Show("아이템을 선택하세요", "알림", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("이름 : " + lvView.SelectedItems[0].SubItems[0].Text +
                    "\n나이 : " + lvView.SelectedItems[0].SubItems[1].Text +
                    "\n직업 : " + lvView.SelectedItems[0].SubItems[2].Text,
                    "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txt.TextCheck(txtName, txtAge, txtWork) == true)
            {
                strName = txtName.Text;
                txtName.Text = "";
            
                strAge = txtAge.Text;
                txtAge.Text = "";
          
                strWork = txtWork.Text;
                txtWork.Text = "";
            }
            else return;
            ListViewItem lvi = 
                new ListViewItem(new string[] { strName, strAge, strWork });
            lvView.Items.Add(lvi);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
