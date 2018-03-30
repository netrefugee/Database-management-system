using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class FrmCX : Form
    {
        public FrmCX()
        {
            InitializeComponent();
        }

        private void FrmJhcx_Load(object sender, EventArgs e)
        {   
            SqlCommand cmd = null;
            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            // TODO: 这行代码将数据加载到表“jhdDataSet.v_jhd”中。您可以根据需要移动或删除它。
            this.v_jhdTableAdapter.Fill(this.jhdDataSet.v_jhd);
            
            try {
                conn.Open();
                cbGys.Items.Add("(000000)全部");
                string sql = "SELECT'('+bh+')'+mc as bhmc FROM t_khgys Order BY bh";
                    cmd = new SqlCommand(sql,conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read()){
                   cbGys.Items.Add(Convert.ToString(dr["bhmc"]));
                }
                if(cmd != null) cmd.Dispose();
                if(dr != null) dr.Dispose();
                cbJhr.Items.Add("(0000)全部");
                string sql2 = "SELECT '('+bh+')'+xm as bhxm from t_zg  ORDER BY bh";
                cmd = new SqlCommand(sql2,conn);
                dr = cmd.ExecuteReader();
                while(dr.Read()){
                    cbJhr.Items.Add(Convert.ToString(dr["bhxm"]));
                }
                if(dr != null) dr.Dispose();
                cbGys.SelectedIndex = 0;
             
                DateTime dt = DateTime.Now;DTPFrom.Value = dt.AddMonths(-1);
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }finally{
                if(conn != null)conn.Close();
                if(cmd != null)cmd.Dispose();
            }
        }


        private void jhrqLabel_Click(object sender, EventArgs e)
        {

        }

        private void jhrqDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            string gysbh = cbGys.Text.Substring(1,6);
                string jhrbh=cbJhr.Text.Substring(1,4);
                if("000000".Equals(gysbh))gysbh="%";
                if("0000".Equals(jhrbh ))jhrbh ="%";
                if(cbRqbx.Checked){
                    this.p_jhdTableAdapter.Fill(this.jhdDataSet.p_jhd, null, null, gysbh, jhrbh);
                }

                else{
                if(Convert.ToDateTime(DTPFrom.Text)>Convert.ToDateTime(DTPTo.Text)){
                MessageBox.Show("日期范围不正确！","进货查询",MessageBoxButtons.OK,MessageBoxIcon.Error);

                
                }
                else{
                this.p_jhdTableAdapter.Fill(this.jhdDataSet.p_jhd,Convert.ToDateTime(DTPFrom.Text),Convert.ToDateTime(DTPTo.Text),gysbh,jhrbh);
                }
                }
                }
                catch(Exception ex){
                MessageBox.Show(ex.Message);
                }
            }

        private void PnlUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_jhdDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void DTPFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GrpJhd_Enter(object sender, EventArgs e)
        {

        }
    }
}
