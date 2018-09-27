using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
namespace QLTour
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
           private void Form1_Load(object sender, EventArgs e)
        {
            
            QuanLiTourDuLichEntities ql = new QuanLiTourDuLichEntities();
            object x = ql.NGUOIDUNGs.Select(t => t.TENDANGNHAP).ToList();
        }
    }
}
