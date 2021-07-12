using System;

namespace Baitap
{
    public class NhanVien : Person
    {
        public string Rollno { get; set}
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập mã sinh viên")
        }
        
        
    }
}
