namespace GUI
{
    partial class frm_PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhanQuyen));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label2 = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhgBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblPhgban = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cboPhgBan = new System.Windows.Forms.ComboBox();
            this.dgrPB = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.CoQuyen = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dgrPQ = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(394, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 37);
            this.label2.TabIndex = 213;
            this.label2.Text = "PHÂN QUYỀN NHÂN VIÊN";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNV,
            this.TenNV,
            this.PhgBan,
            this.ChucVu,
            this.MaMH});
            this.gridView1.Name = "gridView1";
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 0;
            // 
            // TenNV
            // 
            this.TenNV.Caption = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Visible = true;
            this.TenNV.VisibleIndex = 3;
            // 
            // PhgBan
            // 
            this.PhgBan.Caption = "Phòng ban";
            this.PhgBan.Name = "PhgBan";
            this.PhgBan.Visible = true;
            this.PhgBan.VisibleIndex = 2;
            // 
            // ChucVu
            // 
            this.ChucVu.Caption = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Visible = true;
            this.ChucVu.VisibleIndex = 1;
            // 
            // MaMH
            // 
            this.MaMH.Caption = "Mã màn hình";
            this.MaMH.Name = "MaMH";
            this.MaMH.Visible = true;
            this.MaMH.VisibleIndex = 4;
            // 
            // lblPhgban
            // 
            this.lblPhgban.Location = new System.Drawing.Point(21, 26);
            this.lblPhgban.Name = "lblPhgban";
            this.lblPhgban.Size = new System.Drawing.Size(55, 13);
            this.lblPhgban.TabIndex = 217;
            this.lblPhgban.Text = "Phòng ban:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboPhgBan);
            this.groupControl1.Controls.Add(this.dgrPB);
            this.groupControl1.Controls.Add(this.lblPhgban);
            this.groupControl1.Location = new System.Drawing.Point(12, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 515);
            this.groupControl1.TabIndex = 218;
            this.groupControl1.Text = "Danh sách quyền nhân viên";
            // 
<<<<<<< HEAD
            // cboPhgBan
            // 
            this.cboPhgBan.FormattingEnabled = true;
            this.cboPhgBan.Location = new System.Drawing.Point(128, 26);
            this.cboPhgBan.Name = "cboPhgBan";
            this.cboPhgBan.Size = new System.Drawing.Size(216, 21);
            this.cboPhgBan.TabIndex = 219;
            this.cboPhgBan.SelectedIndexChanged += new System.EventHandler(this.cboPhgBan_SelectedIndexChanged);
            this.cboPhgBan.SelectionChangeCommitted += new System.EventHandler(this.cboPhgBan_SelectionChangeCommitted);
            // 
            // dgrPB
            // 
            this.dgrPB.Location = new System.Drawing.Point(5, 68);
            this.dgrPB.MainView = this.gridView2;
            this.dgrPB.Name = "dgrPB";
            this.dgrPB.Size = new System.Drawing.Size(416, 405);
            this.dgrPB.TabIndex = 218;
            this.dgrPB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgrPB;
            this.gridView2.Name = "gridView2";
            // 
            // simpleButton13
            // 
