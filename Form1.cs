using System;

using WinFormsApp1.Ulti;
using MetroSet_UI.Forms;

namespace WinFormsApp1 {
    public partial class formDangNhap:MetroSetForm {

        string st;
        string nh;
        string pin;


        public formDangNhap() {
            InitializeComponent();


        }



        private void Form1_Load(object sender, EventArgs e) {
            ActiveControl = metroSetLabel1;

            cbTenNganHang.DataSource = new The().getAllNganHang();
            cbTenNganHang.DisplayMember = "tenNganHang";
            cbTenNganHang.ValueMember = "maNganHang";
            cbTenNganHang.DropDownWidth = Tool.DropDownWidth(cbTenNganHang);

            inpSoThe.Text = "68888";
            inpPIN.Text = "123";
            cbTenNganHang.SelectedValue = "TPB";
        }



        private void btbDutThe_Click_Click(object sender, EventArgs e) {
            if (cbTenNganHang.SelectedIndex == 0 || inpPIN.Text.Equals("") || inpSoThe.Text.Equals("")) {
                Program.ShowMsg("Vui điền hết thông tin!");
                cbTenNganHang.Focus();
            } else {
                st = inpSoThe.Text;
                pin = inpPIN.Text;
                nh = cbTenNganHang.SelectedValue.ToString();



                if (new The().checkPin(st, nh, pin)) {
                    MainUI mainUI = new MainUI(nh, st);
                    Hide();
                    mainUI.ShowDialog();
                    Show();

                } else {
                    Program.ShowMsg("Sai ma");
                }
            }
        }


















        private void btnThoat_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
