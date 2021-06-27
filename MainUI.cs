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
        private string pin;
        The the;
        List<string> listSoTaiKhoan = new List<string>();
        public MainUI(string maNganhang, string soThe, string pin) {
            InitializeComponent();
            this.maNganhang = maNganhang;
            this.soThe = soThe;
            this.pin = pin;
        }
        private void MainUI_Load(object sender, EventArgs e) {

            the = new The(soThe, maNganhang);
            listSoTaiKhoan = the.getListSoTaiKhoan;
            initThongTin();
            initRutTien();
            initTraCuuSoDu();
            initChuyenTien();
            initSaoKe();
            initNapTien();
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
            list.AddRange(listSoTaiKhoan);
            list.RemoveAt(0);
            listBoxSoTaiKhoan.DataSource = list;
        }
        void initRutTien() {
            cb_rutTien_taiKhoanNguon.DataSource = listSoTaiKhoan;
            cb_rutTien_taiKhoanNguon.SelectedIndex = 0;
            cb_rutTien_taiKhoanNguon.DropDownWidth = Tool.DropDownWidth(cb_rutTien_taiKhoanNguon);
        }
        void initNapTien() {
            cb_NapTien_TaiKhoanNguon.DataSource = listSoTaiKhoan;
            cb_NapTien_TaiKhoanNguon.SelectedIndex = 0;
            cb_NapTien_TaiKhoanNguon.DropDownWidth = Tool.DropDownWidth(cb_NapTien_TaiKhoanNguon);
        }
        void initTraCuuSoDu() {
            cb_TraCuuSoDu.DataSource = listSoTaiKhoan;
            cb_TraCuuSoDu.SelectedIndex = 0;
            cb_TraCuuSoDu.DropDownWidth = Tool.DropDownWidth(cb_TraCuuSoDu);
        }
        void initSaoKe() {
            comboBox_SaoKe.DataSource = listSoTaiKhoan;
            comboBox_SaoKe.SelectedIndex = 0;
            comboBox_SaoKe.DropDownWidth = Tool.DropDownWidth(comboBox_SaoKe);
        }
        private void btn_RutTien_Click(object sender, EventArgs e) {
            if (cb_rutTien_taiKhoanNguon.SelectedIndex == 0 || inp_rutTien_soTienRut.Text == "") {
                showMsg();
                return;
            }
            decimal soTienRut = Decimal.Parse(inp_rutTien_soTienRut.Text);
            String soTaiKhoan = cb_rutTien_taiKhoanNguon.SelectedItem.ToString();
            if (soTienRut > the.tienTrongTK(soTaiKhoan)) {
                showMsg("Không đủ số dư");
            } else {
                if (the.rutTien(soTaiKhoan, maNganhang, soTienRut) && the.themGiaoDich('r', soTaiKhoan, soTienRut)) {
                    DialogResult dr = Tool.dialogConfirm("Bạn có chắc chắn muốn rút tiền không");
                    if (dr == DialogResult.No) {
                        return;
                    } else {
                        if (checkBox_RutTien_inHoaDon.Checked) {
                            Program.ShowMsg("Đã rút: " + formatTien(soTienRut) + "\n" +
                                "số dư: " + formatTien(the.tienTrongTK(soTaiKhoan)) + "\n" +
                                "Vào lúc: " + getCurrentTime());
                        } else {
                            Program.ShowMsg("Rút tiền thành công");
                        }

                        inp_rutTien_soTienRut.Text = "";
                        cb_rutTien_taiKhoanNguon.SelectedIndex = 0;
                    }

                    

                } else {
                    showMsg("Lỗi hệ thống");
                }
            }

        }
        
        private void btn_NapTien_Click(object sender, EventArgs e) {
            if (cb_NapTien_TaiKhoanNguon.SelectedIndex == 0 || inp_NapTien_SoTienNap.Text == "") {
                showMsg();
                return;
            }
            decimal soTienNap = Decimal.Parse(inp_NapTien_SoTienNap.Text);
            String soTaiKhoan = cb_NapTien_TaiKhoanNguon.SelectedItem.ToString();
            if (the.napTien(soTaiKhoan, maNganhang, soTienNap) && the.themGiaoDich('n', soTaiKhoan, soTienNap)) {
                DialogResult dr = Tool.dialogConfirm("Bạn có chắc chắn muốn nạp tiền không");
                if (dr == DialogResult.No) {
                    return;
                } else {
                    if (checkBox_NapTiep_InHoaDon.Checked) {
                        Program.ShowMsg("Đã nạp: " + formatTien(soTienNap) + "\n" +
                            "số dư: " + formatTien(the.tienTrongTK(soTaiKhoan)) + "\n" +
                            "Vào lúc: " + getCurrentTime());
                    } else {
                        Program.ShowMsg("Nạp tiền thành công");
                    }
                    inp_NapTien_SoTienNap.Text = "";
                    cb_NapTien_TaiKhoanNguon.SelectedIndex = 0;
                }

            } else {
                Program.ShowMsg("Lỗi hệ thống");
            }
        }
        private void btn_ChuyenTien_Click(object sender, EventArgs e) {
            if (cb_ChuyenTien_ChonTenNganHang.SelectedIndex == 0 || cb_ChuyenTien_ChonTaiKhoanNguon.SelectedIndex == 0
                || inp_chuyenTien_soTien.Text == "" || inp_ChuyenTien_SoTaiKhoan.Text == "") {
                showMsg();
                return;
            }
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
                DialogResult dr = Tool.dialogConfirm("Bạn có chắc chắn muốn nạp tiền không");
                if (dr == DialogResult.No) {
                    return;
                } else {
                    if (!checkBox_ChuyenTien_InHoaDon.Checked) {
                        showMsg("Chuyển tiền thành công!");
                    } else {
                        Program.ShowMsg("Đã Chuyển: " + formatTien(soTien) + "\n" +
                               "Đến số tài khoản: " + soTaiKhoanDich + "\n" +
                               "Vào lúc: " + getCurrentTime() + "\n" +
                               "số dư: " + formatTien(the.tienTrongTK(soTaiKhoanNguon)));
                    }
                    inp_ChuyenTien_SoTaiKhoan.Text = "";
                    inp_chuyenTien_soTien.Text = "";
                    inp_chuyenTien_MoTa.Text = "";
                    cb_ChuyenTien_ChonTaiKhoanNguon.SelectedIndex = 0;
                    cb_ChuyenTien_ChonTenNganHang.SelectedIndex = 0;
                }
            }
        }
        private void btn_TraCuuSoDu_Click(object sender, EventArgs e) {
            if (cb_TraCuuSoDu.SelectedIndex == 0) {
                showMsg("Bạn chưa chọn tài khoản!");
                return;
            }
            String soTaiKhoan = cb_TraCuuSoDu.GetItemText(cb_TraCuuSoDu.SelectedItem);
            lb_TraCuu.Text = formatTien(the.tienTrongTK(soTaiKhoan));
        }
        private void btnSaoKe_Click(object sender, EventArgs e) {
            if (comboBox_SaoKe.SelectedIndex == 0) {
                showMsg("Bạn chưa chọn tài khoản!");
                return;
            }
            String soTaiKhoan = comboBox_SaoKe.SelectedItem.ToString();
            listBox_SaoKe.DataSource = the.danhSachGiaoDich(soTaiKhoan, maNganhang);
        }
        private void btn_DoiPin_Click(object sender, EventArgs e) {
            if (inp_pinCu.Text == "" || inp_pinMoi.Text == "" || inp_XacNhanPinMoi.Text == "") {
                showMsg();
                return;
            } else {
                String pinCu = inp_pinCu.Text;
                String pinMoi = inp_pinMoi.Text;
                String XacNhanPinMoi = inp_XacNhanPinMoi.Text;
                if (!pinCu.Equals(this.pin)) {
                    showMsg("PIN Cũ không đúng");
                } else if (pinMoi != XacNhanPinMoi) {
                    showMsg("Xác nhận pin mới không đúng");
                } else if (pinMoi.Length > 3) {
                    showMsg("PIN chỉ có độ dài tối đa 3 số");
                } else if (!the.doiPin(pinMoi, this.soThe, this.maNganhang)) {
                    showMsg("Lỗi hệ thống", true);
                } else {
                    showMsg("Đổi PIN thành công!");
                    inp_XacNhanPinMoi.Text = "";
                    inp_pinCu.Text = "";
                    inp_pinMoi.Text = "";

                    inp_pinCu.Text = "";
                    inp_XacNhanPinMoi.Text = "";
                    inp_pinMoi.Text = "";
                }
            }
        }
        private void btn_MoThemTaiKhoan_Click(object sender, EventArgs e) {
            DialogResult dr = Tool.dialogConfirm("Bạn có chắc chắn muốn mở  tài khoản?");
            String soTaiKhoan;
            if (dr == DialogResult.No) {
                return;
            } else {
                do {
                    soTaiKhoan = "99" + new Random().Next(100, 999);
                } while (new The().checkSoTaiKhoan(maNganhang, soTaiKhoan));
                if (!the.themTaiKhoan(soTaiKhoan)) {
                    showMsg("Lỗi hệ thống !", true);
                } else {
                    refreshList(the.updateListSoTaiKhoan());

                    showMsg("Mở thành công!\n" +
                        "Tài khoản số: " + soTaiKhoan);
                }
            }
        }
        public void refreshList(List<string> list) {
            cb_ChuyenTien_ChonTaiKhoanNguon.DataSource = list;
            cb_NapTien_TaiKhoanNguon.DataSource = list;
            cb_rutTien_taiKhoanNguon.DataSource = list;
            cb_TraCuuSoDu.DataSource = list;
            comboBox_SaoKe.DataSource = list;
            listBoxSoTaiKhoan.DataSource = list;
        }
        String formatTien(decimal tien) {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,0.## VNĐ}", tien);
        }
        String getCurrentTime() {
            return DateTime.Now.ToString("HH:mm:ss tt, dd/MM/yyyy");
        }
        private void btn_logout_Click(object sender, EventArgs e) {
            Tool.confirmExit(this);
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
        public void showMsg() {
            MessageBox.Show("Bạn phải nhập đầy đủ các trường", "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void showMsg(string msg, bool err) {
            MessageBox.Show(msg, "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void inp_rutTien_soTienRut_KeyPress(object sender, KeyPressEventArgs e) {
            Tool.numberOnly(sender, e);
        }

        private void inp_pinCu_KeyPress(object sender, KeyPressEventArgs e) {
            Tool.numberOnly(sender, e);
        }

        private void inp_NapTien_SoTienNap_KeyPress(object sender, KeyPressEventArgs e) {
            Tool.numberOnly(sender, e);
        }

        private void inp_ChuyenTien_SoTaiKhoan_KeyPress(object sender, KeyPressEventArgs e) {
            Tool.numberOnly(sender, e);
        }

        private void inp_chuyenTien_soTien_KeyPress(object sender, KeyPressEventArgs e) {
            Tool.numberOnly(sender, e);
        }

        private void inp_pinMoi_KeyPress(object sender, KeyPressEventArgs e) {
            Tool.numberOnly(sender, e);
        }

        private void inp_XacNhanPinMoi_KeyPress(object sender, KeyPressEventArgs e) {
            Tool.numberOnly(sender, e);
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e) {
            cb_NapTien_TaiKhoanNguon.SelectedIndex = 0;
        }
    }
}
