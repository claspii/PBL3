using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class LichhenView
    {
        public int ID { get; set; }
        public int STT { get; set; }
        public string Chủ_đề { get; set; }
        public DateTime Ngày_hẹn { get; set; }
        public string CMND_người_hẹn { get; set; }
        public string Tên_người_hẹn { get; set; }
        public string Khung_giờ { get; set; }
        public string Hẹn_với { get; set; }
    }
}
