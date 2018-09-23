using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Frm_DangNhap
{
    public partial class FrmFindServer : Form
    {
        public FrmFindServer()
        {
            InitializeComponent();
        }
        public void cboServer_DropDown(object sender, EventArgs e)
        {
            DataTable dt = CauHinh.GetSeverName();
            cboServername.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    cboServername.Items.Add(row[col]);
                }
            }
                
        }

        private void FrmFindServer_Load(object sender, EventArgs e)
        {

        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {

        }
    }
}
