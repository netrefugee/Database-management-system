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
    public partial class Frm_MD : Form
    {
        public Frm_MD()
        {
            InitializeComponent();
        }

        private void t_zyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_zyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jxcDataSet);

        }

        private void Frm_MD_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jxcDataSet.t_zy”中。您可以根据需要移动或移除它。
            this.t_zyTableAdapter.Fill(this.jxcDataSet.t_zy);

        }

        private void t_zyDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                this.t_zg1TableAdapter.Fill(this.jxcDataSet.t_zg1, t_zyDataGridView .CurrentRow .Cells[0].Value .ToString ());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        /*private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_zg1TableAdapter.Fill(this.jxcDataSet.t_zg1, bhToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/

       
    }
}
