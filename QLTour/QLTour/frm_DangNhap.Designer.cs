namespace GUI
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.txt_Username = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDN = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(228, 82);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(170, 20);
            this.txt_Username.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(106, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // btnDN
            // 
            this.btnDN.BackgroundImage = global::GUI.Properties.Resources.greeen;
            this.btnDN.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDN.Location = new System.Drawing.Point(209, 161);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(85, 32);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::GUI.Properties.Resources.Pink_;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCancel.Location = new System.Drawing.Point(300, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(228, 115);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.UseSystemPasswordChar = true;
            this.txt_MatKhau.Size = new System.Drawing.Size(170, 20);
            this.txt_MatKhau.TabIndex = 2;
            // 
            // frm_DangNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(551, 305);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_Username);
            this.MaximizeBox = false;
            this.Name = "frm_DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_Username;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDN;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txt_MatKhau;
    }
}