using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using WinFormsApp1.Ulti;


namespace WinFormsApp1 {

    class The:DBUlti {



        string tenNganHang;
        List<String> listSoTaiKhoan = new List<String>();
        string tenKhachHang;
        byte trangThai;
        int idThe;
        int idTaiKhoan;

        public The() {

        }
        public string TenNganHang { get => tenNganHang; set => tenNganHang = value; }
        public List<string> getListSoTaiKhoan { get => listSoTaiKhoan; set => listSoTaiKhoan = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public byte TrangThai { get => trangThai; set => trangThai = value; }

        public bool initThe(string soTaiKhoan, string maNganHang) {
            bool check=false;
            //SO TK, TTRANG THAI
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT HOTEN,TEN, SOTK,TAIKHOAN.ID_THE,ID_TK FROM dbo.KHACHHANG, dbo.TAIKHOAN, dbo.THE, dbo.NGANHANG " +
                    "WHERE KHACHHANG.ID_KH = THE.ID_KH AND TAIKHOAN.ID_THE = THE.ID_THE AND NGANHANG.ID_NH = THE.ID_NH " +
                    "AND THE.ID_NH = '" +
                    maNganHang +
                    "' AND SOTK = '" +
                    soTaiKhoan +
                    "' ";
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader.HasRows) {
                        check = true;
                        while (reader.Read()) {
                            tenKhachHang = reader.GetString(0);
                            tenNganHang = reader.GetString(1);
                            listSoTaiKhoan.Add(reader.GetString(2));
                            idThe = reader.GetInt32(3);
                            idTaiKhoan = reader.GetInt32(4);

                        }
                    } 
                }
            }
            return check;
        }
        public The(string soThe, string maNganHang) {
            //SO TK, TTRANG THAI
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT HOTEN,TEN, SOTK,TAIKHOAN.ID_THE,ID_TK FROM dbo.KHACHHANG, dbo.TAIKHOAN, dbo.THE, dbo.NGANHANG " +
                    "WHERE KHACHHANG.ID_KH = THE.ID_KH AND TAIKHOAN.ID_THE = THE.ID_THE AND NGANHANG.ID_NH = THE.ID_NH " +
                    "AND THE.ID_NH = '" +
                    maNganHang +
                    "' AND SOTHE = '" +
                    soThe +
                    "' ";
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            tenKhachHang = reader.GetString(0);
                            tenNganHang = reader.GetString(1);
                            listSoTaiKhoan.Add(reader.GetString(2));
                            idThe = reader.GetInt32(3);
                            idTaiKhoan = reader.GetInt32(4);

                        }
                    }
                }
            }

        }// dong hamtao

        //ham
        public bool giaoDich(char gd, String taiKhoan, decimal soTien, String nguoiNhan, String moTa) {
            int rowCount = 0;
            String msg = "";
            if (gd.Equals('c')) {
                msg = "Chuyển tiền: -" + soTien + " đến tài khoản: " + taiKhoan + " (" + nguoiNhan + "), Mô tả: \" " + moTa+ " \" ";
            } else {
                msg = "Nhận tiền: +" + soTien + " từ tài khoản: " + taiKhoan + " (" + nguoiNhan + "), Mô tả: \" " + moTa + " \" ";
            }
            using (SqlCommand cmd = conn.CreateCommand()) {
                try {
                    string sql = "INSERT INTO dbo.GIAODICH VALUES (@idTk, @moTa, @thoiGian)";
                    cmd.CommandText = sql;
                    // Thêm và sét đặt giá trị cho tham số.
                    cmd.Parameters.Add("@idTk", SqlDbType.Int).Value = idTaiKhoan;
                    cmd.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = msg;
                    cmd.Parameters.Add("@thoiGian", SqlDbType.Char).Value = Tool.getCurrentTime();
                    // Thực thi Command (Dùng cho delete, insert, update).
                    rowCount = cmd.ExecuteNonQuery();
                } catch (Exception e) {
                    return false;
                }
            }
            return rowCount > 0;
        }
      
        public bool rutTien(String soTaiKhoan, decimal soTienRut) {
            int rowCount=0;
            decimal soTien = tienTrongTK(soTaiKhoan) - soTienRut;
            if(soTien<0) {
                return false;
            }
            using (SqlCommand cmd = conn.CreateCommand()) {
                try {
                    string sql = "UPDATE dbo.TAIKHOAN SET SOTIEN = @soTien WHERE SOTK=@soTaiKhoan AND ID_THE=@idThe";
                    cmd.CommandText = sql;
                    // Thêm và sét đặt giá trị cho tham số.
                    cmd.Parameters.Add("@soTien", SqlDbType.Decimal).Value = soTien;
                    cmd.Parameters.Add("@soTaiKhoan", SqlDbType.Char).Value = soTaiKhoan;
                    cmd.Parameters.Add("@idThe", SqlDbType.Int).Value = idThe;
                    // Thực thi Command (Dùng cho delete, insert, update).
                    rowCount = cmd.ExecuteNonQuery();
                } catch (Exception e) {
                    return false;
                }
            }
            return rowCount > 0;
        }
        public bool napTien(String soTaiKhoan, decimal soTienNap) {
            int rowCount = 0;
            decimal soTien = tienTrongTK(soTaiKhoan) + soTienNap;
            using (SqlCommand cmd = conn.CreateCommand()) {
                try {
                    string sql = "UPDATE dbo.TAIKHOAN SET SOTIEN = @soTien WHERE SOTK=@soTaiKhoan AND ID_THE=@idThe";
                    cmd.CommandText = sql;
                    // Thêm và sét đặt giá trị cho tham số.
                    cmd.Parameters.Add("@soTien", SqlDbType.Decimal).Value = soTien;
                    cmd.Parameters.Add("@soTaiKhoan", SqlDbType.Char).Value = soTaiKhoan;
                    cmd.Parameters.Add("@idThe", SqlDbType.Int).Value = idThe;
                    // Thực thi Command (Dùng cho delete, insert, update).
                    rowCount = cmd.ExecuteNonQuery();
                } catch (Exception e) {
                    return false;
                }
            }
            return rowCount > 0;
        }
        public decimal tienTrongTK(String soTaiKhoan) {
            decimal soTien=0;
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT SOTIEN FROM dbo.TAIKHOAN WHERE SOTK = @SOTK AND ID_THE =@ID_THE";
                cmd.CommandText = sql;
                cmd.Parameters.Add("SOTK", SqlDbType.Char).Value = soTaiKhoan;
                cmd.Parameters.Add("ID_THE", SqlDbType.Int).Value = idThe;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            soTien = reader.GetDecimal(0);
                        }
                    }
                }
            }
            return soTien;
        }

        public bool checkPin(string st, string nh, string pin) {

            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT pin FROM dbo.THE WHERE ID_NH = '" +
                nh +
                "' AND SOTHE = '" +
                st +
                "'";
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            string pinCheck = reader.GetString(0);
                            if (pin.Equals(pinCheck)) {
                                return true;
                            }
                            return false;
                        }
                    }
                }
            }
            return false;

        }
        //Danh sach ngan hang
        public List<String> danhSachTenNganHang() {

            List<String> list = new List<String>();
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT Ten FROM NGANHANG";
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            string s = reader.GetString(0);
                            list.Add(s);
                        }
                    }
                }
            }
            return list;
        }
        public List<String> danhSachMaNganHang() {
            List<String> list = new List<String>();
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT ID_NH FROM NGANHANG";
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            string s = reader.GetString(0);
                            list.Add(s);
                        }
                    }
                }
            }

            return list;
        }
        public List<NganHang> listNganHang() {
            List<NganHang> list = new List<NganHang>();
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT ID_NH FROM NGANHANG";
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            string s = reader.GetString(0);
                       
                        }
                    }
                }
            }
            return list;
        }


        public List<String> danhSachGiaoDich() {
            List<String> list = new List<string>();
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT MOTA,THOIGIAN FROM dbo.GIAODICH WHERE ID_TK=" + idTaiKhoan;
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            string moTa = reader.GetString(0);
                            string thoiGian = reader.GetString(1);
                            list.Add(moTa + " - " + thoiGian);
                        }
                    }
                }
            }

            return list;
        }








    }//

}//








