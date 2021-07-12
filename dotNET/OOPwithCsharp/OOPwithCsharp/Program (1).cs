using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; 
            Console.InputEncoding = Encoding.Unicode;
            
            NhanVien nv = new NhanVien();

            nv.Nhap("123", "Nguyễn Đình Huân", 2000, 2);

            nv.Xuat();
            
        }
    }
}
