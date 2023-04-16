using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using System.Data;

namespace PBL3.BLL
{
    public class BLL_QLCD
    {
        private PBL3 db = new PBL3();

        public static BLL_QLCD Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLCD();
                }
                return _Instance;
            }
            private set { }
        }
        private static BLL_QLCD _Instance;

        public BLL_QLCD()
        {

        }
        public List<AccountView> ToView_Account(List<Account> list)
        {
            List<AccountView> li = new List<AccountView>();
            foreach (Account a in list)
            {
                li.Add(new AccountView
                {
                    CMND = a.username,
                    Loại_tài_khoản = a.account_type == 2 ? "Công dân" : "Cán bộ"
                });
            }
            return li;
        }
        public List<CDVNView> ToView_CDVN(List<CDVN> list)
        {
            List<CDVNView> li = new List<CDVNView>();
            foreach (CDVN c in list)
            {
                li.Add(new CDVNView
                {
                    CMND = c.ID_CD,
                    Họ_Tên = c.HoTenCD,
                    Ngày_sinh = c.NgaySinhCD.Value,
                    Địa_Chỉ = c.DiaChi_CD,
                    Trạng_thái_hôn_nhân = c.TT_hn,
                    Giới_Tính = c.GioiTinh,
                    Email = c.Email_CD,
                    SDT = c.SDT_CD,
                    Tiền_án = c.TATS,
                    Chủ_hộ = c.ID_Chuho != c.ID_CD ? (db.CDVNs.Find(c.ID_Chuho) != null ? db.CDVNs.Find(c.ID_Chuho).HoTenCD : "") : "Chủ hộ",
                });
            }
            return li;
        }
        public int Check_dt(string ID)
        {
            if (db.CDVNs.Find(ID) != null)
                return 1;
            else if (db.LDVNs.Find(ID) != null)
                return 2;
            else if (db.CQTQs.Find(ID) != null)
                return 3;
            return 0;
        }
        public List<CQTQView> ToView_CQTQ(List<CQTQ> list)
        {
            List<CQTQView> li = new List<CQTQView>();
            foreach (CQTQ c in list)
            {
                li.Add(new CQTQView
                {
                    ID = c.ID_CQTQ,
                    Tên_cơ_quan = c.Name_CQTQ + " " + c.TT.Insert(0, c.TT[0].ToString().ToLower()).Remove(1, 1),
                    Địa_chỉ = c.DiaChi,
                    Email = c.Email,
                    SDT = c.SDT
                });
            }
            return li;
        }
        public List<LDVNView> ToView_LDVN(List<LDVN> list)
        {
            List<LDVNView> li = new List<LDVNView>();
            foreach (LDVN l in list)
            {
                li.Add(new LDVNView
                {
                    CMND = l.ID_LD,
                    Họ_Tên = l.HoTenLD,
                    Ngày_sinh = l.NgaySinhLD.Value,
                    Giới_Tính = l.GioiTinh,
                    Chức_vụ = l.Chucvu,
                    Tên_cơ_quan = l.CQTQ.Name_CQTQ + " " + l.CQTQ.TT.Insert(0, l.CQTQ.TT[0].ToString().ToLower()).Remove(1, 1)
                });
            }
            return li;
        }
        public List<LichhenView> ToView_Lichhen(List<Lichhen> list)
        {
            List<LichhenView> li = new List<LichhenView>();
            foreach (Lichhen l in list)
            {
                li.Add(new LichhenView
                {
                    ID = l.ID_Lichhen,
                    STT = GetSTTLichhen(l),
                    Chủ_đề = l.Title,
                    Ngày_hẹn = l.Date_hen.Value.Date,
                    Khung_giờ = l.Time,
                    CMND_người_hẹn = l.ID_CD,
                    Tên_người_hẹn = l.CDVN.HoTenCD,
                    Hẹn_với = l.CQTQ.Name_CQTQ + " " + l.CQTQ.TT.Insert(0, l.CQTQ.TT[0].ToString().ToLower()).Remove(1, 1)
                });
            }
            return li;
        }
        public List<ThongbaoView> ToView_Thongbao(List<Thongbao> list)
        {
            List<ThongbaoView> li = new List<ThongbaoView>();
            foreach (Thongbao t in list)
            {
                li.Add(new ThongbaoView
                {
                    ID = t.ID_Thongbao,
                    ID_CQTQ = t.ID_CQTQ,
                    Chủ_đề = t.Title,
                    Ngày_gửi = t.Date_sent.Value,
                    Người_gửi = t.CQTQ.Name_CQTQ + " " + t.CQTQ.TT.Insert(0, t.CQTQ.TT[0].ToString().ToLower()).Remove(1, 1),
                });
            }
            return li;
        }
        public List<YeucauView> ToView_Yeucau(List<Yeucau> list)
        {
            List<YeucauView> li = new List<YeucauView>();
            foreach (Yeucau y in list)
            {
                li.Add(new YeucauView
                {
                    Chủ_đề = y.Title,
                    Nội_dung = y.ND,
                    Ngày_gửi = y.Date_sent.Value,
                    CMND_người_gửi = y.ID_1,
                    Tên_người_gửi = y.CDVN.HoTenCD,
                    Người_nhận = y.CQTQ.Name_CQTQ + " " + y.CQTQ.TT.Insert(0, y.CQTQ.TT[0].ToString().ToLower()).Remove(1, 1),
                    Xử_lý = y.Solved == true ? "Đã xử lý" : "Chưa xử lý"
                });
            }
            return li;
        }
        public List<YkienView> ToView_Ykien(List<Ykien> list)
        {
            List<YkienView> li = new List<YkienView>();
            foreach (Ykien y in list)
            {
                li.Add(new YkienView
                {
                    Chủ_đề = y.Title,
                    Nội_dung = y.ND,
                    Ngày_gửi = y.Date_sent.Value,
                    CMND_người_gửi = y.ID_CD,
                    Tên_người_gửi = y.CDVN.HoTenCD,
                    Người_nhận = db.CQTQs.Find(y.ID) != null ?
                    db.CQTQs.Find(y.ID).Name_CQTQ + " " + db.CQTQs.Find(y.ID).TT.Insert(0, db.CQTQs.Find(y.ID).TT[0].ToString().ToLower()).Remove(1, 1)
                    : "Admin"
                });
            }
            return li;
        }
        public List<FreeTimeView> ToView_FreeTime(List<FreeTime> list)
        {
            List<FreeTimeView> li = new List<FreeTimeView>();
            foreach (FreeTime i in list)
            {
                li.Add(new FreeTimeView
                {
                    ID = i.ID_FreeTime,
                    Mở = i.Start_time.Value.ToString(@"hh\:mm"),
                    Đóng = i.End_time.Value.ToString(@"hh\:mm"),
                    Max = i.Max_per.Value
                });
            }
            return li;
        }
        public bool Check_Edit(string ID_CD)
        {
            return (GetCDVNbyID(ID_CD) != null);
        }
        public bool Check_Edit_LDVN(string ID_LD)
        {
            return (GetLDVNbyID(ID_LD)) != null;
        }
        public CDVN GetCDVNbyID(string ID)
        {
            return db.CDVNs.Find(ID);
        }
        public List<CDVN> Search_CDVN(string TP, string QH, string PX, string txt)
        {
            List<CDVN> li = new List<CDVN>();
            if (TP == "All")
                TP = "";
            if (QH == "All")
                QH = "";
            if (PX == "All")
                PX = "";
            foreach (CDVN c in db.CDVNs)
            {
                if (c.DiaChi_CD.ToUpper().Contains(TP.ToUpper()) && c.DiaChi_CD.ToUpper().Contains(QH.ToUpper())
                    && c.DiaChi_CD.ToUpper().Contains(PX.ToUpper()) && (c.ID_CD + c.HoTenCD + c.DiaChi_CD + c.Email_CD + c.SDT_CD).Contains(txt))
                    li.Add(c);
            }
            return li;
        }
        public List<string> GetListIDCDVN(string TP, string QH, string PX)
        {
            List<string> li = new List<string>();
            foreach (CDVN c in Search_CDVN(TP, QH, PX, ""))
            {
                li.Add(c.ID_CD);
            }
            return li;
        }
        public Account Login(string username, string password)
        {
            foreach (Account a in db.Accounts)
            {
                if (a.username == username && a.password == password)
                    return a;
            }
            return null;
        }
        public bool check_valid_username(string username)
        {
            if (username.Equals("")) return false;
            int len = username.Length;
            const string valid = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_";
            for (int i = 0; i < len; i++)
            {
                if (valid.IndexOf(username[i]) < 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool check_valid_password(string password)
        {
            return (password.Length >= 5);
        }
        public void change_password(Account a, string new_password)
        {
            Account a1 = db.Accounts.Find(a.username);
            a1.password = new_password;
            a.password = new_password;
            db.SaveChanges();
        }
        public List<CDVN> GetCDVNbyIDchuho(string ID)
        {
            List<CDVN> li = new List<CDVN>();
            foreach (CDVN i in db.CDVNs)
            {
                if (i.ID_Chuho == ID)
                    li.Add(i);
            }
            return li;
        }
        public List<string> GetTP()
        {
            var l = db.Maps.Where(p => p.DiaChi1.Contains("Tỉnh") || p.DiaChi1.Contains("Thành phố")).Select(p => p.DiaChi1.ToString());
            return l.Distinct().ToList();
        }
        public List<string> GetQHbyTP(string TP)
        {
            var l = db.Maps.Where(p => p.DiaChi1 == TP).Select(p => p.DiaChi2.ToString());
            return l.ToList();
        }
        public List<string> GetPXbyQH(string QH)
        {
            var l = db.Maps.Where(p => p.DiaChi1 == QH).Select(p => p.DiaChi2.ToString());
            return l.ToList();
        }
        public List<string> GetCBBItems(string txt, string name)
        {
            List<string> list = new List<string>();
            switch (txt)
            {
                case "TP":
                    return GetTP();
                case "QH":
                    {
                        foreach (string s in GetQHbyTP(name))
                            list.Add(s);
                        return list;
                    }
                case "PX":
                    {
                        foreach (string s in GetPXbyQH(name))
                            list.Add(s);
                        return list;
                    }
                default:
                    break;
            }
            return list;
        }
        public List<CQTQ> Search_CQTQ(string address, string txt1, string txt2)
        {
            if (!address.Contains(txt1) && !address.Contains(txt2))
                return GetAllCQTQ(address, txt1, txt2);
            List<CQTQ> li = new List<CQTQ>();
            foreach (CQTQ c in db.CQTQs)
            {
                if (c.TT == address)
                    li.Add(c);
            }
            return li;
        }

        public List<CQTQ> GetAllCQTQ(string address, string txt1, string txt2)
        {
            List<CQTQ> li = new List<CQTQ>();
            foreach (Map m in db.Maps)
            {
                if (m.DiaChi1 == address && (m.DiaChi2.Contains(txt1) || m.DiaChi2.Contains(txt2)))
                    if (GetCQTQbyTT(m.DiaChi2) != null)
                        li.AddRange(GetCQTQbyTT(m.DiaChi2));
            }
            return li;
        }
        public List<CQTQ> GetAllCQTQ()
        {
            return db.CQTQs.ToList();
        }
        public List<LDVN> GetAllLDVN()
        {
            return db.LDVNs.ToList();
        }
        public List<CQTQ> GetAllTP()
        {
            List<CQTQ> li = new List<CQTQ>();
            foreach (CQTQ c in db.CQTQs)
            {
                if (c.TT.Contains("Tỉnh") || c.TT.Contains("Thành phố"))
                    li.Add(c);
            }
            return li;
        }
        public CQTQ GetCQTQbyID(string ID)
        {
            foreach (CQTQ c in db.CQTQs)
            {
                if (c.ID_CQTQ == ID)
                    return c;
            }
            return null;
        }
        public List<CQTQ> GetCQTQbyTT(string TT)
        {
            List<CQTQ> li = new List<CQTQ>();
            foreach (CQTQ c in db.CQTQs)
            {
                if (c.TT == TT)
                    li.Add(c);
            }
            return li;
        }
        public CQTQ GetCQTQbyNameTT(string name, string txt)
        {
            foreach (CQTQ c in db.CQTQs)
            {
                if (c.Name_CQTQ == name && c.TT == txt)
                    return c;
            }
            return null;
        }
        public LDVN GetLDVNbyID(string ID)
        {
            foreach (LDVN l in db.LDVNs)
            {
                if (l.ID_LD == ID)
                    return l;
            }
            return null;
        }
        public List<LDVN> GetLDVNbyCQTQ(string ID)
        {
            List<LDVN> li = new List<LDVN>();
            foreach (LDVN l in db.LDVNs)
            {
                if (l.ID_CQTQ == ID)
                    li.Add(l);
            }
            return li;
        }
        public string GetUpperCBBDiaChi(string address)
        {
            foreach (Map m in db.Maps)
                if (m.DiaChi2 == address)
                    return m.DiaChi1;
            return null;
        }
        public void Add_Edit_CDVN(CDVN c)
        {
            if (Check_Edit(c.ID_CD))
            {
                CDVN c1 = db.CDVNs.Find(c.ID_CD);
                c1.HoTenCD = c.HoTenCD;
                c1.NgaySinhCD = c.NgaySinhCD.Value;
                c1.GioiTinh = c.GioiTinh;
                c1.TT_hn = c.TT_hn;
                c1.DiaChi_CD = c.DiaChi_CD;
                c1.Email_CD = c.Email_CD;
                c1.SDT_CD = c.SDT_CD;
                c1.TATS = c.TATS;
                c1.ID_Chuho = c.ID_Chuho;
                c1.Anh = c.Anh;
                db.SaveChanges();
            }
            else
            {
                Account temp = new Account
                {
                    username = c.ID_CD,
                    password = c.ID_CD,
                    account_type = 2
                };
                db.Accounts.Add(temp);
                db.CDVNs.Add(c);
                db.SaveChanges();
            }

        }
        public void Add_Edit_LDVN(LDVN l)
        {
            if (Check_Edit_LDVN(l.ID_LD))
            {
                LDVN l1 = db.LDVNs.Find(l.ID_LD);
                l1.HoTenLD = l.HoTenLD;
                l1.NgaySinhLD = l.NgaySinhLD.Value;
                l1.GioiTinh = l.GioiTinh;
                l1.DiaChi_LD = l.DiaChi_LD;
                l1.Email_LD = l.Email_LD;
                l1.SDT_LD = l.SDT_LD;
                l1.Anh = l.Anh;
                db.SaveChanges();
            }
            else
            {
                Account temp = new Account
                {
                    username = l.ID_LD,
                    password = l.ID_LD,
                    account_type = 3
                };
                db.Accounts.Add(temp);
                db.LDVNs.Add(l);
                db.SaveChanges();
            }
        }
        public int MaxIDNoti()
        {
            int Max = 0;
            foreach (Thongbao t in db.Thongbaos)
            {
                if (t.ID_Thongbao > Max)
                    Max = t.ID_Thongbao;
            }
            return Max;
        }
        public void Add_noti(List<Thongbao> li)
        {
            foreach (Thongbao t in li)
            {
                t.ID_Thongbao = MaxIDNoti() + 1;
                db.Thongbaos.Add(t);
                db.SaveChanges();
            }
        }
        public bool Check_newNoti(string ID_CD)
        {
            bool res = false;
            int count = 0;
            CDVN c = db.CDVNs.Find(ID_CD);
            foreach (Thongbao t in db.Thongbaos)
            {
                if (t.ID_CD == ID_CD)
                    count++;
            }
            if (c.Noti_count == null)
            {
                if (count != 0)
                    res = true;
            }
            else if (c.Noti_count < count)
                res = true;
            return res;
        }
        public void Seen_Noti(string ID_CD)
        {
            CDVN c = db.CDVNs.Find(ID_CD);
            int count = 0;
            foreach (Thongbao t in db.Thongbaos)
            {
                if (t.ID_CD == ID_CD)
                    count++;
            }
            c.Noti_count = count;
            db.SaveChanges();
        }
        public Thongbao GetNotibyID(int ID)
        {
            return db.Thongbaos.Find(ID);
        }
        public void Del_Noti(int ID)
        {
            Thongbao t = db.Thongbaos.Find(ID);
            db.Thongbaos.Remove(t);
            db.SaveChanges();
        }
        public List<Thongbao> GetListThongbaobyIDCD(string ID)
        {
            List<Thongbao> li = new List<Thongbao>();
            foreach (Thongbao t in db.Thongbaos)
            {
                if (t.ID_CD == ID)
                    li.Add(t);
            }
            return li;
        }
        public List<Thongbao> GetListNotiYkienbyIDCD(string ID)
        {
            List<Thongbao> li = new List<Thongbao>();
            foreach (Thongbao t in db.Thongbaos)
            {
                if (t.ID_CD == ID && t.Title == "Lấy ý kiến nhân dân")
                    li.Add(t);
            }
            return li;
        }
        public List<string> GetAllNameCQTQ()
        {
            List<string> li = new List<string>();
            foreach (CQTQ c in db.CQTQs)
            {
                li.Add(c.Name_CQTQ);
            }
            return li;
        }
        public List<string> GetAllName_CQTQ()
        {
            List <string> li = new List<string>();
            foreach (Nhiemvu n in db.Nhiemvus)
            {
                li.Add(n.Name_CQTQ);
            }
            return li;
        }
        public List<string> GetCQTQbyNV(string NV)
        {
            List<string> li = new List<string>();
            foreach (Nhiemvu n in db.Nhiemvus)
            {
                if (n.NV.ToUpper().Contains(NV.ToUpper()))
                    li.Add(n.Name_CQTQ);

            }
            return li;
        }
        public List<string> GetCBBDiaChibyID(string ID)
        {
            CDVN c = GetCDVNbyID(ID);
            List<string> li = new List<string>();
            foreach (Map m in db.Maps)
            {
                if (c.DiaChi_CD.ToUpper().Contains(m.DiaChi1.ToUpper()) && c.DiaChi_CD.ToUpper().Contains(m.DiaChi2.ToUpper()))
                {
                    li.Add(m.DiaChi1);
                    li.Add(m.DiaChi2);
                }
            }
            return li;
        }
        public string GetIDCQTQbyNameTT(string Name, string TT)
        {
            foreach (CQTQ c in db.CQTQs)
            {
                if (c.Name_CQTQ == Name && c.TT == TT)
                    return c.ID_CQTQ;
            }
            return null;
        }
        public void Del_CD(string ID_CD)
        {
            CDVN c = db.CDVNs.Find(ID_CD);
            foreach (Thongbao i in db.Thongbaos)
                if (i.ID_CD == ID_CD) db.Thongbaos.Remove(i);
            foreach (Ykien i in db.Ykiens)
                if (i.ID_CD == ID_CD) db.Ykiens.Remove(i);
            foreach (Lichhen i in db.Lichhens)
                if (i.ID_CD == ID_CD) db.Lichhens.Remove(i);
            foreach (Yeucau i in db.Yeucaus)
                if (i.ID_1 == ID_CD) db.Yeucaus.Remove(i);
            foreach (Account i in db.Accounts)
                if (i.username == ID_CD) db.Accounts.Remove(i);
            db.CDVNs.Remove(c);
            db.SaveChanges();
        }
        public int MaxIDYeucau()
        {
            int Max = 0;
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_Yeucau > Max)
                    Max = y.ID_Yeucau;
            }
            return Max;
        }
        public void Add_request(Yeucau y)
        {
            y.ID_Yeucau = MaxIDYeucau() + 1;
            y.Solved = false;
            y.Accepted = false;
            db.Yeucaus.Add(y);
            db.SaveChanges();
        }
        public bool CheckEditCDVN(string ID_CD)
        {
            string txt = "Yêu cầu thay đổi, chỉnh sửa thông tin";
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_1 == ID_CD && y.Title == txt && y.Solved == true && y.Accepted == false)
                    return true;
            }
            return false;
        }
        public void SetEdited(string ID_CD)
        {
            string txt = "Yêu cầu thay đổi, chỉnh sửa thông tin";
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_1 == ID_CD && y.Title == txt && y.Solved == true)
                {
                    y.Accepted = true;
                    break;
                }
            }
            db.SaveChanges();
        }
        public List<Yeucau> GetYeucaubyIDCQTQ(string ID)
        {
            List<Yeucau> li = new List<Yeucau>();
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_2 == ID && y.Solved == false)
                    li.Add(y);
            }
            return li;
        }
        public List<Yeucau> GetSolvedYeucaubyIDCQTQ(string ID)
        {
            List<Yeucau> li = new List<Yeucau>();
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_2 == ID && y.Solved == true)
                    li.Add(y);
            }
            return li;
        }
        public bool Check_ExistsYeuCau(string ID, string txt)
        {
            foreach (Yeucau c in db.Yeucaus)
            {
                if (c.ID_1 == ID && c.Title == txt && c.Solved == false)
                    return true;
            }
            return false;
        }
        public void Del_Yeucau(string ID, string txt)
        {
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_1 == ID && y.Title.Contains(txt))
                {
                    db.Yeucaus.Remove(y);
                    break;
                }
            }
            db.SaveChanges();
        }
        public void Solve_Yeucau(string ID, string txt)
        {
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_1 == ID && y.Title == txt && y.Solved == false)
                {
                    y.Solved = true;
                    break;
                }
            }
            db.SaveChanges();
        }
        public List<CBBItem> GetUpperCBBItem(CQTQ c)
        {
            List<CBBItem> li = new List<CBBItem>();
            if (c.TT.Contains("Thành phố"))
            {
                CQTQ c1 = GetCQTQbyNameTT(c.Name_CQTQ, "Trung ương");
                if (c1 != null)
                {
                    string txt = c1.TT;
                    txt = txt.Insert(0, txt[0].ToString().ToLower());
                    txt = txt.Remove(1, 1);
                    li.Add(new CBBItem { Value = c1.ID_CQTQ, Text = c1.Name_CQTQ + " " + txt });
                    return li;
                }
            }
            foreach (Map m in db.Maps)
            {
                if (m.DiaChi2 == c.TT)
                {
                    CQTQ c1 = GetCQTQbyNameTT(c.Name_CQTQ, m.DiaChi1);
                    if (c1 != null)
                    {
                        string txt = c1.TT;
                        txt = txt.Insert(0, txt[0].ToString().ToLower());
                        txt = txt.Remove(1, 1);
                        li.Add(new CBBItem { Value = c1.ID_CQTQ, Text = c1.Name_CQTQ + " " + txt });
                    }
                }
            }
            return li;
        }
        public void Forward_Yeucau(string ID, string txt, string ID_CQTQ)
        {
            foreach (Yeucau y in db.Yeucaus)
            {
                if (y.ID_1 == ID && y.Title == txt)
                {
                    y.ID_2 = ID_CQTQ;
                    db.SaveChanges();
                    return;
                }
            }
        }
        public List<CBBItem> GetCBBTG(string ID)
        {
            List<CBBItem> li = new List<CBBItem>();
            foreach (FreeTime f in db.FreeTimes)
            {
                if (f.ID_CQTQ == ID)
                {
                    li.Add(new CBBItem
                    {
                        Value = f.ID_FreeTime.ToString(),
                        Text = f.Start_time.Value.ToString(@"hh\:mm") + " - " + f.End_time.Value.ToString(@"hh\:mm")
                    });
                }
            }
            return li;
        }
        public List<FreeTime> GetAllFreeTime(string ID)
        {
            List<FreeTime> li = new List<FreeTime>();
            foreach (FreeTime i in db.FreeTimes)
            {
                if (i.ID_CQTQ == ID)
                    li.Add(i);
            }
            return li;
        }
        public List<Lichhen> GetAllLichhen(string ID)
        {
            List<Lichhen> li = new List<Lichhen>();
            foreach (Lichhen l in db.Lichhens)
            {
                if (l.ID_CD == ID)
                    li.Add(l);
            }
            return li;
        }
        public List<Lichhen> GetLichhenbyTime(DateTime date)
        {
            List<Lichhen> li = new List<Lichhen>();
            foreach (Lichhen i in db.Lichhens)
            {
                if (i.Date_hen.Value.Date == date.Date)
                    li.Add(i);
            }
            return li;
        }
        public FreeTime GetFTbyID(int ID)
        {
            return db.FreeTimes.Find(ID);
        }
        public int MaxIDFT()
        {
            int Max = 0;
            foreach (FreeTime i in db.FreeTimes)
            {
                if (i.ID_FreeTime > Max)
                    Max = i.ID_FreeTime;
            }
            return Max;
        }
        public void Add_FreeTime(FreeTime f)
        {
            f.ID_FreeTime = MaxIDFT() + 1;
            db.FreeTimes.Add(f);
            db.SaveChanges();
        }
        public void Edit_FreeTime(int ID, FreeTime f)
        {
            FreeTime i = db.FreeTimes.Find(ID);
            string time = i.Start_time.Value.ToString(@"hh\:mm") + " - " + i.End_time.Value.ToString(@"hh\:mm");
            i.Start_time = f.Start_time;
            i.End_time = f.End_time;
            i.Max_per = f.Max_per;
            Del_LichhenbyFreeTime(time, i.ID_CQTQ);
            db.SaveChanges();
        }
        public void Del_FreeTime(int ID)
        {
            FreeTime i = db.FreeTimes.Find(ID);
            string time = i.Start_time.Value.ToString(@"hh\:mm") + " - " + i.End_time.Value.ToString(@"hh\:mm");
            Del_LichhenbyFreeTime(time, i.ID_CQTQ);
            db.FreeTimes.Remove(i);
            db.SaveChanges();
        }
        public bool Check_Empty_Time(DateTime date, string time, string ID_CQTQ, int ID_FreeTime)
        {
            int count = 0;
            foreach (Lichhen l in db.Lichhens)
            {
                if (l.Date_hen == date && l.Time == time && l.ID_CQTQ == ID_CQTQ)
                    count++;
            }
            if (count < db.FreeTimes.Find(ID_FreeTime).Max_per)
                return true;
            else return false;
        }
        public int MaxIDLichhen()
        {
            int Max = 0;
            foreach (Lichhen i in db.Lichhens)
            {
                if (i.ID_Lichhen > Max)
                    Max = i.ID_Lichhen;
            }
            return Max;
        }
        public void Add_Edit_Lichhen(Lichhen l, int ID)
        {
            if (ID == 0)
            {
                l.ID_Lichhen = MaxIDLichhen() + 1;
                db.Lichhens.Add(l);
                db.SaveChanges();
            }
            else
            {
                Lichhen i = db.Lichhens.Find(ID);
                i.Time = l.Time;
                i.ID_CQTQ = l.ID_CQTQ;
                i.Title = l.Title;
                i.TG = l.TG;
                i.Date_hen = l.Date_hen;
                db.SaveChanges();
            }
        }
        public Lichhen GetLichhenbyID(string ID)
        {
            return db.Lichhens.Find(Convert.ToInt32(ID));
        }
        public List<Lichhen> GetLichhenbyIDCQTQKG(DateTime date, string time, string ID_CQTQ)
        {
            var l = db.Lichhens.Where(p => p.ID_CQTQ == ID_CQTQ && p.Time == time && p.Date_hen == date).OrderBy(p => p.TG);
            return l.ToList();
        }
        public int GetSTTLichhen(Lichhen l)
        {
            int count = 0;
            foreach (Lichhen i in GetLichhenbyIDCQTQKG(l.Date_hen.Value, l.Time, l.ID_CQTQ))
            {
                if (l.ID_Lichhen != i.ID_Lichhen)
                    count++;
                else break;
            }
            return count + 1;
        }
        public void Del_LichhenbyFreeTime(string time, string ID_CQTQ)
        {
            foreach (Lichhen l in db.Lichhens)
            {
                if (l.Time == time && l.ID_CQTQ == ID_CQTQ)
                {
                    string ND = "Lịch hẹn với " + l.CQTQ.Name_CQTQ + " " + l.CQTQ.TT.Insert(0, l.CQTQ.TT[0].ToString().ToLower()).Remove(1, 1) +
                        " vào " + l.Time + " ngày " + l.Date_hen.Value.Date.ToShortDateString() + " đã bị hủy";
                    Add_noti_delLichhen(l.ID_CD, l.ID_CQTQ, ND);
                    db.Lichhens.Remove(l);
                }
            }
            db.SaveChanges();
        }
        public void Add_noti_delLichhen(string ID_CD, string ID_CQTQ, string ND)
        {
            Thongbao t = new Thongbao
            {
                ID_Thongbao = MaxIDNoti() + 1,
                ID_CD = ID_CD,
                ID_CQTQ = ID_CQTQ,
                Date_sent = DateTime.Now,
                Title = "Hủy lịch hẹn",
                ND = ND,
            };
            db.Thongbaos.Add(t);
        }
        public void Del_Lichhen(int ID)
        {
            Lichhen l = db.Lichhens.Find(ID);
            db.Lichhens.Remove(l);
            db.SaveChanges();
        }
        public List<string> GetAllChucvu()
        {
            List<string> li = new List<string>();
            foreach(Quyenhan n in db.Quyenhans)
            {
                li.Add(n.Chucvu);
            }
            return li;
        }
        public int MaxIDYkien()
        {
            int Max = 0;
            foreach (Ykien i in db.Ykiens)
            {
                if (i.ID_Ykien > Max)
                    Max = i.ID_Ykien;
            }
            return Max;
        }
        public void Add_Ykien(Ykien y, int ID)
        {
            y.ID_Ykien = MaxIDYkien() + 1;
            db.Ykiens.Add(y);
            if (ID != 0)
            {
                Del_Noti(ID);
            }
            else
            {
                db.SaveChanges();
            }
        }
        public List<Ykien> GetListYkienbyIDCQTQ(string ID)
        {
            List<Ykien> li = new List<Ykien>();
            foreach (Ykien i in db.Ykiens)
            {
                if (i.ID == ID)
                    li.Add(i);
            }
            return li;
        }
        public List<CDVN> GetListCDVNbyAgeTTHN(List<CDVN> li, int min, int max, string tt)
        {
            List<CDVN> list = new List<CDVN>();
            foreach(CDVN c in li)
            {
                int age = (DateTime.Now.Date - c.NgaySinhCD.Value.Date).Days / 365;
                if (age >= min && age <= max && c.TT_hn.Contains(tt))
                    list.Add(c);
            }
            return list;
        }
        public List<CDVN> GetListCDVNbyDTLD(List<CDVN> li)
        {
            List<CDVN> list = new List<CDVN>();
            foreach(CDVN c in li)
            {
                int age = (DateTime.Now.Date - c.NgaySinhCD.Value.Date).Days / 365;
                if (c.GioiTinh == "Nam" && age >= 15 && age <= 60)
                    list.Add(c);
                else if (c.GioiTinh == "Nữ" && age >= 15 && age <= 55)
                    list.Add(c);
            }
            return list;
        }
        public List<CDVN> GetListCDVNbyTHTP(List<CDVN> li)
        {
            List<CDVN> list = new List<CDVN>();
            foreach (CDVN c in li)
            {
                if (c.TATS == "Có")
                    list.Add(c);
            }
            return list;
        }
        public List<Ykien> GetListYkien(List<CDVN> li, string ID_CQTQ)
        {
            List<Ykien> list = new List<Ykien>();
            foreach (Ykien i in db.Ykiens)
            {
                if (i.ID == ID_CQTQ)
                {
                    foreach (CDVN c in db.CDVNs)
                        if (i.ID_CD == c.ID_CD)
                        {
                            list.Add(i);
                            break;
                        }
                }
            }
            return list;
        }
        public List<Account> GetListAcc()
        {
            List<Account> list = new List<Account>(); 
            foreach(Account c in db.Accounts)
                if (c.account_type != 1)
                    list.Add(c);
            return list;
        } 
        public void Del_LD(string ID)
        {
            LDVN l = db.LDVNs.Find(ID);
            db.LDVNs.Remove(l);
            db.SaveChanges();
        }    
        public bool Check_Edit_CQTQ(CQTQ c)
        {
            return db.CQTQs.Find(c.ID_CQTQ) != null;
        }
        public void Add_Edit_CQTQ(CQTQ c)
        {
            if (Check_Edit_CQTQ(c))
            {
                CQTQ i = db.CQTQs.Find(c.ID_CQTQ);
                i.Name_CQTQ = c.Name_CQTQ;
                i.TT = c.TT;
                i.DiaChi = c.DiaChi;
                i.Email = c.Email;
                i.SDT = c.SDT;
            }
            else
            {
                db.CQTQs.Add(c);
            }
            db.SaveChanges();
        }
        public void Del_CQTQ(string ID)
        {
            CQTQ c = db.CQTQs.Find(ID);
            db.CQTQs.Remove(c);
            db.SaveChanges();
        }    
        public bool Check_Exists_CQTQ(CQTQ c)
        {
            foreach(CQTQ i in db.CQTQs)
            {
                if (c.Name_CQTQ == i.Name_CQTQ && c.TT == i.TT)
                    return true;
            }
            return false;
        }    
    }
}
