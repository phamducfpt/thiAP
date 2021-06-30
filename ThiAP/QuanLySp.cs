using System;
using System.Collections.Generic;

namespace ThiAP
{
    public class QuanLySp
    {
        public List<SanPham> sp = new List<SanPham>();

        private int GenerateID()
        {
            int max = 1;
            if (sp != null && sp.Count > 0)
            {
                max = sp[0].ID;
                foreach (SanPham sP in sp)
                {
                    if (max < sP.ID)
                    {
                        max = sP.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public void NhapSanPham()
        {
            SanPham sanPham = new SanPham();
            Console.WriteLine("Nhập ID Sản Phẩm:");
            sanPham.ID = Console.Read();
            Console.WriteLine("Nhập tên sản phẩm:");
            sanPham.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhập giá sản phẩm:");
            sanPham.Price = Console.Read();
            sp.Add(sanPham);
        }
        public SanPham FindByID(int ID)
        {
            SanPham searchResult = null;
            if (sp != null && sp.Count > 0)
            {
                foreach (SanPham sv in sp)
                {
                    if (sv.ID == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }
        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;
            SanPham sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = sp.Remove(sv);
            }
            return IsDeleted;
        }
    }
}