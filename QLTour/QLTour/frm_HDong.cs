using GUI.DataSet1TableAdapters;
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
    public partial class frm_HDong : Form
    {
        public frm_HDong()
        {
            InitializeComponent();
        }

        private void frm_HDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.HOPDONG' table. You can move, or remove it, as needed.
            //this.hOPDONGTableAdapter.FillBy(this.dataSet1.HOPDONG);
            dataGridView1.DataSource  = new ChiTietHDTableAdapter().GetDataHopDong();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(new ChiTietHDTableAdapter().TK(textBox1.Text).Rows.Count==1)
            {
                dataGridView1.DataSource = new ChiTietHDTableAdapter().TK(textBox1.Text);
            }
        }
    }
}
