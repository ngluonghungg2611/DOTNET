using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    class PHIEU
    {
        private string maPhieu;
        private string ngayLap;
        NCC nCC = new NCC();
        private double n;
        SP sP = new SP();

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public NCC NCC { get => nCC; set => nCC = value; }
        public double N { get => n; set => n = value; }
        public SP SP { get => sP; set => sP = value; }

        public void nhap()
        {
            Console.Write("Nhập mã phiếu: ");
            this.MaPhieu =  Console.ReadLine();
            Console.Write("Nhập ngày lập: ");
            this.NgayLap = Console.ReadLine();
            this.nCC.nhap1();
            Console.Write("Nhập số lượng sản phẩm: ");
            this.N = double.Parse(Console.ReadLine());
            this.sP = new SP[this.n];
            for(double i; i < this.N; i++)
            {
                this.sP[i].nhap();
            }
        }
        public void xuat()
        {
            Console.WriteLine("Mã phiếu: " + $"{this.MaPhieu}, -20" + "Ngày lập: " + $"{this.NgayLap}");
            this.ncc.xuat1();
            Console.WriteLine("Mã sản phẩm" + "Tên sản phẩm" + "Số lượng" + "Đơn giá" + "Thành tiền");
            for(double i; i < this.N; i++)
            {
                this.sP[i].xuat();
            }
        }
    }
}