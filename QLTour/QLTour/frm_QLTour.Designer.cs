namespace GUI
{
    partial class frm_QLTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QLTour));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbo_NoiDen = new System.Windows.Forms.ComboBox();
            this.dateEdit_NgayKT = new System.Windows.Forms.DateTimePicker();
            this.dateEdit_NgayKH = new System.Windows.Forms.DateTimePicker();
            this.cbo_KhachSan = new System.Windows.Forms.ComboBox();
            this.cbo_LoaiTour = new System.Windows.Forms.ComboBox();
            this.cbo_HuongDanVien = new System.Windows.Forms.ComboBox();
            this.cbo_NoiDi = new System.Windows.Forms.ComboBox();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_GiaNguoiLon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_GiaTreEm = new DevExpress.XtraEditors.TextEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefesh = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenTour = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.lblMaKH = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_Tour = new DevExpress.XtraGrid.GridControl();
            this.gridView_Tour = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.errorProvider_TenTour = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_GiaTreEm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_GiaNguoiLon = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaNguoiLon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaTreEm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TenTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GiaTreEm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GiaNguoiLon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl_Tour, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 622);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.cbo_NoiDen);
            this.groupControl1.Controls.Add(this.dateEdit_NgayKT);
            this.groupControl1.Controls.Add(this.dateEdit_NgayKH);
            this.groupControl1.Controls.Add(this.cbo_KhachSan);
            this.groupControl1.Controls.Add(this.cbo_LoaiTour);
            this.groupControl1.Controls.Add(this.cbo_HuongDanVien);
            this.groupControl1.Controls.Add(this.cbo_NoiDi);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txt_GiaNguoiLon);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.txt_GiaTreEm);
            this.groupControl1.Controls.Add(this.btn_Save);
            this.groupControl1.Controls.Add(this.btn_Sua);
            this.groupControl1.Controls.Add(this.btn_Xoa);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.btnRefesh);
            this.groupControl1.Controls.Add(this.txt_TenTour);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.lblMaKH);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(44, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 216);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "groupControl1";
            // 
            // cbo_NoiDen
            // 
            this.cbo_NoiDen.FormattingEnabled = true;
            this.cbo_NoiDen.Location = new System.Drawing.Point(573, 65);
            this.cbo_NoiDen.Name = "cbo_NoiDen";
            this.cbo_NoiDen.Size = new System.Drawing.Size(100, 21);
            this.cbo_NoiDen.TabIndex = 58;
            // 
            // dateEdit_NgayKT
            // 
            this.dateEdit_NgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEdit_NgayKT.Location = new System.Drawing.Point(154, 128);
            this.dateEdit_NgayKT.Name = "dateEdit_NgayKT";
            this.dateEdit_NgayKT.Size = new System.Drawing.Size(100, 21);
            this.dateEdit_NgayKT.TabIndex = 57;
            // 
            // dateEdit_NgayKH
            // 
            this.dateEdit_NgayKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEdit_NgayKH.Location = new System.Drawing.Point(154, 101);
            this.dateEdit_NgayKH.Name = "dateEdit_NgayKH";
            this.dateEdit_NgayKH.Size = new System.Drawing.Size(100, 21);
            this.dateEdit_NgayKH.TabIndex = 57;
            // 
            // cbo_KhachSan
            // 
            this.cbo_KhachSan.FormattingEnabled = true;
            this.cbo_KhachSan.Location = new System.Drawing.Point(154, 41);
            this.cbo_KhachSan.Name = "cbo_KhachSan";
            this.cbo_KhachSan.Size = new System.Drawing.Size(100, 21);
            this.cbo_KhachSan.TabIndex = 56;
            // 
            // cbo_LoaiTour
            // 
            this.cbo_LoaiTour.FormattingEnabled = true;
            this.cbo_LoaiTour.Location = new System.Drawing.Point(358, 92);
            this.cbo_LoaiTour.Name = "cbo_LoaiTour";
            this.cbo_LoaiTour.Size = new System.Drawing.Size(100, 21);
            this.cbo_LoaiTour.TabIndex = 56;
            // 
            // cbo_HuongDanVien
            // 
            this.cbo_HuongDanVien.FormattingEnabled = true;
            this.cbo_HuongDanVien.Location = new System.Drawing.Point(358, 119);
            this.cbo_HuongDanVien.Name = "cbo_HuongDanVien";
            this.cbo_HuongDanVien.Size = new System.Drawing.Size(100, 21);
            this.cbo_HuongDanVien.TabIndex = 56;
            // 
            // cbo_NoiDi
            // 
            this.cbo_NoiDi.FormattingEnabled = true;
            this.cbo_NoiDi.Location = new System.Drawing.Point(573, 39);
            this.cbo_NoiDi.Name = "cbo_NoiDi";
            this.cbo_NoiDi.Size = new System.Drawing.Size(100, 21);
            this.cbo_NoiDi.TabIndex = 56;
            this.cbo_NoiDi.SelectedIndexChanged += new System.EventHandler(this.cbo_NoiDi_SelectedIndexChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "DANH MUC TOUR";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(0, -2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.LightPink;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Size = new System.Drawing.Size(786, 32);
            this.textEdit2.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(573, 88);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 71);
            this.pictureEdit1.TabIndex = 55;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(273, 73);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(61, 13);
            this.labelControl12.TabIndex = 51;
            this.labelControl12.Text = "Gia nguoi lon";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(273, 127);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 13);
            this.labelControl8.TabIndex = 49;
            this.labelControl8.Text = "Huong dan vien";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(72, 127);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(67, 13);
            this.labelControl10.TabIndex = 46;
            this.labelControl10.Text = "Ngay ket thuc";
            // 
            // txt_GiaNguoiLon
            // 
            this.txt_GiaNguoiLon.EditValue = "";
            this.txt_GiaNguoiLon.Location = new System.Drawing.Point(358, 66);
            this.txt_GiaNguoiLon.Name = "txt_GiaNguoiLon";
            this.txt_GiaNguoiLon.Size = new System.Drawing.Size(100, 20);
            this.txt_GiaNguoiLon.TabIndex = 45;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(273, 101);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 13);
            this.labelControl9.TabIndex = 43;
            this.labelControl9.Text = "Loai tour";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(514, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nơi đến:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(514, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nơi đi:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(273, 43);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(49, 13);
            this.labelControl11.TabIndex = 40;
            this.labelControl11.Text = "Gia tre em";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(464, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 32);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txt_GiaTreEm
            // 
            this.txt_GiaTreEm.EditValue = "";
            this.txt_GiaTreEm.Location = new System.Drawing.Point(358, 40);
            this.txt_GiaTreEm.Name = "txt_GiaTreEm";
            this.txt_GiaTreEm.Size = new System.Drawing.Size(100, 20);
            this.txt_GiaTreEm.TabIndex = 39;
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(366, 176);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(92, 32);
            this.btn_Save.TabIndex = 36;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sua.BackgroundImage")));
            this.btn_Sua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.ImageOptions.Image")));
            this.btn_Sua.Location = new System.Drawing.Point(170, 176);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(92, 32);
            this.btn_Sua.TabIndex = 34;
            this.btn_Sua.Text = "Edit";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.BackgroundImage")));
            this.btn_Xoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(268, 176);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(92, 32);
            this.btn_Xoa.TabIndex = 32;
            this.btn_Xoa.Text = "Delete";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(72, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 32);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Insert";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefesh.BackgroundImage")));
            this.btnRefesh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnRefesh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.ImageOptions.Image")));
            this.btnRefesh.Location = new System.Drawing.Point(573, 176);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(92, 32);
            this.btnRefesh.TabIndex = 28;
            this.btnRefesh.Text = "Refesh";
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txt_TenTour
            // 
            this.txt_TenTour.Location = new System.Drawing.Point(154, 68);
            this.txt_TenTour.Name = "txt_TenTour";
            this.txt_TenTour.Size = new System.Drawing.Size(100, 20);
            this.txt_TenTour.TabIndex = 35;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(72, 97);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(74, 13);
            this.labelControl13.TabIndex = 33;
            this.labelControl13.Text = "Ngay khoi hanh";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(72, 69);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(41, 13);
            this.labelControl14.TabIndex = 31;
            this.labelControl14.Text = "Ten tour";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Location = new System.Drawing.Point(72, 43);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(53, 13);
            this.lblMaKH.TabIndex = 27;
            this.lblMaKH.Text = "Khách sạn:";
            // 
            // gridControl_Tour
            // 
            this.gridControl_Tour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Tour.Location = new System.Drawing.Point(44, 225);
            this.gridControl_Tour.MainView = this.gridView_Tour;
            this.gridControl_Tour.Name = "gridControl_Tour";
            this.gridControl_Tour.Size = new System.Drawing.Size(780, 394);
            this.gridControl_Tour.TabIndex = 12;
            this.gridControl_Tour.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Tour});
            // 
            // gridView_Tour
            // 
            this.gridView_Tour.GridControl = this.gridControl_Tour;
            this.gridView_Tour.Name = "gridView_Tour";
            this.gridView_Tour.OptionsBehavior.Editable = false;
            this.gridView_Tour.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Tour_RowClick);
            // 
            // errorProvider_TenTour
            // 
            this.errorProvider_TenTour.ContainerControl = this;
            // 
            // errorProvider_GiaTreEm
            // 
            this.errorProvider_GiaTreEm.ContainerControl = this;
            // 
            // errorProvider_GiaNguoiLon
            // 
            this.errorProvider_GiaNguoiLon.ContainerControl = this;
            // 
            // frm_QLTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 622);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_QLTour";
            this.Text = "frm_QLTour1";
            this.Load += new System.EventHandler(this.frm_QLTour_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaNguoiLon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaTreEm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenTour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_TenTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GiaTreEm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GiaNguoiLon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txt_GiaNguoiLon;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txt_GiaTreEm;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Sua;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnRefesh;
        private DevExpress.XtraEditors.TextEdit txt_TenTour;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl lblMaKH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Tour;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Tour;
        private System.Windows.Forms.ComboBox cbo_LoaiTour;
        private System.Windows.Forms.ComboBox cbo_HuongDanVien;
        private System.Windows.Forms.ComboBox cbo_NoiDi;
        private System.Windows.Forms.ComboBox cbo_KhachSan;
        private System.Windows.Forms.DateTimePicker dateEdit_NgayKT;
        private System.Windows.Forms.DateTimePicker dateEdit_NgayKH;
        private System.Windows.Forms.ComboBox cbo_NoiDen;
        private System.Windows.Forms.ErrorProvider errorProvider_TenTour;
        private System.Windows.Forms.ErrorProvider errorProvider_GiaTreEm;
        private System.Windows.Forms.ErrorProvider errorProvider_GiaNguoiLon;
    }
}