namespace GUI
{
    partial class frm_ShowTour
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
            this.tourDuLich1 = new UserDL.TourDuLich();
            this.tourDuLich2 = new UserDL.TourDuLich();
            this.tourDuLich3 = new UserDL.TourDuLich();
            this.tourDuLich4 = new UserDL.TourDuLich();
            this.tourDuLich5 = new UserDL.TourDuLich();
            this.SuspendLayout();
            // 
            // tourDuLich1
            // 
            this.tourDuLich1.Location = new System.Drawing.Point(12, 12);
            this.tourDuLich1.Name = "tourDuLich1";
            this.tourDuLich1.Size = new System.Drawing.Size(292, 252);
            this.tourDuLich1.TabIndex = 0;
            // 
            // tourDuLich2
            // 
            this.tourDuLich2.Location = new System.Drawing.Point(395, 12);
            this.tourDuLich2.Name = "tourDuLich2";
            this.tourDuLich2.Size = new System.Drawing.Size(292, 252);
            this.tourDuLich2.TabIndex = 0;
            // 
            // tourDuLich3
            // 
            this.tourDuLich3.Location = new System.Drawing.Point(428, 316);
            this.tourDuLich3.Name = "tourDuLich3";
            this.tourDuLich3.Size = new System.Drawing.Size(292, 252);
            this.tourDuLich3.TabIndex = 0;
            // 
            // tourDuLich4
            // 
            this.tourDuLich4.Location = new System.Drawing.Point(1002, 12);
            this.tourDuLich4.Name = "tourDuLich4";
            this.tourDuLich4.Size = new System.Drawing.Size(292, 252);
            this.tourDuLich4.TabIndex = 0;
            // 
            // tourDuLich5
            // 
            this.tourDuLich5.Location = new System.Drawing.Point(693, 1);
            this.tourDuLich5.Name = "tourDuLich5";
            this.tourDuLich5.Size = new System.Drawing.Size(292, 252);
            this.tourDuLich5.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1314, 548);
            this.Controls.Add(this.tourDuLich5);
            this.Controls.Add(this.tourDuLich4);
            this.Controls.Add(this.tourDuLich2);
            this.Controls.Add(this.tourDuLich3);
            this.Controls.Add(this.tourDuLich1);
            this.Name = "Form1";
            this.Text = "Các Tour Du Lịch";
            this.ResumeLayout(false);

        }

        #endregion

        private UserDL.TourDuLich tourDuLich1;
        private UserDL.TourDuLich tourDuLich2;
        private UserDL.TourDuLich tourDuLich3;
        private UserDL.TourDuLich tourDuLich4;
        private UserDL.TourDuLich tourDuLich5;
    }
}