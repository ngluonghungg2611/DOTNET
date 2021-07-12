using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace nguyenluonghung
{
    public class NHANVIEN
    {
        private string maNhanVien;
        private string tenNhanVien;
        private double luong;
        private double soGio;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public double Luong { get => luong; set => luong = value; }
        public double SoGio { get => soGio; set => soGio = value; }

        public double TienLuong(){
            return luong*soGio;
        }
        public void nhap(){
            Console.Write("Nhap ma nhan vien: ");
            maNhanVien = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: ");
            tenNhanVien = Console.ReadLine();
            Console.Write("Nhap luong nhan vien trong 1 gio: ");
            luong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so gio lam viec: ");
            soGio = double.Parse(Console.ReadLine());
        }
        public void xuat(){
            Console.WriteLine("Ma nhan vien: " + $"{maNhanVien}");
            Console.WriteLine("Ten nhan vien: " + $"{tenNhanVien}");
            Console.WriteLine("Luong nhan vien trong 1h: " + $"{luong}");
            Console.WriteLine("So gio lam viec: " + $"{soGio}");
            Console.WriteLine("Luong nhan vien: " + $"{TienLuong()}");
        }
    }
}