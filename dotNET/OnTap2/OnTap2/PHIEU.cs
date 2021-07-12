using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap2
{
    class SANPHAM
    {
        private string maSP;
        private string tenSP;
        private double sL;
        private float dG;
        public string MaSP{
            set => this.maSP = value;
            get => maSP;
        }
        public string TenSP{
            set => this.tenSP = value;
            get => tenSP;
        }
        public double SL{
            set => this.sL = value;
            get => sL;
        }
        public float dG{
            set => this.dG = value;
            get => dG;
        }
        private double Thanhtien(){
            return this.sL * this.dG;
        }
        public void nhap(){
            Console.Write("Nhập mã sản phẩn: ");
            this.maSP =  Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            this.tenSP = Console.ReadLine();
            Console.Write("Nhập số lượng: ");
            this.sL = double.Parse(Console.ReadLine());
            this.dG = float.Parse(Console.ReadLine());
        }
        private double Thanhtien(){
            return this.sL * this.dG;
        }
        public void xuat(){
            Console.Write($"{this.maSP}, -30" + $"{this.tenSP},-30" + $"{this.sL},-10" + $"{this.dG}, -10" + $"{Thanhtien()}, -15");
        }
    }
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
    class PHIEU
    {
        private string maPhieu;
        private string ngayLap;
        NCC ncc = new NCC();
        private double n;
        SANPHAM sP = new SANPHAM();

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public double N { get => n; set => n = value; }
        internal NCC Ncc { get => ncc; set => ncc = value; }
        internal SANPHAM SP { get => sP; set => sP = value; }

        public void nhap()
        {
            Console.Write("Nhập mã phiếu: ");
            Console.ReadLine(this.MaPhieu);
            Console.Write("Nhập ngày lập: ");
            Console.ReadLine(this.NgayLap);
            this.ncc.nhap();
            Console.Write("Nhập số lượng sản phẩm: ");
            this.n = double.Parse(Console.ReadLine());
            this.sP = new SANPHAM[this.n];
            for(double i; i < this.n; i++)
            {
                this.sP[i].nhap();
            }
        }
        public void xuat()
        {
            Console.WriteLine("Mã phiếu: " + $"{this.maPhieu}, -20" + "Ngày lập: " + $"{this.ngayLap}");
            this.ncc.xuat();
            Console.WriteLine("Mã sản phẩm" + "Tên sản phẩm" + "Số lượng" + "Đơn giá" + "Thành tiền");
            for(double i; i < this.n; i++)
            {
                this.sP[i].xuat();
            }
        }
    }
}