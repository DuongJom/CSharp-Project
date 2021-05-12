using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cua_Crush
{
    class Program
    {
        static void nhapDS(SACHVEBIA[] s, int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Nhap thong tin sach thu {0}:",i+1);
                SACHVEBIA sv = new SACHVEBIA();
                sv.input();
                s[i] = sv;
            }
        }
        static void xuatDS(SACHVEBIA[] s, int n)
        {
            Console.WriteLine("Ten sach\tTac gia\t\tSo trang\tGia ban\t\tMa hinh anh\t\tTien ve");
            for (int i=0;i<n;i++)
            {
                s[i].xuat();
            }
        }
        //Tìm sách theo tên sách
        static void timTheoTenSach(SACHVEBIA[] s, int n, string ten)
        {
            Console.WriteLine("Ten sach\tTac gia\t\tSo trang\tGia ban\t\tMa hinh anh\t\tTien ve");
            int count = 0;
            for (int i=0;i<n;i++)
            {
                if (s[i].tenSach.CompareTo(ten) == 0)
                {
                    s[i].xuat();
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("Khong tim thay ten sach {0} trong danh sach!",ten);
        }
        //Tìm theo tên tác giả
        static void timTheoTacGia(SACHVEBIA[] s, int n, string tacgia)
        {
            Console.WriteLine("Ten sach\tTac gia\t\tSo trang\tGia ban\t\tMa hinh anh\t\tTien ve");
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i].tacGia.CompareTo(tacgia) == 0)
                {
                    s[i].xuat();
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("Khong tim thay ten sach {0} trong danh sach!", tacgia);
        }
        //Tìm theo mã hình ảnh
        static void timTheoMaHinhAnh(SACHVEBIA[] s, int n, string ma)
        {
            Console.WriteLine("Ten sach\t\tTac gia\t\tSo trang\tGia ban\t\tMa hinh anh\t\tTien ve");
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i].maHinhAnh.CompareTo(ma) == 0)
                {
                    s[i].xuat();
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("Khong tim thay ten sach {0} trong danh sach!", ma);
        }
        //Sắp xếp theo thứ tự tên sách tăng dần
        static void sapXepTenSachTangDan(SACHVEBIA[] s, int n)
        {
            for(int i=0;i<n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (s[i].tenSach.CompareTo(s[j].tenSach) > 0)
                    {
                        SACHVEBIA tmp = new SACHVEBIA();
                        tmp = s[i];
                        s[i] = s[j];
                        s[j] = tmp;
                    }
                }
            }
        }

        //Sắp xếp theo thứ tự tên tác giả tăng dần
        static void sapXepTacGiaTangDan(SACHVEBIA[] s, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i].tacGia.CompareTo(s[j].tacGia) > 0)
                    {
                        SACHVEBIA tmp = new SACHVEBIA();
                        tmp = s[i];
                        s[i] = s[j];
                        s[j] = tmp;
                    }
                }
            }
        }
        //Sắp xếp theo thứ tự số trang tăng dần
        static void sapXepSoTrangTangDan(SACHVEBIA[] s, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i].soTrang> s[j].soTrang)
                    {
                        SACHVEBIA tmp = new SACHVEBIA();
                        tmp = s[i];
                        s[i] = s[j];
                        s[j] = tmp;
                    }
                }
            }
        }
        //Sắp xếp theo thứ tự giá bán tăng dần
        static void sapXepGiaBanTangDan(SACHVEBIA[] s, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i].giaBan > s[j].giaBan)
                    {
                        SACHVEBIA tmp = new SACHVEBIA();
                        tmp = s[i];
                        s[i] = s[j];
                        s[j] = tmp;
                    }
                }
            }
        }
        //Sắp xếp theo thứ tự mã hình ảnh tăng dần
        static void sapXepMaHATangDan(SACHVEBIA[] s, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i].giaBan.CompareTo(s[j].giaBan)>0)
                    {
                        SACHVEBIA tmp = new SACHVEBIA();
                        tmp = s[i];
                        s[i] = s[j];
                        s[j] = tmp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sach: ");
            int n = int.Parse(Console.ReadLine());
            SACHVEBIA[] s = new SACHVEBIA[n];
            
            Console.WriteLine("====================NHAP DANH SACH SACH VE BIA==================");
            nhapDS(s, n);
            Console.WriteLine("=======================DANH SACH SACH VE BIA====================");
            xuatDS(s, n);
            Console.WriteLine("=======================TIM KIEM SACH VE BIA====================");
            Console.Write("Nhap ten sach can tim: ");
            string ten = Console.ReadLine();
            timTheoTenSach(s, n, ten);
            Console.Write("Nhap ten tac gia can tim: ");
            string tacgia = Console.ReadLine();
            timTheoTacGia(s, n, tacgia);
            Console.Write("Nhap ma hinh anh can tim: ");
            string ma = Console.ReadLine();
            timTheoMaHinhAnh(s, n, ma);
            Console.WriteLine("=======================DANH SACH SAU SAP XEP====================");
            sapXepGiaBanTangDan(s, n);
            xuatDS(s, n);
            Console.ReadKey();
        }
    }
}
