using System;

namespace Baitap
{
    public class Person
    {
        protected string hoten;
        protected string diachi;
        public string Hoten
        {
            set => this.hoten = value;
            get => hoten;
        }
        public string Diachi
        {
            set => this.diachi = value;
            get => diachi;
        }
        public void Input(string hoten, string diachi)
        {
            this.hoten = hoten;
            this.diachi = diachi;
        }
        public void Display()
        {
            Console.WriteLine("Họ và tên: {0}, Địa chỉ: {1}", this.hoten, this.diachi);
        }
    }
}