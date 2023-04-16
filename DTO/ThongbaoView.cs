using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class ThongbaoView
    {
        public int ID { get; set; }
        public string ID_CQTQ { get; set; }
        public string Chủ_đề { get; set; }
        public DateTime Ngày_gửi { get; set; }
        public string Người_gửi { get; set; }
    }
}