=======
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí hệ thống";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quản lí tour du lịch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qủan lí điều hành tour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quản lí kinh doanh tour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Báo cáo,thống kê";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "*********************************************************************************" +
    "*******************";
            this.textEdit1.Location = new System.Drawing.Point(22, 88);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Size = new System.Drawing.Size(283, 20);
            this.textEdit1.TabIndex = 8;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "*********************************************************************************" +
    "*******************";
            this.textEdit2.Location = new System.Drawing.Point(22, 168);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Size = new System.Drawing.Size(283, 20);
            this.textEdit2.TabIndex = 9;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "*********************************************************************************" +
    "*******************";
            this.textEdit3.Location = new System.Drawing.Point(22, 248);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Size = new System.Drawing.Size(283, 20);
            this.textEdit3.TabIndex = 12;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "*********************************************************************************" +
    "*******************";
            this.textEdit4.Location = new System.Drawing.Point(22, 328);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit4.Size = new System.Drawing.Size(283, 20);
            this.textEdit4.TabIndex = 13;
            // 
            // grPQ
            // 
            this.grPQ.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grPQ.Appearance.Options.UseBackColor = true;
            this.grPQ.Controls.Add(this.grCT);
            this.grPQ.Controls.Add(this.grPhanQuyen);
            this.grPQ.Location = new System.Drawing.Point(457, 62);
            this.grPQ.Name = "grPQ";
            this.grPQ.Size = new System.Drawing.Size(719, 515);
            this.grPQ.TabIndex = 219;
            this.grPQ.Text = "Phân quyền";
            // 
            // grCT
            // 
            this.grCT.Controls.Add(this.textBox1);
            this.grCT.Location = new System.Drawing.Point(375, 26);
            this.grCT.Name = "grCT";
            this.grCT.Size = new System.Drawing.Size(339, 481);
            this.grCT.TabIndex = 224;
            this.grCT.Text = "Chi tiết quyền";
            this.grCT.Paint += new System.Windows.Forms.PaintEventHandler(this.grCT_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 298);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Quyền nhân viên sẽ được miêu tả tại đây.Click vào quyền nhân viên để xem chi tiết" +
    ".";
            // 
            // grPhanQuyen
            // 
            this.grPhanQuyen.Controls.Add(this.simpleButton2);
            this.grPhanQuyen.Controls.Add(this.btnSave);
            this.grPhanQuyen.Controls.Add(this.pictureEdit1);
            this.grPhanQuyen.Controls.Add(this.pictureEdit5);
            this.grPhanQuyen.Controls.Add(this.label1);
            this.grPhanQuyen.Controls.Add(this.pictureEdit4);
            this.grPhanQuyen.Controls.Add(this.label3);
            this.grPhanQuyen.Controls.Add(this.label4);
            this.grPhanQuyen.Controls.Add(this.pictureEdit2);
            this.grPhanQuyen.Controls.Add(this.label5);
            this.grPhanQuyen.Controls.Add(this.label6);
            this.grPhanQuyen.Controls.Add(this.textEdit1);
            this.grPhanQuyen.Controls.Add(this.textEdit4);
            this.grPhanQuyen.Controls.Add(this.textEdit2);
            this.grPhanQuyen.Controls.Add(this.textEdit3);
            this.grPhanQuyen.Controls.Add(this.pictureEdit3);
            this.grPhanQuyen.Location = new System.Drawing.Point(5, 26);
            this.grPhanQuyen.Name = "grPhanQuyen";
            this.grPhanQuyen.Size = new System.Drawing.Size(363, 484);
            this.grPhanQuyen.TabIndex = 223;
            this.grPhanQuyen.Text = "Phân quyền nhân viên";
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImage = global::GUI.Properties.Resources.Blue;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(185, 427);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(92, 32);
            this.simpleButton2.TabIndex = 225;
            this.simpleButton2.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::GUI.Properties.Resources.images;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(66, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 32);
            this.btnSave.TabIndex = 224;
            this.btnSave.Text = "Save";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(215, 34);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(62, 48);
            this.pictureEdit1.TabIndex = 220;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(215, 354);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit5.Size = new System.Drawing.Size(62, 48);
            this.pictureEdit5.TabIndex = 222;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(215, 274);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit4.Size = new System.Drawing.Size(62, 48);
            this.pictureEdit4.TabIndex = 221;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(215, 114);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(62, 48);
            this.pictureEdit2.TabIndex = 219;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(215, 191);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit3.Size = new System.Drawing.Size(62, 48);
            this.pictureEdit3.TabIndex = 10;
            // 
            // simpleButton13
            // 
            this.simpleButton13.BackgroundImage = global::GUI.Properties.Resources.yellow;
>>>>>>> master
            this.simpleButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton13.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton13.ImageOptions.Image")));
            this.simpleButton13.Location = new System.Drawing.Point(1084, 583);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(92, 32);
            this.simpleButton13.TabIndex = 220;
            this.simpleButton13.Text = "Trở về";
            // 
            // CoQuyen
            // 
            this.CoQuyen.Checked = true;
            this.CoQuyen.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CoQuyen.CheckValue = null;
            this.CoQuyen.DataPropertyName = "CoQuyen";
            this.CoQuyen.HeaderText = "Có quyền";
            this.CoQuyen.Name = "CoQuyen";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(465, 499);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 45);
            this.btnCapNhat.TabIndex = 225;
            this.btnCapNhat.Text = "Cập nhật quyền";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dgrPQ
            // 
            gridLevelNode1.RelationName = "Level1";
            this.dgrPQ.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgrPQ.Location = new System.Drawing.Point(465, 62);
            this.dgrPQ.MainView = this.gridView3;
            this.dgrPQ.Name = "dgrPQ";
            this.dgrPQ.Size = new System.Drawing.Size(803, 216);
            this.dgrPQ.TabIndex = 226;
            this.dgrPQ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.dgrPQ;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.MultiSelect = true;
            // 
            // frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 627);
            this.Controls.Add(this.dgrPQ);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.simpleButton13);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PhanQuyen";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn TenNV;
        private DevExpress.XtraGrid.Columns.GridColumn PhgBan;
        private DevExpress.XtraEditors.LabelControl lblPhgban;
        private DevExpress.XtraGrid.Columns.GridColumn MaMH;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton13;
        private DevExpress.XtraGrid.GridControl dgrPB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ComboBox cboPhgBan;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn CoQuyen;
        private System.Windows.Forms.Button btnCapNhat;
        private DevExpress.XtraGrid.GridControl dgrPQ;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;


    }
}

