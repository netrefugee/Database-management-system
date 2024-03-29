﻿namespace WindowsFormsApplication2
{
    partial class FrmBM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBM));
            this.t_bmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.t_bmBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_bmDataGridView = new System.Windows.Forms.DataGridView();
            this.t_bmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jxcDataSet = new WindowsFormsApplication2.JxcDataSet();
            this.t_bmTableAdapter = new WindowsFormsApplication2.JxcDataSetTableAdapters.t_bmTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager();
            this.tzgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_zgTableAdapter = new WindowsFormsApplication2.JxcDataSetTableAdapters.t_zgTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingNavigator)).BeginInit();
            this.t_bmBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jxcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // t_bmBindingNavigator
            // 
            this.t_bmBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_bmBindingNavigator.BindingSource = this.t_bmBindingSource;
            this.t_bmBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_bmBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_bmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.t_bmBindingNavigatorSaveItem});
            this.t_bmBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_bmBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_bmBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_bmBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_bmBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_bmBindingNavigator.Name = "t_bmBindingNavigator";
            this.t_bmBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_bmBindingNavigator.Size = new System.Drawing.Size(475, 25);
            this.t_bmBindingNavigator.TabIndex = 0;
            this.t_bmBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // t_bmBindingNavigatorSaveItem
            // 
            this.t_bmBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_bmBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_bmBindingNavigatorSaveItem.Image")));
            this.t_bmBindingNavigatorSaveItem.Name = "t_bmBindingNavigatorSaveItem";
            this.t_bmBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_bmBindingNavigatorSaveItem.Text = "保存数据";
            this.t_bmBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_bmBindingNavigatorSaveItem_Click);
            // 
            // t_bmDataGridView
            // 
            this.t_bmDataGridView.AutoGenerateColumns = false;
            this.t_bmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_bmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.t_bmDataGridView.DataSource = this.t_bmBindingSource;
            this.t_bmDataGridView.Location = new System.Drawing.Point(12, 60);
            this.t_bmDataGridView.Name = "t_bmDataGridView";
            this.t_bmDataGridView.RowTemplate.Height = 23;
            this.t_bmDataGridView.Size = new System.Drawing.Size(378, 230);
            this.t_bmDataGridView.TabIndex = 1;
            this.t_bmDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.t_bmDataGridView_CellContentClick);
            // 
            // t_bmBindingSource
            // 
            this.t_bmBindingSource.DataMember = "t_bm";
            this.t_bmBindingSource.DataSource = this.jxcDataSet;
            // 
            // jxcDataSet
            // 
            this.jxcDataSet.DataSetName = "JxcDataSet";
            this.jxcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_bmTableAdapter
            // 
            this.t_bmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = this.t_bmTableAdapter;
            this.tableAdapterManager.t_zg1TableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.t_zyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.JxcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tzgBindingSource
            // 
            this.tzgBindingSource.DataMember = "t_zg";
            this.tzgBindingSource.DataSource = this.jxcDataSet;
            // 
            // t_zgTableAdapter
            // 
            this.t_zgTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.HeaderText = "部门名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fzrbh";
            this.dataGridViewTextBoxColumn3.DataSource = this.tzgBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "xm";
            this.dataGridViewTextBoxColumn3.HeaderText = "负责人";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "bh";
            // 
            // FrmBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 374);
            this.Controls.Add(this.t_bmDataGridView);
            this.Controls.Add(this.t_bmBindingNavigator);
            this.Name = "FrmBM";
            this.Text = "部门管理窗口";
            this.Load += new System.EventHandler(this.FrmBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingNavigator)).EndInit();
            this.t_bmBindingNavigator.ResumeLayout(false);
            this.t_bmBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jxcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JxcDataSet jxcDataSet;
        private System.Windows.Forms.BindingSource t_bmBindingSource;
        private JxcDataSetTableAdapters.t_bmTableAdapter t_bmTableAdapter;
        private JxcDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_bmBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton t_bmBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_bmDataGridView;
        private System.Windows.Forms.BindingSource tzgBindingSource;
        private JxcDataSetTableAdapters.t_zgTableAdapter t_zgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
    }
}