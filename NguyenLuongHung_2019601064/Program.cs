using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenLuongHung_2019601064
{
    class Program
    {

        static List<NhanVien> list = new List<NhanVien>();
        static void Main(string[] args)
        {
            int chose;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            do
            {
                Menu();
                Console.WriteLine("Nhập lựa chọn:");
                chose = int.Parse(Console.ReadLine());

                switch (chose)
                {
                    case 1:
                        ThemNhanVien();
                        break;
                    case 2:
                        HienThi();
                        break;
                    case 3:
                        TimNhanVien();
                        break;
                    case 4:
                        XoaNhanVien();
                        break;
                    case 0:
                        return;
                }

            } while (true);
        }



        private static void TimNhanVien()
        {
            Console.Write("Nhập mã nhân viên cần tìm:");
            string masv = Console.ReadLine();
            int index = list.IndexOf(new NhanVien(masv));

            if (index == -1)
            {
                Console.WriteLine("Không tìm thấy nhân viên");
            }
            else
            {
                Console.WriteLine("Thông tin nhân viên là:");
                Console.WriteLine(list[index]);
            }
        }

        private static void XoaNhanVien()
        {
            Console.WriteLine("Nhập mã nhân viên cần xóa:");
            string masv = Console.ReadLine();
            int index = list.IndexOf(new NhanVien(masv));

            if (index == -1)
            {
                Console.WriteLine("Không tìm thấy nhân viên");
            }
            else
            {
                list.RemoveAt(index);
                Console.WriteLine("Xóa thành công");
            }
        }

        private static void ThemNhanVien()
        {
            NhanVien st = new NhanVien();
            Console.WriteLine("Nhập thông tin nhân viên:");
            st.InputInfor();
            list.Add(st);
        }
        private static void HienThi()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Không có nhân viên nào");
            }
            else
            {
                foreach (NhanVien item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void Menu()
        {
            Console.WriteLine("===========MENU==========");
            Console.WriteLine("1. Thêm nhân viên");
            Console.WriteLine("2. Hiển thị");
            Console.WriteLine("3. Tìm nhân viên");
            Console.WriteLine("4. Xóa nhân viên");
            Console.WriteLine("0. thoát");
        }
    }
}
