namespace QLTour
{
    partial class frmdangnhap
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
            this.txt_tendn = new DevExpress.XtraEditors.TextEdit();
            this.txt_matkhau = new DevExpress.XtraEditors.TextEdit();
            this.btn_dangnhap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tendn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matkhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tendn
            // 
            this.txt_tendn.Location = new System.Drawing.Point(74, 87);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(131, 20);
            this.txt_tendn.TabIndex = 0;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(74, 136);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(131, 20);
            this.txt_matkhau.TabIndex = 1;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(92, 175);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.btn_dangnhap.TabIndex = 2;
            this.btn_dangnhap.Text = "&Đăng nhập";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendn);
            this.Name = "frmdangnhap";
            this.Text = "frmdangnhap";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tendn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matkhau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_tendn;
        private DevExpress.XtraEditors.TextEdit txt_matkhau;
        private DevExpress.XtraEditors.SimpleButton btn_dangnhap;
    }
}