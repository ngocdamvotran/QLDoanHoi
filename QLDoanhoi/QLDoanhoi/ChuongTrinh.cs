using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLDoanhoi
{
    public class ChuongTrinh
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Capdo { get; set; }
        public string Thoigian { get; set; }
 
        public ChuongTrinh(string MaChuongTrinh, string TenCT, string CapDoCT, string ThoiGianBD)
        {
            this.Ma = MaChuongTrinh;
            this.Ten = TenCT;
            this.Capdo = CapDoCT;
            this.Thoigian = ThoiGianBD;
        }   
    }
}
