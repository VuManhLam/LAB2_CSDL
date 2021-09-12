using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Giaovien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public Giaovien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }
        public Giaovien(string maso, string hoten, DateTime ngaysinh, DanhMucMonHoc ds, string gt, string[] nn, string sdt, string maill)
        {
            this.MaSo = maso;
            this.HoTen = hoten;
            this.NgaySinh = ngaysinh;
            this.dsMonHoc = ds;
            this.GioiTinh = gt;
            this.NgoaiNgu = nn;
            this.SoDT = sdt;
            this.Mail = maill;
        }
        public override string ToString()
        {
            string s = "Mã số:" + MaSo + "\n" + "Họ tên:" + HoTen + "\n"
                + "Ngày sinh:" + NgaySinh.ToString() + "\n"
                + "Giới tính:" + GioiTinh + "\n"
                + "Maill:" + Mail + "\n";
            string sngoaingu = "Ngoại ngữ";
            foreach (string t in NgoaiNgu)
                sngoaingu += t + ";";
            string Monday = " Danh sách môn dạy:";
            foreach (MonHoc mh in dsMonHoc.ds)
                Monday += mh + ";";
            s += "\n" + sngoaingu + "\n" + Monday;
            return s;
        }
    }
}
