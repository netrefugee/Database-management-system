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
    public partial class frm_zgInfo : Form
    {
        public frm_zgInfo()
        {
            InitializeComponent();
        }

        private void t_zgBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_zgBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jxcDataSet);

        }

        private void Form_zgInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jxcDataSet.t_bm”中。您可以根据需要移动或移除它。
            this.t_bmTableAdapter.Fill(this.jxcDataSet.t_bm);
            // TODO: 这行代码将数据加载到表“jxcDataSet.t_zy”中。您可以根据需要移动或移除它。
            this.t_zyTableAdapter.Fill(this.jxcDataSet.t_zy);
            // TODO: 这行代码将数据加载到表“jxcDataSet.t_zg”中。您可以根据需要移动或移除它。
            this.t_zgTableAdapter.Fill(this.jxcDataSet.t_zg);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void csrqLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hfCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_SearchByZymc serarchForm = new Frm_SearchByZymc();
            serarchForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_MD fm = new Frm_MD();
            fm.Show();
        }
    }
}
