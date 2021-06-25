using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Ulti;

namespace WinFormsApp1 {
    public partial class MainUI:MetroSetForm {

        private string maNganhang;
        private string soThe;

        The the;
        public MainUI(string maNganhang, string soThe) {
            InitializeComponent();
            this.maNganhang = maNganhang;
            this.soThe = soThe;
        }

        private void MainUI_Load(object sender, EventArgs e) {
            the = new The(soThe, maNganhang);
            initThongTin();
            initRutTien();
            initTraCuuSoDu();
            initChuyenTien();

        }

        private void initChuyenTien() {
            cb_ChuyenTien_ChonTaiKhoanNguon.DataSource = the.getListSoTaiKhoan;
            cb_ChuyenTien_ChonTaiKhoanNguon.DropDownWidth = Tool.DropDownWidth(cb_ChuyenTien_ChonTaiKhoanNguon);
            cb_ChuyenTien_ChonTenNganHang.DataSource = the.danhSachTenNganHang();
            cb_ChuyenTien_ChonTenNganHang.DropDownWidth = Tool.DropDownWidth(cb_ChuyenTien_ChonTenNganHang);
            cb_ChuyenTien_ChonTenNganHang.SelectedText = "---Chọn ngân hàng---";
            cb_ChuyenTien_ChonTaiKhoanNguon.SelectedText = "---Chọn tài khoản nguồn---";


        }

        void initThongTin() {

            lbTenChuTK.Text = the.TenKhachHang;
            lbTenNganHang.Text = the.TenNganHang;
            lbSoThe.Text = soThe;
            listBoxSoTaiKhoan.DataSource = the.getListSoTaiKhoan;
        }
        void initRutTien() {
            cb_rutTien_taiKhoanNguon.DataSource = the.getListSoTaiKhoan;
            cb_rutTien_taiKhoanNguon.DropDownWidth = Tool.DropDownWidth(cb_rutTien_taiKhoanNguon);
        }
        void initTraCuuSoDu() {
            cb_TraCuuSoDu.DataSource = the.getListSoTaiKhoan;
            cb_TraCuuSoDu.DropDownWidth = Tool.DropDownWidth(cb_TraCuuSoDu);
        }




        private void btn_RutTien_Click(object sender, EventArgs e) {
            decimal soTienRut = Decimal.Parse(inp_rutTien_soTienRut.Text);
            String soTaiKhoan = cb_rutTien_taiKhoanNguon.SelectedItem.ToString();


            if (the.rutTien(soTaiKhoan, soTienRut)) {
                if (checkBox_RutTien_inHoaDon.Checked) {
                    
                    Program.ShowMsg("Đã rút: " + formatTien(soTienRut) + "\n" +
                        "số dư: " + formatTien(the.tienTrongTK(soTaiKhoan)) + "\n" +
                        "Vào lúc: " + getCurrentTime());
                } else {
                    Program.ShowMsg("Rút tiền thành công");
                }
            } else {
                Program.ShowMsg("Không đủ số dư");

            }

        }

        private void btn_TraCuuSoDu_Click(object sender, EventArgs e) {
            String soTaiKhoan = cb_TraCuuSoDu.GetItemText(cb_TraCuuSoDu.SelectedItem);
            lb_TraCuu.Text = formatTien(the.tienTrongTK(soTaiKhoan));
        }



        private void btn_ChuyenTien_Click(object sender, EventArgs e) {
            String soTaiKhoanDich = inp_ChuyenTien_SoTaiKhoan.Text;
            String soTaiKhoanNguon = cb_ChuyenTien_ChonTaiKhoanNguon.SelectedItem.ToString();
            String maNganHang = the.danhSachMaNganHang()[cb_ChuyenTien_ChonTaiKhoanNguon.SelectedIndex];
            decimal soTien = Decimal.Parse(inp_chuyenTien_soTien.Text);

            The the2 = new The();
            bool check = the2.initThe(soTaiKhoanDich, maNganhang);
            if (!check) {
                Program.ShowMsg("Không tìm thấy tài khoản đích");
            } else if (!the.rutTien(soTaiKhoanNguon, soTien)) {
                Program.ShowMsg("không đủ số dư");
            } else {
                if (!(the.rutTien(soTaiKhoanNguon, soTien) && the2.napTien(soTaiKhoanDich, soTien))) {
                    Program.ShowMsg("Lỗi hệ thống!");
                } else {
                    if (!checkBox_ChuyenTien_InHoaDon.Checked) {
                        Program.ShowMsg("Chuyển tiền thành công");
                    } else {
                        Program.ShowMsg("Đã Chuyển: " + formatTien(soTien) + "\n" +
                            "Đến số tài khoản: " + soTaiKhoanDich + "\n" +
                            "Vào lúc: " + getCurrentTime() + "\n" +
                            "số dư: " + formatTien(the.tienTrongTK(soTaiKhoanNguon)));
                    }
                }

            }
        }










        private void inp_rutTien_soTienRut_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }


        }



        String formatTien(decimal tien) {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,0.## VNĐ}", tien);
        }
        String getCurrentTime() {
            return DateTime.Now.ToString("HH:mm:ss tt, dd/MM/yyyy");
        }


    }
}
