using System;

namespace nguyenluonghung
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int chon;
            do
            {

                Console.WriteLine("***************MAIN MENU**********");
                Console.WriteLine("*******THONG TIN SINH VIEN********");
                Console.WriteLine("1.   Nhap thong tin");
                Console.WriteLine("2.   Danh sach sinh vien");
                Console.WriteLine("3.   Tim nhan vien");
                Console.WriteLine("4.   Xoa nhan vien");
                Console.WriteLine("5.   Thoat");
                Console.Write("    NHAP LUA  CHON CUA BAN VAO:");

                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap so sinh vien nhap: ");
                        double n = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap thong tin");
                        for(double i; i < n; i++)
                        {
                            nv[i] = new NHANVIEN;
                            nv[i].nhap();
                        }
                        break;

                    case 2:
                        Console.Write("NHAP VAO CHIEU DAI:");
                        float dai = float.Parse(Console.ReadLine());
                        Console.Write("NHAP VAO CHIEU RONG:");
                        float rong = float.Parse(Console.ReadLine());
                        Console.WriteLine("CHU VI HINH CHU NHAT {0}", (dai + rong) * 2);
                        Console.WriteLine("DIEN TICH HINH CHU NHAT {0}", dai * rong);
                        break;

                    case 3:
                        Console.Write("NHAP VAO CHIEU DAI 1 CANH:");
                        float chieudai1canh = float.Parse(Console.ReadLine());
                        Console.WriteLine("CHU VI HINH VUONG {0}", chieudai1canh * 4);
                        Console.WriteLine("DIEN TICH HINH VUONG {0}", chieudai1canh * chieudai1canh);
                        break;

                    case 4:
                        break;
                    default:
                        Console.WriteLine("vui long nhap lai");
                        break;



                }

            } while (chon != 4);
            Console.ReadLine();
        }
    }
}
