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
            this.GrpJhd = new System.Windows.Forms.GroupBox();
            this.ChBRqbx = new System.Windows.Forms.CheckBox();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PnlUp = new System.Windows.Forms.Panel();
            this.PnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpJhd
            // 
            this.GrpJhd.Location = new System.Drawing.Point(486, 70);
            this.GrpJhd.Name = "GrpJhd";
            this.GrpJhd.Size = new System.Drawing.Size(200, 100);
            this.GrpJhd.TabIndex = 1;
            this.GrpJhd.TabStop = false;
            this.GrpJhd.Text = "进货单（&J）";
            // 
            // ChBRqbx
            // 
            this.ChBRqbx.AutoSize = true;
            this.ChBRqbx.Checked = true;
            this.ChBRqbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChBRqbx.Location = new System.Drawing.Point(25, 33);
            this.ChBRqbx.Name = "ChBRqbx";
            this.ChBRqbx.Size = new System.Drawing.Size(102, 16);
            this.ChBRqbx.TabIndex = 0;
            this.ChBRqbx.Text = "日期不限（&Q）";
            this.ChBRqbx.UseVisualStyleBackColor = true;
            this.ChBRqbx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DTPFrom
            // 
            this.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFrom.Location = new System.Drawing.Point(36, 91);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(200, 21);
            this.DTPFrom.TabIndex = 1;
            // 
            // DTPTo
            // 
            this.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTo.Location = new System.Drawing.Point(36, 135);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(200, 21);
            this.DTPTo.TabIndex = 2;
            this.DTPTo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "从";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "到";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // PnlUp
            // 
            this.PnlUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlUp.Controls.Add(this.comboBox1);
            this.PnlUp.Controls.Add(this.label2);
            this.PnlUp.Controls.Add(this.label1);
            this.PnlUp.Controls.Add(this.DTPTo);
            this.PnlUp.Controls.Add(this.DTPFrom);
            this.PnlUp.Controls.Add(this.ChBRqbx);
            this.PnlUp.Location = new System.Drawing.Point(23, 57);
            this.PnlUp.Name = "PnlUp";
            this.PnlUp.Size = new System.Drawing.Size(457, 193);
            this.PnlUp.TabIndex = 0;
            // 
            // FrmCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 262);
            this.Controls.Add(this.GrpJhd);
            this.Controls.Add(this.PnlUp);
            this.Name = "FrmCX";
            this.Text = "进货查询统计";
            this.PnlUp.ResumeLayout(false);
            this.PnlUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpJhd;
        private System.Windows.Forms.CheckBox ChBRqbx;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel PnlUp;

    }
}