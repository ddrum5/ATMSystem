using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1 {
    class NganHang {

        string maNganHang;
        string tenNganHang;

        public NganHang() {
        }

        public NganHang(string maNganHang, string tenNganHang) {
            this.MaNganHang = maNganHang;
            this.TenNganHang = tenNganHang;
        }

        public string MaNganHang { get => maNganHang; set => maNganHang = value; }
        public string TenNganHang { get => tenNganHang; set => tenNganHang = value; }
    }
}
