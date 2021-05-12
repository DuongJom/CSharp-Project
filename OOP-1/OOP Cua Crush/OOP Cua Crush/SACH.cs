using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cua_Crush
{
    public class SACH
    {
        public string tenSach { get; set; }
        public string tacGia { get; set; }
        public int soTrang { get; set; }
        public double giaBan { get; set; }
        public SACH()
        {
            tenSach = "";
            tacGia = "";
            soTrang = 0;
            giaBan = 0.0f;
        }
        public SACH(string tensach, string tacgia, int trang, double giaban)
        {
            this.tenSach = tensach;
            this.tacGia = tacgia;
            this.soTrang = trang;
            this.giaBan = giaban;
        }
        public SACH(SACH s)
        {
            this.tenSach = s.tenSach;
            this.tacGia = s.tacGia;
            this.soTrang = s.soTrang;
            this.giaBan = s.giaBan;
        }
        public virtual void input()
        {
            Console.Write("\tNhap ten sach: ");
            tenSach = Console.ReadLine();
            Console.Write("\tNhap tac gia: ");
            tacGia = Console.ReadLine();
            Console.Write("\tNhap so trang: ");
            soTrang = int.Parse(Console.ReadLine());
            Console.Write("\tNhap gia ban: ");
            giaBan = double.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.Write("{0}\t\t{1}\t\t{2}\t\t{3}\t\t",tenSach,tacGia,soTrang,giaBan);
        }
    }
}
