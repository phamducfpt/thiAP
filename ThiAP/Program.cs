using System;

namespace ThiAP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            QuanLySp quanLySp = new QuanLySp();
            while (true)
            {
                Console.WriteLine("\n Chương trình quản lí Sản Phẩm");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1.thêm sản phẩm.");
                Console.WriteLine("2.hiển thị sản phẩm");
                Console.WriteLine("3.xóa sản phẩm");
                Console.WriteLine("4.thoát");
            }
        }
    }
}