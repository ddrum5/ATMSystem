﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            MessageBox.Show(msg, "Quản lý ngân hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowMsg(string msg, bool err) {
            MessageBox.Show(msg, "Quản lý ngân hàng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}