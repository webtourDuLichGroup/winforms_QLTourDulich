namespace GUI
{
    partial class frm_DoanhThu
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
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoanhThu));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.grTK = new DevExpress.XtraEditors.GroupControl();
            this.btnTraCuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtDen = new DevExpress.XtraEditors.DateEdit();
            this.To = new DevExpress.XtraEditors.LabelControl();
            this.txtTu = new DevExpress.XtraEditors.DateEdit();
            this.Form = new DevExpress.XtraEditors.LabelControl();
            this.txtNV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblDoanhThu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDoanhThuTheoNgay = new DevExpress.XtraEditors.TextEdit();
            this.txtHoaHongTheoNgay = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblThang = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboFromThang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboToThang = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grTK)).BeginInit();
            this.grTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoanhThuTheoNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoaHongTheoNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboToThang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.SelectedPage = this.tabFormPage2;
            this.tabFormControl1.Size = new System.Drawing.Size(771, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 50);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(771, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 486);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(771, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 436);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(771, 50);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 436);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.xtraScrollableControl1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Doanh thu theo ngày";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.grTK);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 50);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(771, 436);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // grTK
            // 
            this.grTK.Controls.Add(this.btnTraCuu);
            this.grTK.Controls.Add(this.txtDen);
            this.grTK.Controls.Add(this.To);
            this.grTK.Controls.Add(this.txtTu);
            this.grTK.Controls.Add(this.Form);
            this.grTK.Controls.Add(this.txtNV);
            this.grTK.Controls.Add(this.labelControl1);
            this.grTK.Location = new System.Drawing.Point(13, 7);
            this.grTK.Name = "grTK";
            this.grTK.Size = new System.Drawing.Size(199, 185);
            this.grTK.TabIndex = 0;
            this.grTK.Text = "Tìm kiếm";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(45, 115);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(95, 45);
            this.btnTraCuu.TabIndex = 6;
            this.btnTraCuu.Text = "Tra cứu";
            // 
            // txtDen
            // 
            this.txtDen.EditValue = null;
            this.txtDen.Location = new System.Drawing.Point(94, 89);
            this.txtDen.MenuManager = this.tabFormDefaultManager1;
            this.txtDen.Name = "txtDen";
            this.txtDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDen.Size = new System.Drawing.Size(100, 20);
            this.txtDen.TabIndex = 5;
            this.txtDen.EditValueChanged += new System.EventHandler(this.dateEdit2_EditValueChanged);
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(5, 92);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(12, 13);
            this.To.TabIndex = 4;
            this.To.Text = "To";
            // 
            // txtTu
            // 
            this.txtTu.EditValue = null;
            this.txtTu.Location = new System.Drawing.Point(94, 63);
            this.txtTu.MenuManager = this.tabFormDefaultManager1;
            this.txtTu.Name = "txtTu";
            this.txtTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTu.Size = new System.Drawing.Size(100, 20);
            this.txtTu.TabIndex = 3;
            this.txtTu.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // Form
            // 
            this.Form.Location = new System.Drawing.Point(5, 66);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(24, 13);
            this.Form.TabIndex = 2;
            this.Form.Text = "Form";
            this.Form.Click += new System.EventHandler(this.Form_Click);
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(94, 32);
            this.txtNV.MenuManager = this.tabFormDefaultManager1;
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(100, 20);
            this.txtNV.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên nhân viên";
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Doanh thu theo tháng";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.groupControl2);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 50);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(771, 436);
            this.tabFormContentContainer1.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(18, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.tabFormDefaultManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(465, 279);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ngay,
            this.TenNV,
            this.MaHD,
            this.GiaTri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 0;
            // 
            // TenNV
            // 
            this.TenNV.Caption = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 1;
            // 
            // MaHD
            // 
            this.MaHD.Caption = "Mã hợp đồng";
            this.MaHD.Name = "MaHD";
            this.MaHD.Visible = true;
            this.MaHD.VisibleIndex = 2;
            // 
            // GiaTri
            // 
            this.GiaTri.Caption = "Gía trị hợp đồng";
            this.GiaTri.Name = "GiaTri";
            this.GiaTri.Visible = true;
            this.GiaTri.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtHoaHongTheoNgay);
            this.groupControl1.Controls.Add(this.txtDoanhThuTheoNgay);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblDoanhThu);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(241, 57);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 396);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDoanhThu.Appearance.Options.UseFont = true;
            this.lblDoanhThu.Appearance.Options.UseForeColor = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(18, 308);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(163, 23);
            this.lblDoanhThu.TabIndex = 7;
            this.lblDoanhThu.Text = "DOANH THU(VNĐ):";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 345);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(153, 23);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "HOA HỒNG(VNĐ):";
            // 
            // txtDoanhThuTheoNgay
            // 
            this.txtDoanhThuTheoNgay.Location = new System.Drawing.Point(204, 308);
            this.txtDoanhThuTheoNgay.MenuManager = this.tabFormDefaultManager1;
            this.txtDoanhThuTheoNgay.Name = "txtDoanhThuTheoNgay";
            this.txtDoanhThuTheoNgay.Size = new System.Drawing.Size(100, 20);
            this.txtDoanhThuTheoNgay.TabIndex = 9;
            // 
            // txtHoaHongTheoNgay
            // 
            this.txtHoaHongTheoNgay.Location = new System.Drawing.Point(204, 347);
            this.txtHoaHongTheoNgay.MenuManager = this.tabFormDefaultManager1;
            this.txtHoaHongTheoNgay.Name = "txtHoaHongTheoNgay";
            this.txtHoaHongTheoNgay.Size = new System.Drawing.Size(100, 20);
            this.txtHoaHongTheoNgay.TabIndex = 10;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cboToThang);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.cboFromThang);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.lblThang);
            this.groupControl2.Controls.Add(this.textEdit1);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(17, 6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(207, 222);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Tìm kiếm";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(47, 144);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 45);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Tra cứu";
            // 
            // lblThang
            // 
            this.lblThang.Location = new System.Drawing.Point(5, 66);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(17, 13);
            this.lblThang.TabIndex = 2;
            this.lblThang.Text = "Từ:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(94, 32);
            this.textEdit1.MenuManager = this.tabFormDefaultManager1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tên nhân viên";
            // 
            // cboFromThang
            // 
            this.cboFromThang.Location = new System.Drawing.Point(94, 59);
            this.cboFromThang.MenuManager = this.tabFormDefaultManager1;
            this.cboFromThang.Name = "cboFromThang";
            this.cboFromThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFromThang.Size = new System.Drawing.Size(100, 20);
            this.cboFromThang.TabIndex = 7;
            this.cboFromThang.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Đến";
            // 
            // cboToThang
            // 
            this.cboToThang.Location = new System.Drawing.Point(94, 89);
            this.cboToThang.MenuManager = this.tabFormDefaultManager1;
            this.cboToThang.Name = "cboToThang";
            this.cboToThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboToThang.Size = new System.Drawing.Size(100, 20);
            this.cboToThang.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 486);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grTK)).EndInit();
            this.grTK.ResumeLayout(false);
            this.grTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNV.Properties)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoanhThuTheoNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoaHongTheoNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFromThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboToThang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraEditors.GroupControl grTK;
        private DevExpress.XtraEditors.TextEdit txtNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraEditors.DateEdit txtTu;
        private DevExpress.XtraEditors.LabelControl Form;
        private DevExpress.XtraEditors.DateEdit txtDen;
        private DevExpress.XtraEditors.LabelControl To;
        private DevExpress.XtraEditors.SimpleButton btnTraCuu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblDoanhThu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn MaHD;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTri;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.TextEdit txtHoaHongTheoNgay;
        private DevExpress.XtraEditors.TextEdit txtDoanhThuTheoNgay;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblThang;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboFromThang;
        private DevExpress.XtraEditors.ComboBoxEdit cboToThang;
        private DevExpress.XtraEditors.LabelControl labelControl3;

    }
}

