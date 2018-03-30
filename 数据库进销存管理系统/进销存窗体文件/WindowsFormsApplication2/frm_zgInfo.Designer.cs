namespace WindowsFormsApplication2
{
    partial class frm_zgInfo
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
            System.Windows.Forms.Label bhLabel;
            System.Windows.Forms.Label xmLabel;
            System.Windows.Forms.Label xbLabel;
            System.Windows.Forms.Label csrqLabel;
            System.Windows.Forms.Label hfLabel;
            System.Windows.Forms.Label klLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_zgInfo));
            this.jxcDataSet = new WindowsFormsApplication2.JxcDataSet();
            this.t_zgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zgTableAdapter = new WindowsFormsApplication2.JxcDataSetTableAdapters.t_zgTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager();
            this.t_zyTableAdapter = new WindowsFormsApplication2.JxcDataSetTableAdapters.t_zyTableAdapter();
            this.t_zgBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.t_zgBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_zgDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bhTextBox = new System.Windows.Forms.TextBox();
            this.xmTextBox = new System.Windows.Forms.TextBox();
            this.xbTextBox = new System.Windows.Forms.TextBox();
            this.csrqDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hfCheckBox = new System.Windows.Forms.CheckBox();
            this.klTextBox = new System.Windows.Forms.TextBox();
            this.zgbhcomboBox = new System.Windows.Forms.ComboBox();
            this.tzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bmbhcomboBox = new System.Windows.Forms.ComboBox();
            this.tbmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_bmTableAdapter = new WindowsFormsApplication2.JxcDataSetTableAdapters.t_bmTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            bhLabel = new System.Windows.Forms.Label();
            xmLabel = new System.Windows.Forms.Label();
            xbLabel = new System.Windows.Forms.Label();
            csrqLabel = new System.Windows.Forms.Label();
            hfLabel = new System.Windows.Forms.Label();
            klLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jxcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingNavigator)).BeginInit();
            this.t_zgBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bhLabel
            // 
            bhLabel.AutoSize = true;
            bhLabel.ForeColor = System.Drawing.Color.Black;
            bhLabel.Location = new System.Drawing.Point(511, 59);
            bhLabel.Name = "bhLabel";
            bhLabel.Size = new System.Drawing.Size(35, 12);
            bhLabel.TabIndex = 2;
            bhLabel.Text = "编号:";
            // 
            // xmLabel
            // 
            xmLabel.AutoSize = true;
            xmLabel.ForeColor = System.Drawing.Color.Black;
            xmLabel.Location = new System.Drawing.Point(511, 96);
            xmLabel.Name = "xmLabel";
            xmLabel.Size = new System.Drawing.Size(35, 12);
            xmLabel.TabIndex = 4;
            xmLabel.Text = "姓名:";
            // 
            // xbLabel
            // 
            xbLabel.AutoSize = true;
            xbLabel.ForeColor = System.Drawing.Color.Black;
            xbLabel.Location = new System.Drawing.Point(511, 132);
            xbLabel.Name = "xbLabel";
            xbLabel.Size = new System.Drawing.Size(35, 12);
            xbLabel.TabIndex = 6;
            xbLabel.Text = "性别:";
            // 
            // csrqLabel
            // 
            csrqLabel.AutoSize = true;
            csrqLabel.ForeColor = System.Drawing.Color.Black;
            csrqLabel.Location = new System.Drawing.Point(487, 171);
            csrqLabel.Name = "csrqLabel";
            csrqLabel.Size = new System.Drawing.Size(59, 12);
            csrqLabel.TabIndex = 8;
            csrqLabel.Text = "出生日期:";
            csrqLabel.Click += new System.EventHandler(this.csrqLabel_Click);
            // 
            // hfLabel
            // 
            hfLabel.AutoSize = true;
            hfLabel.ForeColor = System.Drawing.Color.Black;
            hfLabel.Location = new System.Drawing.Point(511, 247);
            hfLabel.Name = "hfLabel";
            hfLabel.Size = new System.Drawing.Size(35, 12);
            hfLabel.TabIndex = 10;
            hfLabel.Text = "婚否:";
            // 
            // klLabel
            // 
            klLabel.AutoSize = true;
            klLabel.ForeColor = System.Drawing.Color.Black;
            klLabel.Location = new System.Drawing.Point(511, 281);
            klLabel.Name = "klLabel";
            klLabel.Size = new System.Drawing.Size(35, 12);
            klLabel.TabIndex = 12;
            klLabel.Text = "口令:";
            // 
            // jxcDataSet
            // 
            this.jxcDataSet.DataSetName = "JxcDataSet";
            this.jxcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_zgBindingSource
            // 
            this.t_zgBindingSource.DataMember = "t_zg";
            this.t_zgBindingSource.DataSource = this.jxcDataSet;
            // 
            // t_zgTableAdapter
            // 
            this.t_zgTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = null;
            this.tableAdapterManager.t_zg1TableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = this.t_zgTableAdapter;
            this.tableAdapterManager.t_zyTableAdapter = this.t_zyTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_zyTableAdapter
            // 
            this.t_zyTableAdapter.ClearBeforeFill = true;
            // 
            // t_zgBindingNavigator
            // 
            this.t_zgBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_zgBindingNavigator.BindingSource = this.t_zgBindingSource;
            this.t_zgBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_zgBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_zgBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_zgBindingNavigatorSaveItem});
            this.t_zgBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_zgBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_zgBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_zgBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_zgBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_zgBindingNavigator.Name = "t_zgBindingNavigator";
            this.t_zgBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_zgBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.t_zgBindingNavigator.TabIndex = 0;
            this.t_zgBindingNavigator.Text = "bindingNavigator1";
            this.t_zgBindingNavigator.RefreshItems += new System.EventHandler(this.t_zgBindingNavigator_RefreshItems);
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
            // t_zgBindingNavigatorSaveItem
            // 
            this.t_zgBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_zgBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_zgBindingNavigatorSaveItem.Image")));
            this.t_zgBindingNavigatorSaveItem.Name = "t_zgBindingNavigatorSaveItem";
            this.t_zgBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_zgBindingNavigatorSaveItem.Text = "保存数据";
            this.t_zgBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_zgBindingNavigatorSaveItem_Click);
            // 
            // t_zgDataGridView
            // 
            this.t_zgDataGridView.AutoGenerateColumns = false;
            this.t_zgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_zgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.t_zgDataGridView.DataSource = this.t_zgBindingSource;
            this.t_zgDataGridView.Location = new System.Drawing.Point(12, 52);
            this.t_zgDataGridView.Name = "t_zgDataGridView";
            this.t_zgDataGridView.RowTemplate.Height = 23;
            this.t_zgDataGridView.Size = new System.Drawing.Size(440, 270);
            this.t_zgDataGridView.TabIndex = 1;
            this.t_zgDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.t_zgDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xm";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "xb";
            this.dataGridViewTextBoxColumn3.HeaderText = "性别";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "csrq";
            this.dataGridViewTextBoxColumn4.HeaderText = "出生日期";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bhTextBox
            // 
            this.bhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "bh", true));
            this.bhTextBox.Location = new System.Drawing.Point(545, 56);
            this.bhTextBox.Name = "bhTextBox";
            this.bhTextBox.Size = new System.Drawing.Size(100, 21);
            this.bhTextBox.TabIndex = 3;
            // 
            // xmTextBox
            // 
            this.xmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "xm", true));
            this.xmTextBox.Location = new System.Drawing.Point(545, 93);
            this.xmTextBox.Name = "xmTextBox";
            this.xmTextBox.Size = new System.Drawing.Size(100, 21);
            this.xmTextBox.TabIndex = 5;
            // 
            // xbTextBox
            // 
            this.xbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "xb", true));
            this.xbTextBox.Location = new System.Drawing.Point(545, 129);
            this.xbTextBox.Name = "xbTextBox";
            this.xbTextBox.Size = new System.Drawing.Size(100, 21);
            this.xbTextBox.TabIndex = 7;
            // 
            // csrqDateTimePicker
            // 
            this.csrqDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.t_zgBindingSource, "csrq", true));
            this.csrqDateTimePicker.Location = new System.Drawing.Point(545, 167);
            this.csrqDateTimePicker.Name = "csrqDateTimePicker";
            this.csrqDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.csrqDateTimePicker.TabIndex = 9;
            // 
            // hfCheckBox
            // 
            this.hfCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.t_zgBindingSource, "hf", true));
            this.hfCheckBox.Location = new System.Drawing.Point(545, 244);
            this.hfCheckBox.Name = "hfCheckBox";
            this.hfCheckBox.Size = new System.Drawing.Size(104, 20);
            this.hfCheckBox.TabIndex = 11;
            this.hfCheckBox.UseVisualStyleBackColor = true;
            this.hfCheckBox.CheckedChanged += new System.EventHandler(this.hfCheckBox_CheckedChanged);
            // 
            // klTextBox
            // 
            this.klTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.t_zgBindingSource, "kl", true));
            this.klTextBox.Location = new System.Drawing.Point(545, 278);
            this.klTextBox.Name = "klTextBox";
            this.klTextBox.Size = new System.Drawing.Size(100, 21);
            this.klTextBox.TabIndex = 13;
            // 
            // zgbhcomboBox
            // 
            this.zgbhcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.t_zgBindingSource, "zybh", true));
            this.zgbhcomboBox.DataSource = this.tzyBindingSource;
            this.zgbhcomboBox.DisplayMember = "mc";
            this.zgbhcomboBox.FormattingEnabled = true;
            this.zgbhcomboBox.Location = new System.Drawing.Point(545, 205);
            this.zgbhcomboBox.Name = "zgbhcomboBox";
            this.zgbhcomboBox.Size = new System.Drawing.Size(121, 20);
            this.zgbhcomboBox.TabIndex = 14;
            this.zgbhcomboBox.ValueMember = "bh";
            // 
            // tzyBindingSource
            // 
            this.tzyBindingSource.DataMember = "t_zy";
            this.tzyBindingSource.DataSource = this.jxcDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(511, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "专业:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(511, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "部门:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bmbhcomboBox
            // 
            this.bmbhcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.t_zgBindingSource, "bmbh", true));
            this.bmbhcomboBox.DataSource = this.tbmBindingSource;
            this.bmbhcomboBox.DisplayMember = "mc";
            this.bmbhcomboBox.FormattingEnabled = true;
            this.bmbhcomboBox.Location = new System.Drawing.Point(545, 318);
            this.bmbhcomboBox.Name = "bmbhcomboBox";
            this.bmbhcomboBox.Size = new System.Drawing.Size(121, 20);
            this.bmbhcomboBox.TabIndex = 17;
            this.bmbhcomboBox.ValueMember = "bh";
            // 
            // tbmBindingSource
            // 
            this.tbmBindingSource.DataMember = "t_bm";
            this.tbmBindingSource.DataSource = this.jxcDataSet;
            // 
            // t_bmTableAdapter
            // 
            this.t_bmTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "专业/职工表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_zgInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bmbhcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zgbhcomboBox);
            this.Controls.Add(klLabel);
            this.Controls.Add(this.klTextBox);
            this.Controls.Add(hfLabel);
            this.Controls.Add(this.hfCheckBox);
            this.Controls.Add(csrqLabel);
            this.Controls.Add(this.csrqDateTimePicker);
            this.Controls.Add(xbLabel);
            this.Controls.Add(this.xbTextBox);
            this.Controls.Add(xmLabel);
            this.Controls.Add(this.xmTextBox);
            this.Controls.Add(bhLabel);
            this.Controls.Add(this.bhTextBox);
            this.Controls.Add(this.t_zgDataGridView);
            this.Controls.Add(this.t_zgBindingNavigator);
            this.Name = "frm_zgInfo";
            this.Text = "职工数据编辑窗口";
            this.Load += new System.EventHandler(this.Form_zgInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jxcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgBindingNavigator)).EndInit();
            this.t_zgBindingNavigator.ResumeLayout(false);
            this.t_zgBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_zgDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JxcDataSet jxcDataSet;
        private System.Windows.Forms.BindingSource t_zgBindingSource;
        private WindowsFormsApplication2.JxcDataSetTableAdapters.t_zgTableAdapter t_zgTableAdapter;
        private WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_zgBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_zgBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_zgDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox bhTextBox;
        private System.Windows.Forms.TextBox xmTextBox;
        private System.Windows.Forms.TextBox xbTextBox;
        private System.Windows.Forms.DateTimePicker csrqDateTimePicker;
        private System.Windows.Forms.CheckBox hfCheckBox;
        private System.Windows.Forms.TextBox klTextBox;
        private WindowsFormsApplication2.JxcDataSetTableAdapters.t_zyTableAdapter t_zyTableAdapter;
        private System.Windows.Forms.ComboBox zgbhcomboBox;
        private System.Windows.Forms.BindingSource tzyBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bmbhcomboBox;
        private System.Windows.Forms.BindingSource tbmBindingSource;
        private WindowsFormsApplication2.JxcDataSetTableAdapters.t_bmTableAdapter t_bmTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}