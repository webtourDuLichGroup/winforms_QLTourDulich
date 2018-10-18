using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_DoanhThu : DevExpress.XtraBars.TabForm
    {
        public frm_DoanhThu()
        {
            InitializeComponent();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            frm_DoanhThu form = new frm_DoanhThu();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
