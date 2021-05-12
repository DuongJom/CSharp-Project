using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cua_Crush
{
    public class SACHVEBIA:SACH
    {
        public string maHinhAnh { get; set; }
        public double tienVe { get; set; }
        public SACHVEBIA():base()
        {
            maHinhAnh = "";
            tienVe = 0.0f;
        }
        public SACHVEBIA(string tensach, string tacgia, int sotrang, double giaban, string mahinhanh, double tienve)
            : base(tensach, tacgia, sotrang, giaban)
        {
            this.maHinhAnh = mahinhanh;
            this.tienVe = tienve;
        }
        public SACHVEBIA(SACHVEBIA sv):base()
        {
            this.maHinhAnh = sv.maHinhAnh;
            this.tienVe = sv.tienVe;
        }
        public override void input()
        {
            base.input();
            Console.Write("\tNhap ma hinh anh: ");
            maHinhAnh = Console.ReadLine();
            Console.Write("\tNhap tien ve: ");
            tienVe = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.Write("{0}\t\t{1}\n", maHinhAnh, tienVe);
        }
    }
}
