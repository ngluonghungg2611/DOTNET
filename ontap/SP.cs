using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ontap
{
    public class SP
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
        public float DG{
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
        public void xuat(){
            Console.Write($"{this.maSP}, -30" + $"{this.tenSP},-30" + $"{this.sL},-10" + $"{this.dG}, -10" + $"{Thanhtien()}, -15");
        }
        
    }
}