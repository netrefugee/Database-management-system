namespace WindowsFormsApplication2
{
    partial class FrmCX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCX));
            this.jhdDataSet = new WindowsFormsApplication2.jhdDataSet();
            this.v_jhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_jhdTableAdapter = new WindowsFormsApplication2.jhdDataSetTableAdapters.v_jhdTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.jhdDataSetTableAdapters.TableAdapterManager();
            this.v_jhdBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.v_jhdBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_jhmxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_jhmxTableAdapter = new WindowsFormsApplication2.jhdDataSetTableAdapters.t_jhmxTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGys = new System.Windows.Forms.ComboBox();
            this.cbJhr = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.PnlUp = new System.Windows.Forms.Panel();
            this.GrpJhd = new System.Windows.Forms.GroupBox();
            this.p_jhdDataGridView = new System.Windows.Forms.DataGridView();
            this.p_jhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRqbx = new System.Windows.Forms.CheckBox();
            this.p_jhdTableAdapter = new WindowsFormsApplication2.jhdDataSetTableAdapters.p_jhdTableAdapter();
            this.bh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jhdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_jhdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_jhdBindingNavigator)).BeginInit();
            this.v_jhdBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_jhmxBindingSource)).BeginInit();
            this.PnlUp.SuspendLayout();
            this.GrpJhd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jhdDataSet
            // 
            this.jhdDataSet.DataSetName = "jhdDataSet";
            this.jhdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_jhdBindingSource
            // 
            this.v_jhdBindingSource.DataMember = "v_jhd";
            this.v_jhdBindingSource.DataSource = this.jhdDataSet;
            // 
            // v_jhdTableAdapter
            // 
            this.v_jhdTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.t_khgysTableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.jhdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_jhdBindingNavigator
            // 
            this.v_jhdBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.v_jhdBindingNavigator.BindingSource = this.v_jhdBindingSource;
            this.v_jhdBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.v_jhdBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.v_jhdBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.v_jhdBindingNavigatorSaveItem});
            this.v_jhdBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.v_jhdBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.v_jhdBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.v_jhdBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.v_jhdBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.v_jhdBindingNavigator.Name = "v_jhdBindingNavigator";
            this.v_jhdBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.v_jhdBindingNavigator.Size = new System.Drawing.Size(991, 27);
            this.v_jhdBindingNavigator.TabIndex = 0;
            this.v_jhdBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // v_jhdBindingNavigatorSaveItem
            // 
            this.v_jhdBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.v_jhdBindingNavigatorSaveItem.Enabled = false;
            this.v_jhdBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("v_jhdBindingNavigatorSaveItem.Image")));
            this.v_jhdBindingNavigatorSaveItem.Name = "v_jhdBindingNavigatorSaveItem";
            this.v_jhdBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.v_jhdBindingNavigatorSaveItem.Text = "保存数据";
            // 
            // t_jhmxBindingSource
            // 
            this.t_jhmxBindingSource.DataMember = "t_jhmx";
            this.t_jhmxBindingSource.DataSource = this.jhdDataSet;
            // 
            // t_jhmxTableAdapter
            // 
            this.t_jhmxTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "到：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "供应商：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "进货人：";
            // 
            // cbGys
            // 
            this.cbGys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGys.FormattingEnabled = true;
            this.cbGys.Location = new System.Drawing.Point(624, 38);
            this.cbGys.Margin = new System.Windows.Forms.Padding(4);
            this.cbGys.Name = "cbGys";
            this.cbGys.Size = new System.Drawing.Size(160, 23);
            this.cbGys.TabIndex = 12;
            // 
            // cbJhr
            // 
            this.cbJhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJhr.FormattingEnabled = true;
            this.cbJhr.Location = new System.Drawing.Point(624, 106);
            this.cbJhr.Margin = new System.Windows.Forms.Padding(4);
            this.cbJhr.Name = "cbJhr";
            this.cbJhr.Size = new System.Drawing.Size(160, 23);
            this.cbJhr.TabIndex = 13;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(816, 68);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 29);
            this.btnSelect.TabIndex = 14;
            this.btnSelect.Text = "查询(&C)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlUp
            // 
            this.PnlUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlUp.Controls.Add(this.GrpJhd);
            this.PnlUp.Controls.Add(this.btnSelect);
            this.PnlUp.Controls.Add(this.DTPTo);
            this.PnlUp.Controls.Add(this.cbJhr);
            this.PnlUp.Controls.Add(this.DTPFrom);
            this.PnlUp.Controls.Add(this.cbGys);
            this.PnlUp.Controls.Add(this.label1);
            this.PnlUp.Controls.Add(this.label4);
            this.PnlUp.Controls.Add(this.label2);
            this.PnlUp.Controls.Add(this.label3);
            this.PnlUp.Controls.Add(this.cbRqbx);
            this.PnlUp.Location = new System.Drawing.Point(0, 35);
            this.PnlUp.Margin = new System.Windows.Forms.Padding(4);
            this.PnlUp.Name = "PnlUp";
            this.PnlUp.Size = new System.Drawing.Size(974, 607);
            this.PnlUp.TabIndex = 15;
            this.PnlUp.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlUp_Paint);
            // 
            // GrpJhd
            // 
            this.GrpJhd.Controls.Add(this.p_jhdDataGridView);
            this.GrpJhd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.GrpJhd.Location = new System.Drawing.Point(22, 170);
            this.GrpJhd.Margin = new System.Windows.Forms.Padding(4);
            this.GrpJhd.Name = "GrpJhd";
            this.GrpJhd.Padding = new System.Windows.Forms.Padding(4);
            this.GrpJhd.Size = new System.Drawing.Size(909, 381);
            this.GrpJhd.TabIndex = 0;
            this.GrpJhd.TabStop = false;
            this.GrpJhd.Text = "进货单（&J）";
            this.GrpJhd.Enter += new System.EventHandler(this.GrpJhd_Enter);
            // 
            // p_jhdDataGridView
            // 
            this.p_jhdDataGridView.AutoGenerateColumns = false;
            this.p_jhdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p_jhdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bh,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.p_jhdDataGridView.DataSource = this.p_jhdBindingSource;
            this.p_jhdDataGridView.Location = new System.Drawing.Point(0, 25);
            this.p_jhdDataGridView.Name = "p_jhdDataGridView";
            this.p_jhdDataGridView.RowTemplate.Height = 27;
            this.p_jhdDataGridView.Size = new System.Drawing.Size(909, 356);
            this.p_jhdDataGridView.TabIndex = 0;
            this.p_jhdDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.p_jhdDataGridView_CellContentClick);
            // 
            // p_jhdBindingSource
            // 
            this.p_jhdBindingSource.DataMember = "p_jhd";
            this.p_jhdBindingSource.DataSource = this.jhdDataSet;
            // 
            // DTPTo
            // 
            this.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTo.Location = new System.Drawing.Point(204, 118);
            this.DTPTo.Margin = new System.Windows.Forms.Padding(4);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(265, 25);
            this.DTPTo.TabIndex = 8;
            // 
            // DTPFrom
            // 
            this.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFrom.Location = new System.Drawing.Point(204, 41);
            this.DTPFrom.Margin = new System.Windows.Forms.Padding(4);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(265, 25);
            this.DTPFrom.TabIndex = 5;
            this.DTPFrom.ValueChanged += new System.EventHandler(this.DTPFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "从：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbRqbx
            // 
            this.cbRqbx.AutoSize = true;
            this.cbRqbx.Checked = true;
            this.cbRqbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRqbx.Location = new System.Drawing.Point(53, 78);
            this.cbRqbx.Margin = new System.Windows.Forms.Padding(4);
            this.cbRqbx.Name = "cbRqbx";
            this.cbRqbx.Size = new System.Drawing.Size(127, 19);
            this.cbRqbx.TabIndex = 9;
            this.cbRqbx.Text = "日期不限（&Q）";
            this.cbRqbx.UseVisualStyleBackColor = true;
            // 
            // p_jhdTableAdapter
            // 
            this.p_jhdTableAdapter.ClearBeforeFill = true;
            // 
            // bh
            // 
            this.bh.DataPropertyName = "bh";
            this.bh.HeaderText = "编号";
            this.bh.Name = "bh";
            this.bh.ReadOnly = true;
            this.bh.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gysbh";
            this.dataGridViewTextBoxColumn4.HeaderText = "供应商编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gysmc";
            this.dataGridViewTextBoxColumn5.HeaderText = "供应商名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "jhrbh";
            this.dataGridViewTextBoxColumn6.HeaderText = "进货人编号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "jhrxm";
            this.dataGridViewTextBoxColumn7.HeaderText = "进货人名称";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "je";
            this.dataGridViewTextBoxColumn8.HeaderText = "金额";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // FrmCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 658);
            this.Controls.Add(this.PnlUp);
            this.Controls.Add(this.v_jhdBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCX";
            this.Text = "进货查询统计";
            this.Load += new System.EventHandler(this.FrmJhcx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jhdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_jhdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_jhdBindingNavigator)).EndInit();
            this.v_jhdBindingNavigator.ResumeLayout(false);
            this.v_jhdBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_jhmxBindingSource)).EndInit();
            this.PnlUp.ResumeLayout(false);
            this.PnlUp.PerformLayout();
            this.GrpJhd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private jhdDataSet jhdDataSet;
        private System.Windows.Forms.BindingSource v_jhdBindingSource;
        private jhdDataSetTableAdapters.v_jhdTableAdapter v_jhdTableAdapter;
        private jhdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator v_jhdBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton v_jhdBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource t_jhmxBindingSource;
        private jhdDataSetTableAdapters.t_jhmxTableAdapter t_jhmxTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGys;
        private System.Windows.Forms.ComboBox cbJhr;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel PnlUp;
        private System.Windows.Forms.GroupBox GrpJhd;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRqbx;
        private System.Windows.Forms.BindingSource p_jhdBindingSource;
        private jhdDataSetTableAdapters.p_jhdTableAdapter p_jhdTableAdapter;
        private System.Windows.Forms.DataGridView p_jhdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}