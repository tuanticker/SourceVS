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
        Collection con = new Collection();

        Object_T_Phieuxuat t_px = new Object_T_Phieuxuat();
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
            dataGridView1.DataSource = con.UsingDataTable_Get("Select * From Phieuxuat");
        }
        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            get_table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_data();
            if (con.Execute_Non_Querry("Insert into Phieuxuat values('" + t_px.Maphieu + "','" + t_px.Masp + "','" + t_px.Makh + "','" + t_px.Ngayxuat + "','" + t_px.Soluong + "','" + t_px.Dongia + "')"))
            {
                get_table();
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
