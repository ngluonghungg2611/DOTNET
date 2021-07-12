using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class NCC
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string sDT;

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        
        public void nhap(){
            Console.Write("Nhập mã nhà cùng cấp: ");
            this.maNCC = Console.ReadLine();
            Console.Write("Nhập tên nhà cùng cấp: ");
            this.tenNCC = Console.ReadLine();
            Console.Write("Nhập địa chỉ nhà cùng cấp: ");
            this.diaChi = Console.ReadLine();
            Console.Write("Nhập SĐT nhà cùng cấp: ");
            this.sDT = Console.ReadLine();
        }
        public void xuat(){
            Console.WriteLine("Mã nhà cùng cấp: " + $"{this.maNCC}, -20" + "Tên nhà cung cấp: " + $"{this.tenNCC}");
            Console.WriteLine("Địa chỉ: " + $"{this.diaChi}, -20" + "SĐT: " + $"{this.sDT}");
        }
    }
}