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
    public partial class PhieuXuat : Form
    {
        public PhieuXuat()
        {
            InitializeComponent();
        }
        layer.BUS.Phieuxuat px = new layer.BUS.Phieuxuat();
        layer.DTO.Object_T_Phieuxuat t_px = new layer.DTO.Object_T_Phieuxuat();
        private void get_data()
        {
            t_px.Maphieu = txt_mps.Text;
            t_px.Masp = txt_mps.Text;
            t_px.Makh = txt_makh.Text;
            t_px.Ngayxuat = dateTimePicker1.Value;
            t_px.Soluong = Int32.Parse(txt_sl.Text);
            t_px.Dongia = float.Parse(txt_dongia.Text);
        }

        private void get_table()
        {
            dataGridView1.DataSource = px.GetTable();
        }
        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            get_table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_data();
            if (px.Insert(t_px))
            {
                get_table();
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
