using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Ulti;

namespace WinFormsApp1 {
    public partial class DangKy:MetroSetForm {
        public DangKy() {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e) {
            initComboNganHang();
        }

        void initComboNganHang() {
            cbChonNganHang.DataSource = new The().getAllNganHang();
            cbChonNganHang.DisplayMember = "tenNganHang";
            cbChonNganHang.ValueMember = "maNganHang";
            cbChonNganHang.DropDownWidth = Tool.DropDownWidth(cbChonNganHang);
        }
      

        private void btn_DangKy_Click(object sender, EventArgs e) {
            if(inp_hoTen.Text=="" || inp_DiaChi.Text == "" || inp_Sdt.Text == "" 
                || inpMaPin.Text == "" || cbChonNganHang.SelectedIndex == 0) {
                Program.ShowMsg();
                return;
            }  
            
            else {
                String hoTen = inp_hoTen.Text;
                String sdt = inp_Sdt.Text;
                String diaChi = inp_DiaChi.Text;
                String maNganHang = cbChonNganHang.SelectedValue.ToString();
                String pin = inpMaPin.Text;
                Random random = new Random();
                String soThe;
                String soTaiKhoan;
                do {
                    soThe = "66" + random.Next(100, 999);
                } while (new The().checkSoThe(maNganHang, soThe));
                do {
                    soTaiKhoan = "99" + random.Next(100, 999);
                } while (new The().checkSoTaiKhoan(maNganHang, soTaiKhoan));

                bool check = new The().themTaiKhoan(hoTen, sdt, diaChi, maNganHang, pin, soThe, soTaiKhoan);
                if (!check) {
                    Program.ShowMsg("Tạo tài khoản thất bại!", true);
                } else {
                    Program.ShowMsg("Đăng ký tài khoản thành công");
                    MainUI mainUI = new MainUI(maNganHang, soThe, pin);
                    Hide();
                    mainUI.ShowDialog();
                    Show();
                }
                

            }

            
        }

        private void btn_Thoat_Click(object sender, EventArgs e) {
            Tool.confirmExit(this);
        }
    }
}
