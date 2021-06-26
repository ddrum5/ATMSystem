﻿using System;
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

     
        public The() {

        }
        public string TenNganHang { get => tenNganHang; set => tenNganHang = value; }
        public List<string> getListSoTaiKhoan { get => listSoTaiKhoan; set => listSoTaiKhoan = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public byte TrangThai { get => trangThai; set => trangThai = value; }

        public bool initThe(string soTaiKhoan, string maNganHang) {
            bool check = false;
            //SO TK, TTRANG THAI
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT HOTEN,TEN, SOTK,TAIKHOAN.ID_THE FROM dbo.KHACHHANG, dbo.TAIKHOAN, dbo.THE, dbo.NGANHANG " +
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
                            String soTk = reader.GetString(2);
                            idThe = reader.GetInt32(3);
                            listSoTaiKhoan.Add(soTk);
                        }
                    }
                }
            }
            return check;
        }

        public The(string soThe, string maNganHang) {
            //SO TK, TTRANG THAI
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT HOTEN,TEN, SOTK,TAIKHOAN.ID_THE,SOTK FROM dbo.KHACHHANG, dbo.TAIKHOAN, dbo.THE, dbo.NGANHANG " +
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
                            String soTk = reader.GetString(2);
                            idThe = reader.GetInt32(3);
                            listSoTaiKhoan.Add(soTk);

                        }
                        listSoTaiKhoan.Insert(0, "--chọn tài khoản nguồn--");
                    }
                }
            }

        }// dong hamtao

        //ham
        public bool giaoDich(String idNganHangNguon, String soTaiKhoanNguon,String idNganHangDich, String soTaiKhoanDich, decimal soTien, String moTa) {
            int rowCount1 = 0;
            int rowCount2 = 0;
            String msg1 = "Chuyển tiền: -" + soTien + " đến tài khoản: " + soTaiKhoanDich + ", Mô tả: \" " + moTa + " \" ";
            using (SqlCommand cmd = conn.CreateCommand()) {
                try {
                    string sql = "INSERT INTO dbo.GIAODICH VALUES (@idTk, @moTa, @thoiGian)";
                    cmd.CommandText = sql;
                    // Thêm và sét đặt giá trị cho tham số.
                    cmd.Parameters.Add("@idTk", SqlDbType.Int).Value = getIdTaiKhoan(soTaiKhoanNguon,idNganHangNguon);
                    cmd.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = msg1;
                    cmd.Parameters.Add("@thoiGian", SqlDbType.Char).Value = Tool.getCurrentTime();
                    // Thực thi Command (Dùng cho delete, insert, update).
                    rowCount1 = cmd.ExecuteNonQuery();
                } catch (Exception e) {
                    e.ToString();
                }
            }
            String msg2 = "Nhận tiền: +" + soTien + " từ tài khoản: " + soTaiKhoanNguon + ", Mô tả: \" " + moTa + " \" ";
            using (SqlCommand cmd = conn.CreateCommand()) {
                try {
                    string sql = "INSERT INTO dbo.GIAODICH VALUES (@idTk, @moTa, @thoiGian)";
                    cmd.CommandText = sql;
                    // Thêm và sét đặt giá trị cho tham số.
                    cmd.Parameters.Add("@idTk", SqlDbType.Int).Value = getIdTaiKhoan(soTaiKhoanDich,idNganHangDich);
                    cmd.Parameters.Add("@moTa", SqlDbType.NVarChar).Value = msg2;
                    cmd.Parameters.Add("@thoiGian", SqlDbType.Char).Value = Tool.getCurrentTime();
                    // Thực thi Command (Dùng cho delete, insert, update).
                    rowCount2 = cmd.ExecuteNonQuery();
                } catch (Exception e) {
                    e.ToString();
                }
            }

            return (rowCount1 > 0 && rowCount2 > 0);
        }

        public bool chuyenTien(String idNganHangNguon, String taiKhoanNguon,String idNganHangDich,String taiKhoanDich,  decimal soTien,String moTa) {
            if (rutTien(taiKhoanNguon, idNganHangNguon, soTien) && napTien(taiKhoanDich, idNganHangDich, soTien)
                && giaoDich(idNganHangNguon, taiKhoanNguon,idNganHangDich, taiKhoanDich,soTien,moTa)) {
                return true;
            }
            return false;
        }

        public int getIdTaiKhoan(String soTaiKhoan, String idNganHang) {
            int id = 0;
            //SO TK, TTRANG THAI
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT ID_TK FROM dbo.TAIKHOAN WHERE SOTK = @soTaiKhoan and ID_NH= @idNganhang";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@soTaiKhoan", SqlDbType.VarChar).Value = soTaiKhoan;
                cmd.Parameters.Add("@idNganhang", SqlDbType.VarChar).Value = idNganHang;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader.HasRows)
                        while (reader.Read()) {
                            id = reader.GetInt32(0);
                        }
                }
            }
            return id;
        }


        public bool rutTien(String soTaiKhoan, String idNganHang, decimal st) {
            int rowCount = 0;
            decimal soTien = tienTrongTK(soTaiKhoan) - st;
            using (SqlCommand cmd = conn.CreateCommand()) {
                try {
                    string sql = "UPDATE dbo.TAIKHOAN SET SOTIEN = @soTien WHERE SOTK=@soTaiKhoan AND ID_NH=@idNganHang";
                    cmd.CommandText = sql;
                    // Thêm và sét đặt giá trị cho tham số.
                    cmd.Parameters.Add("@soTien", SqlDbType.Decimal).Value = soTien;
                    cmd.Parameters.Add("@soTaiKhoan", SqlDbType.VarChar).Value = soTaiKhoan;
                    cmd.Parameters.Add("@idNganHang", SqlDbType.Char).Value = idNganHang;
                    // Thực thi Command (Dùng cho delete, insert, update).
                    rowCount = cmd.ExecuteNonQuery();
                } catch (Exception e) {
                    return false;
                }
            }
            return rowCount > 0;
        }
        public bool napTien(String soTaiKhoan, String idNganHang, decimal st) {
            int rowCount = 0;
            decimal soTien = tienTrongTK(soTaiKhoan) + st;
            using (SqlCommand cmd = conn.CreateCommand()) {
                try {
                    string sql = "UPDATE dbo.TAIKHOAN SET SOTIEN = @soTien WHERE SOTK=@soTaiKhoan AND ID_NH=@idNganHang";
                    cmd.CommandText = sql;
                    // Thêm và sét đặt giá trị cho tham số.
                    cmd.Parameters.Add("@soTien", SqlDbType.Decimal).Value = soTien;
                    cmd.Parameters.Add("@soTaiKhoan", SqlDbType.VarChar).Value = soTaiKhoan;
                    cmd.Parameters.Add("@idNganHang", SqlDbType.Char).Value = idNganHang;
                    // Thực thi Command (Dùng cho delete, insert, update).
                    rowCount = cmd.ExecuteNonQuery();
                } catch (Exception e) {
                    return false;
                }
            }
            return rowCount > 0;
        }
        public decimal tienTrongTK(String soTaiKhoan) {
            decimal soTien = 0;
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
        public List<NganHang> getAllNganHang() {
            List<NganHang> list = new List<NganHang>();
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT ID_NH,TEN FROM NGANHANG";
                cmd.CommandText = sql;
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader != null) {
                        while (reader.Read()) {
                            string id = reader.GetString(0);
                            string ten = reader.GetString(1);
                            list.Add(new NganHang(id, ten));

                        }
                    }
                }
            }
            list.Insert(0, new NganHang("-1", "--chọn tên ngân hàng--"));
            return list;
        }

        public List<String> danhSachGiaoDich(String soTaiKhoan,String maNganHang) {
            List<String> list = new List<string>();
            using (SqlCommand cmd = conn.CreateCommand()) {
                string sql = "SELECT MOTA,THOIGIAN FROM dbo.GIAODICH WHERE ID_TK=" + getIdTaiKhoan(soTaiKhoan, maNganHang);
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








