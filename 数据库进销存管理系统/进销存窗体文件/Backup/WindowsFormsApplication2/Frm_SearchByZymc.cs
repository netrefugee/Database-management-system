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
    public partial class Frm_SearchByZymc : Form
    {
        public Frm_SearchByZymc()
        {
            InitializeComponent();
        }

        private void fillByZymcToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchByZymcTableTableAdapter.FillByZymc(this.jxcDataSet.SearchByZymcTable, 专业名称ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Frm_SearchByZymc_Load(object sender, EventArgs e)
        {

        }
    }
}
