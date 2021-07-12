using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDinhHuan
{
  class Program
  {
    private static List<NhanVien> list = new List<NhanVien>();
    static void Main(string[] args)
    {
      Console.OutputEncoding = Encoding.Unicode;
      Console.InputEncoding = Encoding.Unicode;
      int choose;
      do
      {
        Console.Clear();
        Console.WriteLine($"1. Nhập thông tin nhân viên");
        Console.WriteLine($"2. Hiển thị danh sách nhân viên");
        Console.WriteLine($"3. Tìm thông tin nhân viên");
        Console.WriteLine($"4. Xóa thông tin nhân viên");
        Console.WriteLine($"5. Thoát");

        Console.Write($"Nhập lựa chọn: ");
        choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
          case 1:
            NhapNhanVienMoi();
            break;
          case 2:
            XuatDanhSachNhanVien();
            Console.ReadLine();
            break;
          case 3:
            TimThongTinNhanVien();
            Console.ReadLine();
            break;
          case 4:
            XoaThongTinNhanVien(); ;
            Console.ReadLine();
            break;
          case 5:
            break;
          default:
            Console.WriteLine($"Không có lựa chọn này");
            Console.WriteLine($"Nhập lại lựa chọn mới !");
            Console.ReadLine();
            break;
        }
      } while (choose != 5);
    }
    private static void NhapNhanVienMoi()
    {
      Console.Write($"Nhập tên nhân viên: ");
      string tenNV = Console.ReadLine();
      Console.Write($"Nhập lương 1 giờ: ");
      double luongMotGio = double.Parse(Console.ReadLine());
      Console.Write($"Nhập số giờ: ");
      int soGio = int.Parse(Console.ReadLine());
      NhanVien nv = new NhanVien(tenNV, luongMotGio, soGio);
      list.Add(nv);
    }

    private static void XuatDanhSachNhanVien()
    {
      foreach (var item in list)
      {
        Console.Write($"{item.ToString()}");
      }
    }
    private static void TimThongTinNhanVien()
    {
      bool check = true;
      Console.Write($"Nhập tên nhân viên cần tìm: ");
      string name = Console.ReadLine();
      foreach (var item in list)
      {
        if (String.Compare(item.TenNV, name, true) == 0)
        {
          check = false;
        }
      }
      if (check)
      {
        Console.WriteLine($"Không có tên nhân viên này");
      }
      else
      {
        Console.WriteLine($"Có tên nhân viên trong danh sách");
        Con
      }
    }
    private static void XoaThongTinNhanVien()
    {
      bool ok = true;
      Console.Write($"Nhập tên nhân viên cần xóa: ");
      string name = Console.ReadLine();
      for (int i = 0; i < list.Count; i++)
      {
        if (String.Compare(name, list[i].TenNV, true) == 0)
        {
          ok = false;
          list.RemoveAt(i);
        }
      }
      if (ok)
      {
        Console.WriteLine($"Không có nhân viên này");
      }
      else
      {
        Console.WriteLine($"Xóa thành công nhân viên này");
      }
    }
  }

}
