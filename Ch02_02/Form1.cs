using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch02_02
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb;
        MessageBoxIcon mbi;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOk.Checked == true)
                mbb = MessageBoxButtons.OK;
            else if (this.rbOkCancel.Checked == true)
                mbb = MessageBoxButtons.OKCancel;
            else if (this.rbYesNo.Checked == true)
                mbb = MessageBoxButtons.YesNo;

            if (this.rbError.Checked == true)
                mbi = MessageBoxIcon.Error;
            else if (this.rbInformation.Checked == true)
                mbi = MessageBoxIcon.Information;
            else if (this.rbQuestion.Checked == true)
                mbi = MessageBoxIcon.Question;

            MessageBox.Show("메시지 박스를 확인하세요.", "알림", mbb, mbi);
        }
    }
}
