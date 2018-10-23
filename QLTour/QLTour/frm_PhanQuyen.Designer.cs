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

