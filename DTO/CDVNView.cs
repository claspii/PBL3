using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class CDVNView 
    {
        public string CMND { get; set; }
        public string Họ_Tên { get; set; }
        public DateTime Ngày_sinh { get; set; }
        public string Địa_Chỉ { get; set; }
        public string Trạng_thái_hôn_nhân { get; set; }
        public string Giới_Tính { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string Tiền_án { get; set; }
        public string Chủ_hộ { get; set; }
        public override string ToString()
        {
            return CMND + " " + Họ_Tên + " " + Địa_Chỉ + " " + Email + " " + SDT;
        }

    }
}
