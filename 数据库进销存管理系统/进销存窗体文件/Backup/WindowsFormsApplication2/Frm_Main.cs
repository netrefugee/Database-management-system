using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MnuTc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult key = MessageBox.Show("确定要关闭窗体吗？", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (key == DialogResult.No);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void MnuZg_Click(object sender, EventArgs e)
        {
            frm_zgInfo fm = new frm_zgInfo();
            fm.Show();
        }

        private void MnuSp_Click(object sender, EventArgs e)
        {
            FrmJH fm = new FrmJH();
            fm.Show();
        }
    }
}
