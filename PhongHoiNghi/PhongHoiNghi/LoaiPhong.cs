using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongHoiNghi
{
    class LoaiPhong
    {
        public string maLoaiPhong { get; set; }
        public string tenLoaiPhong { get; set; }

        public LoaiPhong() { }

        public LoaiPhong(string ma, string ten)
        {
            this.maLoaiPhong = ma;
            this.tenLoaiPhong = ten;
        }
    }
}
