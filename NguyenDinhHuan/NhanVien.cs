using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhHuan
{
  public class NhanVien
  {
    private string tenNV;
    private double luongMotGio;
    private int soGioLam;

    public NhanVien(){
        this.tenNV = "";
        this.luongMotGio = 0;
        this.soGioLam = 0;
    }
    public NhanVien(string tenNV, double luongMotGio, int soGioLam)
    {
      this.tenNV = tenNV;
      this.luongMotGio = luongMotGio;
      this.soGioLam = soGioLam;
    }
    public string TenNV { get => tenNV; set => tenNV = value; }
    public double LuongMotGio { get => luongMotGio; set => luongMotGio = value; }
    public int SoGioLam { get => soGioLam; set => soGioLam = value; }
    public double TinhTienLuong()
    {
      return this.soGioLam * this.LuongMotGio;
    }
    public override string ToString()
    {
      return $"{{{nameof(TenNV)}={TenNV}, {nameof(LuongMotGio)}={LuongMotGio.ToString()}, {nameof(SoGioLam)}={SoGioLam.ToString()}, {nameof(TinhTienLuong)}={TinhTienLuong()}}}\n";
    }
  }
}