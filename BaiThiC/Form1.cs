using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiThiC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
	//form 1 chua menu thuc don
        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.ShowDialog();
        }

        private void phieuXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuXuat px = new PhieuXuat();
            px.ShowDialog();
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.ShowDialog();
        }
    }
}
