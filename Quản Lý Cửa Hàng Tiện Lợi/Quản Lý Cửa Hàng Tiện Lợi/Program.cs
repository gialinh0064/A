using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quản_Lý_Cửa_Hàng_Tiện_Lợi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Thông_tin_Hóa_đơn());
        }
    }
}
