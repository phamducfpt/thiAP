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
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1.thêm sản phẩm.");
                        quanLySp.NhapSanPham();
                        Console.WriteLine("\nThêm thông tin thành công");
                        break;
                    case 2:
                        int id;
                            Console.WriteLine("\n3. Xóa sản phẩm.");
                            Console.Write("\nNhập ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                        if (quanLySp.DeleteById(id))
                        {
                            Console.WriteLine("\n Xóa thành công");
                        }

                        break;
            }
        }
    }
}