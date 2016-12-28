using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    public class NhanVien
    {
        public String MaNV { get; set; }
        public string HoNV { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string QueQuan { get; set; }

        //
        public NhanVien(string id, string lastName, string firstName, string phone, string home)
        {
            this.MaNV = id;
            this.HoNV = lastName;
            this.Ten = firstName;
            this.SDT = phone;
            this.QueQuan = home;
        }

    }

}
