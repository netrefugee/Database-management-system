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
    public partial class FrmJH : Form
    {
        public FrmJH()
        {
            InitializeComponent();
        }

        private void FrmJH_Load(object sender, EventArgs e)
        {
             // TODO: 这行代码将数据加载到表“jhdDataSet.t_zg”中。您可以根据需要移动或移除它。
            this.t_zgTableAdapter.FillBybh(this.jhdDataSet.t_zg);
             // TODO: 这行代码将数据加载到表“jhdDataSet.t_khgys”中。您可以根据需要移动或移除它。
            this.t_khgysTableAdapter.Fill(this.jhdDataSet.t_khgys);
            // TODO: 这行代码将数据加载到表“jhdDataSet.v_jhd”中。您可以根据需要移动或移除它。
            this.v_jhdTableAdapter.Fill(this.jhdDataSet.v_jhd);

        }

        private void v_jhdDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            this.t_jhmxTableAdapter.FillByJhrqXh(this.jhdDataSet.t_jhmx, Convert.ToDateTime(v_jhdDataGridView.CurrentRow.Cells[0].Value),Convert .ToInt16 (v_jhdDataGridView .CurrentRow .Cells [1].Value ));
           
        }


        private void fillBySpbhToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void t_jhmxDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this .v_spTableAdapter .FillBySpbh (this .jhdDataSet .v_sp ,t_jhmxDataGridView .CurrentRow .Cells [0].Value .ToString ());
        }

        private void btJhdInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd=null ;
            SqlConnection  conn=new SqlConnection(DBHelper .conStr );
            try {
                if (MessageBox .Show ("确定要添加进货单？","进货",MessageBoxButtons.YesNo ,MessageBoxIcon .Question )==DialogResult .Yes ){
                    cmd = new SqlCommand("dbo.p_insjhd", conn);
                    cmd .Connection=conn;
                    cmd .CommandType=CommandType .StoredProcedure ;
                    SqlParameter sqlParme;
                    sqlParme =cmd.Parameters.Add("@gysbh",SqlDbType.Char );
                    sqlParme .Direction=ParameterDirection .Input ;
                    sqlParme .Value=cbgysbh .SelectedValue .ToString ();
                    sqlParme =cmd .Parameters.Add("@jhrbh",SqlDbType .Char);
                    sqlParme .Direction=ParameterDirection .Input ;
                    sqlParme .Value=cbjhrbh .SelectedValue .ToString ();

                    conn.Open();
                    int n=cmd .ExecuteNonQuery();
                    if (n>0){MessageBox .Show ("成功插入数据！");}
                }
            }catch (Exception ex){MessageBox .Show (ex .ToString ());}
            finally {
                if (conn !=null )conn.Close();
                if (cmd!=null )cmd .Dispose();
            }
                        
        }

        private void btJhmxInsert_Click(object sender, EventArgs e)
        {
                SqlConnection  conn=new SqlConnection(DBHelper .conStr );
                txtJhrq.Text = v_jhdDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtXh .Text =v_jhdDataGridView .CurrentRow .Cells [1].Value.ToString();
            string strSQL="insert into t_jhmx values('"+txtJhrq.Text+"','"+txtXh .Text +"','"+txtSpbh .Text ;
                                                       strSQL +="',"+Convert .ToInt16 (numJhsl .Value );
                                                       strSQL +=","+Convert .ToInt16 (txtJhdj .Text )+")";
            try {
            SqlCommand cmd=null ;
            cmd =new SqlCommand();
                cmd .Connection =conn;
                cmd .CommandText =strSQL ;
                conn.Open();
                int n =cmd.ExecuteNonQuery();
                if (n>0){
                    MessageBox .Show("成功插入数据！");
                }
                this .t_jhmxTableAdapter .FillByJhrqXh (this .jhdDataSet .t_jhmx ,Convert .ToDateTime (v_jhdDataGridView .CurrentRow .Cells [0].Value ),Convert .ToInt16 (v_jhdDataGridView .CurrentRow .Cells [1].Value ));
            }

            catch (Exception ex){MessageBox .Show (ex .ToString ());}

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtSpbh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void v_jhdDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            try
            {
                if (MessageBox.Show("确定要进货？", "入库", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("dbo.p_rk", conn);
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter sqlParme;
                    sqlParme = cmd.Parameters.Add("@jhrqtmp", SqlDbType.DateTime);
                    sqlParme.Direction = ParameterDirection.Input;
                    sqlParme.Value = Convert.ToDateTime(v_jhdDataGridView.CurrentRow.Cells[0].Value.ToString());
                    sqlParme = cmd.Parameters.Add("@xhtmp", SqlDbType.Int);
                    sqlParme.Direction = ParameterDirection.Input;
                    sqlParme.Value = Convert.ToInt16(v_jhdDataGridView.CurrentRow.Cells[1].Value.ToString());

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0) { MessageBox.Show("成功插入数据！"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                if (conn != null) conn.Close();
                if (cmd != null) cmd.Dispose();
            }
        }

        private void t_jhmxDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
