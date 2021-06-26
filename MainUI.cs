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
            initSaoKe();
        }

        private void initChuyenTien() {
            cb_ChuyenTien_ChonTaiKhoanNguon.DataSource = the.getListSoTaiKhoan;
            cb_ChuyenTien_ChonTaiKhoanNguon.SelectedIndex = 0;
         
            cb_ChuyenTien_ChonTaiKhoanNguon.DropDownWidth = Tool.DropDownWidth(cb_ChuyenTien_ChonTaiKhoanNguon);

            cb_ChuyenTien_ChonTenNganHang.DataSource = the.getAllNganHang();
            cb_ChuyenTien_ChonTenNganHang.SelectedIndex = 0;
            cb_ChuyenTien_ChonTenNganHang.DisplayMember = "tenNganHang";
            cb_ChuyenTien_ChonTenNganHang.ValueMember = "maNganHang";
            cb_ChuyenTien_ChonTenNganHang.DropDownWidth = Tool.DropDownWidth(cb_ChuyenTien_ChonTenNganHang);

        }
        void initThongTin() {
            lbTenChuTK.Text = the.TenKhachHang;
            lbTenNganHang.Text = the.TenNganHang;
            lbSoThe.Text = soThe;
            List<String> list = new List<string>();
            list.AddRange(the.getListSoTaiKhoan);
            list.RemoveAt(0);
            listBoxSoTaiKhoan.DataSource = list;

        }
        void initRutTien() {
            cb_rutTien_taiKhoanNguon.DataSource = the.getListSoTaiKhoan;
            cb_rutTien_taiKhoanNguon.SelectedIndex = 0;
            cb_rutTien_taiKhoanNguon.DropDownWidth = Tool.DropDownWidth(cb_rutTien_taiKhoanNguon);
        }
        void initTraCuuSoDu() {
            cb_TraCuuSoDu.DataSource = the.getListSoTaiKhoan;
            cb_TraCuuSoDu.SelectedIndex = 0;
            cb_TraCuuSoDu.DropDownWidth = Tool.DropDownWidth(cb_TraCuuSoDu);
        }
        void initSaoKe() {
            comboBox_SaoKe.DataSource = the.getListSoTaiKhoan;
            comboBox_SaoKe.SelectedIndex = 0;
            comboBox_SaoKe.DropDownWidth = Tool.DropDownWidth(comboBox_SaoKe);
        }



        private void btn_RutTien_Click(object sender, EventArgs e) {
            decimal soTienRut = Decimal.Parse(inp_rutTien_soTienRut.Text);
            String soTaiKhoan = cb_rutTien_taiKhoanNguon.SelectedItem.ToString();
            if (the.rutTien(soTaiKhoan, maNganhang, soTienRut)) {
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

            if (inp_chuyenTien_soTien.Text == "" || inp_ChuyenTien_SoTaiKhoan.Text == ""
                || cb_ChuyenTien_ChonTaiKhoanNguon.SelectedItem == null || cb_ChuyenTien_ChonTenNganHang == null) {
                Program.ShowMsg("Vui lòng điền đầy đủ thông tin");
                cb_ChuyenTien_ChonTenNganHang.Focus();
            } else {
                String soTaiKhoanDich = inp_ChuyenTien_SoTaiKhoan.Text;
                String soTaiKhoanNguon = cb_ChuyenTien_ChonTaiKhoanNguon.Text;
                String maNganHangDich = cb_ChuyenTien_ChonTenNganHang.SelectedValue.ToString();
                String maNgnhangNguon = this.maNganhang;
                String moTa = inp_chuyenTien_MoTa.Text;
                decimal soTien = Decimal.Parse(inp_chuyenTien_soTien.Text);

                if (the.tienTrongTK(soTaiKhoanNguon) < soTien) {
                    showMsg("Không đủ số dư");
                } else if (the.getIdTaiKhoan(soTaiKhoanDich, maNganHangDich) == 0) {
                    showMsg("Không tìm thấy tài khoản đích");
                } else if (!the.chuyenTien(maNgnhangNguon, soTaiKhoanNguon, maNganHangDich, soTaiKhoanDich, soTien, moTa)) {
                    showMsg("Chuyển tiền thất bại", true);
                } else {
                    if (!checkBox_ChuyenTien_InHoaDon.Checked) {
                        showMsg("Chuyển tiền thành công!");
                    } else {
                        Program.ShowMsg("Đã Chuyển: " + formatTien(soTien) + "\n" +
                               "Đến số tài khoản: " + soTaiKhoanDich + "\n" +
                               "Vào lúc: " + getCurrentTime() + "\n" +
                               "số dư: " + formatTien(the.tienTrongTK(soTaiKhoanNguon)));
                    }
                }

            }
        }

        private void button9_Click(object sender, EventArgs e) {
            if (comboBox_SaoKe.SelectedIndex == 0) {
                showMsg("Bạn chưa chọn tài khoản!",);
                return;
            } 
            String soTaiKhoan = comboBox_SaoKe.SelectedItem.ToString();
            listBox_SaoKe.DataSource = the.danhSachGiaoDich(soTaiKhoan,maNganhang);
        }

        private void inp_rutTien_soTienRut_Leave(object sender, EventArgs e) {

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

        private void btn_logout_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_100_Click(object sender, EventArgs e) {
            inp_rutTien_soTienRut.Text = "100,000";

        }

        private void btn_200_Click(object sender, EventArgs e) {
            inp_rutTien_soTienRut.Text = "200,000";
        }

        private void btn_300_Click(object sender, EventArgs e) {
            inp_rutTien_soTienRut.Text = "500,000";
        }

        private void btn_1000_Click(object sender, EventArgs e) {
            inp_rutTien_soTienRut.Text = "1,000,000";
        }

        private void btn_5000_Click(object sender, EventArgs e) {
            inp_rutTien_soTienRut.Text = "5,000,000";
        }

        private void btn_soKhac_Click(object sender, EventArgs e) {
            inp_rutTien_soTienRut.Focus();
        }

        public void showMsg(string msg) {
            MessageBox.Show(msg, "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void showMsg(string msg, bool err) {
            MessageBox.Show(msg, "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
