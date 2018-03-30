namespace WindowsFormsApplication2
{
    partial class Frm_SearchByZymc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SearchByZymc));
            this.searchByZymcTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.searchByZymcTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jxcDataSet = new WindowsFormsApplication2.JxcDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchByZymcTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillByZymcToolStrip = new System.Windows.Forms.ToolStrip();
            this.专业名称ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.专业名称ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByZymcToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchByZymcTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchByZymcTableTableAdapter = new WindowsFormsApplication2.JxcDataSetTableAdapters.SearchByZymcTableTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.searchByZymcTableBindingNavigator)).BeginInit();
            this.searchByZymcTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByZymcTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jxcDataSet)).BeginInit();
            this.fillByZymcToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByZymcTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchByZymcTableBindingNavigator
            // 
            this.searchByZymcTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.searchByZymcTableBindingNavigator.BindingSource = this.searchByZymcTableBindingSource;
            this.searchByZymcTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.searchByZymcTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.searchByZymcTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.searchByZymcTableBindingNavigatorSaveItem});
            this.searchByZymcTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.searchByZymcTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.searchByZymcTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.searchByZymcTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.searchByZymcTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.searchByZymcTableBindingNavigator.Name = "searchByZymcTableBindingNavigator";
            this.searchByZymcTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.searchByZymcTableBindingNavigator.Size = new System.Drawing.Size(639, 25);
            this.searchByZymcTableBindingNavigator.TabIndex = 0;
            this.searchByZymcTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // searchByZymcTableBindingSource
            // 
            this.searchByZymcTableBindingSource.DataMember = "SearchByZymcTable";
            this.searchByZymcTableBindingSource.DataSource = this.jxcDataSet;
            // 
            // jxcDataSet
            // 
            this.jxcDataSet.DataSetName = "JxcDataSet";
            this.jxcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // searchByZymcTableBindingNavigatorSaveItem
            // 
            this.searchByZymcTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchByZymcTableBindingNavigatorSaveItem.Enabled = false;
            this.searchByZymcTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("searchByZymcTableBindingNavigatorSaveItem.Image")));
            this.searchByZymcTableBindingNavigatorSaveItem.Name = "searchByZymcTableBindingNavigatorSaveItem";
            this.searchByZymcTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.searchByZymcTableBindingNavigatorSaveItem.Text = "保存数据";
            // 
            // fillByZymcToolStrip
            // 
            this.fillByZymcToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.专业名称ToolStripLabel,
            this.专业名称ToolStripTextBox,
            this.fillByZymcToolStripButton});
            this.fillByZymcToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByZymcToolStrip.Name = "fillByZymcToolStrip";
            this.fillByZymcToolStrip.Size = new System.Drawing.Size(639, 25);
            this.fillByZymcToolStrip.TabIndex = 1;
            this.fillByZymcToolStrip.Text = "fillByZymcToolStrip";
            // 
            // 专业名称ToolStripLabel
            // 
            this.专业名称ToolStripLabel.Name = "专业名称ToolStripLabel";
            this.专业名称ToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.专业名称ToolStripLabel.Text = "专业名称:";
            // 
            // 专业名称ToolStripTextBox
            // 
            this.专业名称ToolStripTextBox.Name = "专业名称ToolStripTextBox";
            this.专业名称ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByZymcToolStripButton
            // 
            this.fillByZymcToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByZymcToolStripButton.Name = "fillByZymcToolStripButton";
            this.fillByZymcToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.fillByZymcToolStripButton.Text = "查询";
            this.fillByZymcToolStripButton.Click += new System.EventHandler(this.fillByZymcToolStripButton_Click);
            // 
            // searchByZymcTableDataGridView
            // 
            this.searchByZymcTableDataGridView.AutoGenerateColumns = false;
            this.searchByZymcTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchByZymcTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.searchByZymcTableDataGridView.DataSource = this.searchByZymcTableBindingSource;
            this.searchByZymcTableDataGridView.Location = new System.Drawing.Point(0, 69);
            this.searchByZymcTableDataGridView.Name = "searchByZymcTableDataGridView";
            this.searchByZymcTableDataGridView.ReadOnly = true;
            this.searchByZymcTableDataGridView.RowTemplate.Height = 23;
            this.searchByZymcTableDataGridView.Size = new System.Drawing.Size(543, 220);
            this.searchByZymcTableDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xm";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "xb";
            this.dataGridViewTextBoxColumn3.HeaderText = "性别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "hfms";
            this.dataGridViewTextBoxColumn4.HeaderText = "婚否";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn5.HeaderText = "名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // searchByZymcTableTableAdapter
            // 
            this.searchByZymcTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.t_bmTableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.t_zyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Frm_SearchByZymc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 343);
            this.Controls.Add(this.searchByZymcTableDataGridView);
            this.Controls.Add(this.fillByZymcToolStrip);
            this.Controls.Add(this.searchByZymcTableBindingNavigator);
            this.Name = "Frm_SearchByZymc";
            this.Text = "Frm_SearchByZymc";
            this.Load += new System.EventHandler(this.Frm_SearchByZymc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchByZymcTableBindingNavigator)).EndInit();
            this.searchByZymcTableBindingNavigator.ResumeLayout(false);
            this.searchByZymcTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByZymcTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jxcDataSet)).EndInit();
            this.fillByZymcToolStrip.ResumeLayout(false);
            this.fillByZymcToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByZymcTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JxcDataSet jxcDataSet;
        private System.Windows.Forms.BindingSource searchByZymcTableBindingSource;
        private WindowsFormsApplication2.JxcDataSetTableAdapters.SearchByZymcTableTableAdapter searchByZymcTableTableAdapter;
        private WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator searchByZymcTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton searchByZymcTableBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillByZymcToolStrip;
        private System.Windows.Forms.ToolStripLabel 专业名称ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox 专业名称ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByZymcToolStripButton;
        private System.Windows.Forms.DataGridView searchByZymcTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}