namespace GUI
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ribbonMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtn_NhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_XemKS = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection_PageGroup_Tour = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1_XemTour = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barPageGrp_KhachSan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imageCollection_PageGrp_KhachSan = new DevExpress.Utils.ImageCollection(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_PageGroup_Tour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_PageGrp_KhachSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.ExpandCollapseItem.Id = 0;
            this.ribbonMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMenu.ExpandCollapseItem,
            this.barBtn_NhanVien,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem1,
            this.barBtn_XemKS,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11});
            this.ribbonMenu.LargeImages = this.imageCollection_PageGroup_Tour;
            this.ribbonMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.MaxItemId = 14;
            this.ribbonMenu.Name = "ribbonMenu";
            this.ribbonMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage5,
            this.ribbonPage4});
            this.ribbonMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonMenu.Size = new System.Drawing.Size(857, 146);
            // 
            // barBtn_NhanVien
            // 
            this.barBtn_NhanVien.Caption = "Quản lí Tour Du Lịch";
            this.barBtn_NhanVien.Id = 1;
            this.barBtn_NhanVien.ImageOptions.DisabledLargeImageIndex = 0;
            this.barBtn_NhanVien.ImageOptions.LargeImageIndex = 7;
            this.barBtn_NhanVien.Name = "barBtn_NhanVien";
            this.barBtn_NhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_QLTourDuLich_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Phân Quyền";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.LargeImageIndex = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Quản lí Nhân Viên";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.LargeImageIndex = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barBtn_XemKS
            // 
            this.barBtn_XemKS.Caption = "Khách Sạn";
            this.barBtn_XemKS.Id = 5;
            this.barBtn_XemKS.ImageOptions.LargeImageIndex = 1;
            this.barBtn_XemKS.Name = "barBtn_XemKS";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quản lí khách sạn";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageOptions.LargeImageIndex = 0;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Loại khách sạn";
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.ImageOptions.LargeImageIndex = 2;
            this.barButtonItem6.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đặt Tour Du Lịch";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.ImageOptions.LargeImageIndex = 3;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Tra Cứu Tour";
            this.barButtonItem8.Id = 10;
            this.barButtonItem8.ImageOptions.LargeImageIndex = 0;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thay đổi dịch vụ";
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.ImageOptions.LargeImageIndex = 4;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem9.SmallWithoutTextWidth = 20;
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Loại Khách Sạn";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.ImageOptions.LargeImageIndex = 2;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Các Tour";
            this.barButtonItem11.Id = 13;
            this.barButtonItem11.ImageOptions.LargeImageIndex = 8;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // imageCollection_PageGroup_Tour
            // 
            this.imageCollection_PageGroup_Tour.ImageSize = new System.Drawing.Size(50, 50);
            this.imageCollection_PageGroup_Tour.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection_PageGroup_Tour.ImageStream")));
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(0, "bookTour.png");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(1, "showHotel.png");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(2, "typeHotel.png");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(3, "bookTour.png");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(4, "change_dichvu.png");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(5, "qhanhvien.jpg");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(6, "permission.png");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(7, "showTour.png");
            this.imageCollection_PageGroup_Tour.Images.SetKeyName(8, "report-icon.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1_XemTour,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Tag = "showtour";
            this.ribbonPage1.Text = "Quản lí";
            // 
            // ribbonPageGroup1_XemTour
            // 
            this.ribbonPageGroup1_XemTour.AllowTextClipping = false;
            this.ribbonPageGroup1_XemTour.ItemLinks.Add(this.barBtn_NhanVien);
            this.ribbonPageGroup1_XemTour.Name = "ribbonPageGroup1_XemTour";
            this.ribbonPageGroup1_XemTour.Text = "Tour Du Lịch";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem6, false, "", "", true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Khách Sạn";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Tag = "quanlytour";
            this.ribbonPage2.Text = "Đặt Tour";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Đặt Tour";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Các Tour đã đặt";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.barPageGrp_KhachSan});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Khách Sạn";
            // 
            // barPageGrp_KhachSan
            // 
            this.barPageGrp_KhachSan.ItemLinks.Add(this.barBtn_XemKS);
            this.barPageGrp_KhachSan.ItemLinks.Add(this.barButtonItem10);
            this.barPageGrp_KhachSan.Name = "barPageGrp_KhachSan";
            this.barPageGrp_KhachSan.Text = "Khách Sạn";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Quản Trị Viên";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Nhân Viên";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Thống kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thống kê theo Tour";
            // 
            // imageCollection_PageGrp_KhachSan
            // 
            this.imageCollection_PageGrp_KhachSan.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection_PageGrp_KhachSan.ImageStream")));
            this.imageCollection_PageGrp_KhachSan.Images.SetKeyName(0, "showHotel.png");
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonMenu;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // frm_Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 557);
            this.Controls.Add(this.ribbonMenu);
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.Ribbon = this.ribbonMenu;
            this.Text = "Form Main";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_PageGroup_Tour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection_PageGrp_KhachSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1_XemTour;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup barPageGrp_KhachSan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barBtn_NhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.Utils.ImageCollection imageCollection_PageGroup_Tour;
        private DevExpress.Utils.ImageCollection imageCollection_PageGrp_KhachSan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtn_XemKS;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}

