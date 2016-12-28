using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiNhom
{
    public class Employees
    {
        public string MaNV { get; set; }
        public string HoNV { get; set; }
        public string Ten { get; set; }
        public string QueQuan { get; set; }
        public string SDT { get; set; }

        //
        public Employees(string ma, string ho, string ten, string qq, string sdt)
        {
            this.MaNV = ma;
            this.HoNV = ho;
            this.Ten = ten;
            this.QueQuan = qq;
            this.SDT = sdt;
        }
    }
}
