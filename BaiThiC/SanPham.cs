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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        Collection con = new Collection();

        Object_T_Sanpham t_sp = new Object_T_Sanpham();
        private void get_data()
        {
            t_sp.Masp = txt_msp.Text;
            t_sp.Tensp = txt_ten.Text;
            t_sp.Soluong = Int32.Parse(txt_sl.Text);
            t_sp.Dongia = float.Parse(txt_dongia.Text);
        }

        private void get_table()
        {
            dataGridView1.DataSource = con.UsingDataTable_Get("Select * From Sanpham");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            get_data();
            if (con.Execute_Non_Querry("Insert into Sanpham values('" + t_sp.Masp + "','" + t_sp.Tensp + "','" + t_sp.Soluong + "','" + t_sp.Dongia + "')"))
            {
                get_table();
                MessageBox.Show("Thêm thành công");
            }
            get_table();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            get_table();
        }
    }
}
