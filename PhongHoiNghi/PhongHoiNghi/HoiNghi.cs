using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongHoiNghi
{
    class HoiNghi
    {
        public string maHoiNghi { get; set; }
        public string tenHoiNghi { get; set; }
        public string maLoaiPhong { get; set; }
        public int soNguoi { get; set; }

        public HoiNghi() { }

        public HoiNghi(string ma, string ten, string loai, int sl)
        {
            this.maHoiNghi = ma;
            this.tenHoiNghi = ten;
            this.maLoaiPhong = loai;
            this.soNguoi = sl;
        }
    }
}
