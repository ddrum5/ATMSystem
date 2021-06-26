using System;

using System.Windows.Forms;

namespace WinFormsApp1 {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        ///  
        /// </summary>

        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formDangNhap());
        }

        public static void ShowMsg(string msg) {
            MessageBox.Show(msg, "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowMsg() {
            MessageBox.Show("Bạn phải điền đủ thông tin", "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowMsgConfirm(string msg) {
            MessageBox.Show(msg, "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }


        public static void ShowMsg(string msg, bool err) {
            MessageBox.Show(msg, "Techcombank ATM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


    }
}
