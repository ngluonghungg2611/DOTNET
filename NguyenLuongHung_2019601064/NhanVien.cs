using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLuongHung_2019601064
{
    class NhanVien
    {
        string manv, tennv;
        double luong;
        int soGio;

        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public double Luong { get => luong; set => luong = value; }
        public int SoGio { get => soGio; set => soGio = value; }

        public NhanVien()
        {

        }
        public NhanVien(string manv, string tennv, double luong, int soGio)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.luong = luong;
            this.SoGio = soGio;

        }
        public NhanVien(string manv)
        {
            this.manv = manv;
        }
        public void InputInfor()
        {
            Console.Write("Nhập mã nhân viên:");
            manv = Console.ReadLine();
            Console.Write("Nhập tên nhân viên:");
            tennv = Console.ReadLine();
            Console.Write("Nhập lương 1 giờ:");
            luong = Double.Parse(Console.ReadLine());
            Console.Write("Nhập  giờ:");
            soGio = int.Parse(Console.ReadLine());
        }
        public double TinhLuong()
        {
            return luong * soGio;
        }
        public override bool Equals(object obj)
        {
            NhanVien st = (NhanVien)obj;
            return st.manv.Equals(manv);
        }

        public override string ToString()
        {
            return "manv: " + manv + "  ten: " + tennv + "  lương : " + TinhLuong();
        }
       
    }
}