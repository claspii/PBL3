using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class YeucauView
    {
        public string Chủ_đề { get; set; }
        public string Nội_dung { get; set; }
        public DateTime Ngày_gửi { get; set; }
        public string CMND_người_gửi { get; set; }  
        public string Tên_người_gửi { get; set; }
        public string Người_nhận { get; set; }
        public string Xử_lý { get; set; }
    }
}
