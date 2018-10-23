namespace GUI
{
    partial class frm_Tour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tour));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgv_Tour = new DevExpress.XtraGrid.GridControl();
            this.cbo_NoiDen = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Tim = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_NguoiLon = new MyControl.NumbericTextBox();
            this.cbo_NoiDi = new System.Windows.Forms.ComboBox();
            this.dateEdit_NgayDi = new DevExpress.XtraEditors.DateEdit();
            this.txt_TreEm = new MyControl.NumbericTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayDi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayDi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.PapayaWhip;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgv_Tour;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // dgv_Tour
            // 
            this.dgv_Tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Tour.Location = new System.Drawing.Point(82, 195);
            this.dgv_Tour.MainView = this.gridView1;
            this.dgv_Tour.Name = "dgv_Tour";
            this.dgv_Tour.Size = new System.Drawing.Size(796, 333);
            this.dgv_Tour.TabIndex = 1;
            this.dgv_Tour.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cbo_NoiDen
            // 
            this.cbo_NoiDen.FormattingEnabled = true;
            this.cbo_NoiDen.Location = new System.Drawing.Point(349, 108);
            this.cbo_NoiDen.Name = "cbo_NoiDen";
            this.cbo_NoiDen.Size = new System.Drawing.Size(118, 21);
            this.cbo_NoiDen.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(275, 108);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Nơi đến:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(50, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày đi:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(494, 108);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(49, 13);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Người lớn:";
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tim.BackgroundImage")));
            this.btn_Tim.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Tim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim.ImageOptions.Image")));
            this.btn_Tim.Location = new System.Drawing.Point(261, 145);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(105, 34);
            this.btn_Tim.TabIndex = 13;
            this.btn_Tim.Text = "Tim";
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Reset.BackgroundImage")));
            this.btn_Reset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Reset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.ImageOptions.Image")));
            this.btn_Reset.Location = new System.Drawing.Point(459, 145);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(115, 34);
            this.btn_Reset.TabIndex = 23;
            this.btn_Reset.Text = "Cancel";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(281, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Nơi đi:";
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit1.EditValue = "DANH MUC TOUR";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(3, 17);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightPink;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.textEdit1.Size = new System.Drawing.Size(790, 32);
            this.textEdit1.TabIndex = 59;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(494, 65);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Trẻ em:";
            // 
            // txt_NguoiLon
            // 
            this.txt_NguoiLon.Location = new System.Drawing.Point(596, 65);
            this.txt_NguoiLon.Name = "txt_NguoiLon";
            this.txt_NguoiLon.Size = new System.Drawing.Size(120, 21);
            this.txt_NguoiLon.TabIndex = 25;
            // 
            // cbo_NoiDi
            // 
            this.cbo_NoiDi.FormattingEnabled = true;
            this.cbo_NoiDi.Location = new System.Drawing.Point(349, 62);
            this.cbo_NoiDi.Name = "cbo_NoiDi";
            this.cbo_NoiDi.Size = new System.Drawing.Size(118, 21);
            this.cbo_NoiDi.TabIndex = 24;
            this.cbo_NoiDi.SelectedIndexChanged += new System.EventHandler(this.cbo_NoiDi_SelectedIndexChanged);
            // 
            // dateEdit_NgayDi
            // 
            this.dateEdit_NgayDi.EditValue = new System.DateTime(2018, 10, 17, 15, 19, 57, 0);
            this.dateEdit_NgayDi.Location = new System.Drawing.Point(126, 65);
            this.dateEdit_NgayDi.Name = "dateEdit_NgayDi";
            this.dateEdit_NgayDi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayDi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_NgayDi.Size = new System.Drawing.Size(122, 20);
            this.dateEdit_NgayDi.TabIndex = 24;
            // 
            // txt_TreEm
            // 
            this.txt_TreEm.Location = new System.Drawing.Point(596, 108);
            this.txt_TreEm.Name = "txt_TreEm";
            this.txt_TreEm.Size = new System.Drawing.Size(120, 21);
            this.txt_TreEm.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_NoiDen);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txt_NguoiLon);
            this.groupBox1.Controls.Add(this.cbo_NoiDi);
            this.groupBox1.Controls.Add(this.dateEdit_NgayDi);
            this.groupBox1.Controls.Add(this.txt_TreEm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(82, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 802F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Tour, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 531);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frm_Tour
            // 
            this.ClientSize = new System.Drawing.Size(943, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_Tour";
            this.Load += new System.EventHandler(this.frm_Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayDi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_NgayDi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dgv_Tour;
        private System.Windows.Forms.ComboBox cbo_NoiDen;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn_Tim;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private MyControl.NumbericTextBox txt_NguoiLon;
        private System.Windows.Forms.ComboBox cbo_NoiDi;
        private DevExpress.XtraEditors.DateEdit dateEdit_NgayDi;
        private MyControl.NumbericTextBox txt_TreEm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}