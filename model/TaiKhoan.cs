using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1 {
    class TaiKhoan {
        int idTk;
        String soTK;
        public TaiKhoan() {

        }

        public TaiKhoan(int idTk, string soTK) {
            this.idTk = idTk;
            this.soTK = soTK;
        }

        public int  IdTk { get => idTk; set => idTk = value; }
        public string SoTK { get => soTK; set => soTK = value; }
    }
}
