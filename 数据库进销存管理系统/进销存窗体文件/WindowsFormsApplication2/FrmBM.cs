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
    public partial class FrmBM : Form
    {
        public FrmBM()
        {
            InitializeComponent();
        }

        private void t_bmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要修改吗？","提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("保存成功");
                this.Validate();
                this.t_bmBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.jxcDataSet);
            }
            else{
                MessageBox.Show("取消保存！");
            }
        }

        private void FrmBM_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jxcDataSet.t_zg”中。您可以根据需要移动或删除它。
            this.t_zgTableAdapter.Fill(this.jxcDataSet.t_zg);
            // TODO: 这行代码将数据加载到表“jxcDataSet.t_bm”中。您可以根据需要移动或删除它。
            this.t_bmTableAdapter.Fill(this.jxcDataSet.t_bm);

        }

        private void t_bmDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
