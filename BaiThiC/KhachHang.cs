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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        Collection con = new Collection();

        Object_T_Khachhang t_kh = new Object_T_Khachhang();
        private void get_data()
        {
            t_kh.Makh = txt_mkh.Text;
            t_kh.Hoten = txt_hoten.Text;
            t_kh.Gioitinh = txt_gioitinh.Text;
            t_kh.Diachi = txt_diachi.Text;
            t_kh.Dienthoai = txt_dienthoia.Text;
        }

        private void get_table()
        {
            dataGridView1.DataSource = con.UsingDataTable_Get("Select * From Khachhang");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_data();
            if (con.Execute_Non_Querry("Insert into Khachhang values('" + t_kh.Makh + "','" + t_kh.Hoten + "','" + t_kh.Gioitinh + "','" + t_kh.Diachi + "','" + t_kh.Dienthoai + "')");
            ){
                get_table();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            get_table();
        }









    }
}
