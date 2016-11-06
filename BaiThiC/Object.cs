using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiThiC
{
    class Object{}
    public class Object_T_Khachhang
    {
        public string Makh { get; set; }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public string Dienthoai { get; set; }
        public Object_T_Khachhang(){}
        public Object_T_Khachhang(string Makh, string Hoten, string Gioitinh, string Diachi, string Dienthoai)
        {
            this.Makh = Makh;
            this.Hoten = Hoten;
            this.Gioitinh = Gioitinh;
            this.Diachi = Diachi;
            this.Dienthoai = Dienthoai;
        }
    }
    public class Object_T_Phieuxuat
    {
        public string Maphieu { get; set; }
        public string Masp { get; set; }
        public string Makh { get; set; }
        public DateTime Ngayxuat { get; set; }
        public int Soluong { get; set; }
        public float Dongia { get; set; }

        public Object_T_Phieuxuat(){}
        public Object_T_Phieuxuat(string Maphieu, string Masp, string Makh, DateTime Ngayxuat, int Soluong, float Dongia)
        {
            this.Maphieu = Maphieu;
            this.Masp = Masp;
            this.Makh = Makh;
            this.Ngayxuat = Ngayxuat;
            this.Soluong = Soluong;
            this.Dongia = Dongia;
        }
    }
    public class Object_T_Sanpham
    {
        public string Masp { get; set; }
        public string Tensp { get; set; }
        public int Soluong { get; set; }
        public float Dongia { get; set; }
        public Object_T_Sanpham(){}
        public Object_T_Sanpham(string Masp, string Tensp, int Soluong, float Dongia)
        {
            this.Masp = Masp;
            this.Tensp = Tensp;
            this.Soluong = Soluong;
            this.Dongia = Dongia;
        }
    }

}
