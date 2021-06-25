using System;

using WinFormsApp1.Ulti;
using MetroSet_UI.Forms;

namespace WinFormsApp1 {
    public partial class formDangNhap: MetroSetForm {
        
        string st;
        string nh;
        string pin;


        public formDangNhap() {
            InitializeComponent();

         
        }

       
    
        private void Form1_Load(object sender, EventArgs e) {
            ActiveControl = metroSetLabel1;

            cbTenNganHang.DataSource = new The().danhSachTenNganHang();
            cbTenNganHang.DropDownWidth = Tool.DropDownWidth(cbTenNganHang);
            inpSoThe.Text = "69999";
            inpPIN.Text = "123";
            cbTenNganHang.SelectedIndex = new The().danhSachMaNganHang().IndexOf("TPB");
            

        }

        

        private void btbDutThe_Click_Click(object sender, EventArgs e) {
            st = inpSoThe.Text;
            pin = inpPIN.Text;
            nh = new The().danhSachMaNganHang()[cbTenNganHang.SelectedIndex];

            if (new The().checkPin(st, nh, pin)) {
                MainUI mainUI = new MainUI(nh, st);
                Hide();
                mainUI.ShowDialog();
                Show();

            } else {
                Program.ShowMsg("Sai ma");
            }
        }


















        private void btnThoat_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
