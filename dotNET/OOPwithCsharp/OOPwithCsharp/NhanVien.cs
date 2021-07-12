using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    public class NhanVien
    {
        private string maNV;
        private string tenNV;
        private double luongMotGio;
        private int soGio;
        public string MaNV {
            set => this.maNV = value;
            get => maNV;
        }
        public string TenNV {
            set => this.tenNV = value;
            get => tenNV;
        }
        public double LuongMotGio {
            set => this.luongMotGio = value;
            get => luongMotGio;
        }
        public int SoGio {
            set => this.soGio = value;
            get => soGio;
        }

        private double TinhLuong(){
            return this.soGio * this.luongMotGio;
        }

        public void Nhap(string maNV, string tenNV, double luongMotGio, int soGio){
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.LuongMotGio = luongMotGio;
            this.SoGio = soGio;
        }

        public void Xuat() {
            Console.WriteLine($"{this.MaNV} - {this.TenNV} - {this.luongMotGio} - {this.SoGio} - {this.TinhLuong()}");
        }

        
    }
}