using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiNhom
{
    public class NCC
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Fax { get; set; }

        //
        public NCC(string ma, string ten, string diachi, string sdt, string fax)
        {
            this.MaNCC = ma;
            this.TenNCC = ten;
            this.DiaChi = diachi;
            this.SDT = sdt;
            this.Fax = fax;
        }
    }
}
