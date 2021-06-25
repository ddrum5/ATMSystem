
using System.Windows.Forms;

namespace WinFormsApp1 {
    partial class MainUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabThongTinTK = new System.Windows.Forms.TabPage();
            this.listBoxSoTaiKhoan = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroSetBadge1 = new MetroSet_UI.Controls.MetroSetBadge();
            this.lbTenNganHang = new System.Windows.Forms.Label();
            this.lbTenChuTK = new System.Windows.Forms.Label();
            this.lbSoThe = new System.Windows.Forms.Label();
            this.tabRutTien = new System.Windows.Forms.TabPage();
            this.cb_rutTien_taiKhoanNguon = new System.Windows.Forms.ComboBox();
            this.btn_RutTien = new System.Windows.Forms.Button();
            this.checkBox_RutTien_inHoaDon = new System.Windows.Forms.CheckBox();
            this.tableTablayoutRutTien = new System.Windows.Forms.TableLayoutPanel();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_200 = new System.Windows.Forms.Button();
            this.btn_300 = new System.Windows.Forms.Button();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.btn_5000 = new System.Windows.Forms.Button();
            this.btn_soKhac = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inp_rutTien_soTienRut = new System.Windows.Forms.TextBox();
            this.tabChuyenTien = new System.Windows.Forms.TabPage();
            this.inp_chuyenTien_MoTa = new System.Windows.Forms.TextBox();
            this.inp_chuyenTien_soTien = new System.Windows.Forms.TextBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cb_ChuyenTien_ChonTaiKhoanNguon = new System.Windows.Forms.ComboBox();
            this.cb_ChuyenTien_ChonTenNganHang = new System.Windows.Forms.ComboBox();
            this.inp_ChuyenTien_SoTaiKhoan = new System.Windows.Forms.TextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btn_ChuyenTien = new System.Windows.Forms.Button();
            this.checkBox_ChuyenTien_InHoaDon = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabTraCuuSoDu = new System.Windows.Forms.TabPage();
            this.lb_TraCuu = new System.Windows.Forms.Label();
            this.cb_TraCuuSoDu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_TraCuuSoDu = new System.Windows.Forms.Button();
            this.tabSaoKe = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.listBox_SaoKe = new System.Windows.Forms.ListBox();
            this.tabDoiPin = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabThongTinTK.SuspendLayout();
            this.tabRutTien.SuspendLayout();
            this.tableTablayoutRutTien.SuspendLayout();
            this.tabChuyenTien.SuspendLayout();
            this.tabTraCuuSoDu.SuspendLayout();
            this.tabSaoKe.SuspendLayout();
            this.tabDoiPin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabThongTinTK);
            this.tabMain.Controls.Add(this.tabRutTien);
            this.tabMain.Controls.Add(this.tabChuyenTien);
            this.tabMain.Controls.Add(this.tabTraCuuSoDu);
            this.tabMain.Controls.Add(this.tabSaoKe);
            this.tabMain.Controls.Add(this.tabDoiPin);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabMain.ItemSize = new System.Drawing.Size(130, 40);
            this.tabMain.Location = new System.Drawing.Point(12, 77);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(8, 3);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(714, 559);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMain.TabIndex = 0;
            // 
            // tabThongTinTK
            // 
            this.tabThongTinTK.Controls.Add(this.listBoxSoTaiKhoan);
            this.tabThongTinTK.Controls.Add(this.label6);
            this.tabThongTinTK.Controls.Add(this.label2);
            this.tabThongTinTK.Controls.Add(this.label5);
            this.tabThongTinTK.Controls.Add(this.label4);
            this.tabThongTinTK.Controls.Add(this.metroSetBadge1);
            this.tabThongTinTK.Controls.Add(this.lbTenNganHang);
            this.tabThongTinTK.Controls.Add(this.lbTenChuTK);
            this.tabThongTinTK.Controls.Add(this.lbSoThe);
            this.tabThongTinTK.Location = new System.Drawing.Point(4, 44);
            this.tabThongTinTK.Name = "tabThongTinTK";
            this.tabThongTinTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTinTK.Size = new System.Drawing.Size(706, 511);
            this.tabThongTinTK.TabIndex = 0;
            this.tabThongTinTK.Text = "Thông tin tài khoản";
            this.tabThongTinTK.UseVisualStyleBackColor = true;
            // 
            // listBoxSoTaiKhoan
            // 
            this.listBoxSoTaiKhoan.FormattingEnabled = true;
            this.listBoxSoTaiKhoan.ItemHeight = 22;
            this.listBoxSoTaiKhoan.Location = new System.Drawing.Point(191, 156);
            this.listBoxSoTaiKhoan.Name = "listBoxSoTaiKhoan";
            this.listBoxSoTaiKhoan.Size = new System.Drawing.Size(357, 180);
            this.listBoxSoTaiKhoan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "ten ngan hang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "ten chu tai khoan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "SO TAI KHOAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "SO THE";
            // 
            // metroSetBadge1
            // 
            this.metroSetBadge1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetBadge1.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight;
            this.metroSetBadge1.BadgeText = "3";
            this.metroSetBadge1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetBadge1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetBadge1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetBadge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetBadge1.HoverBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(187)))), ((int)(((byte)(245)))));
            this.metroSetBadge1.HoverBadgeTextColor = System.Drawing.Color.White;
            this.metroSetBadge1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetBadge1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetBadge1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetBadge1.IsDerivedStyle = true;
            this.metroSetBadge1.Location = new System.Drawing.Point(429, 220);
            this.metroSetBadge1.Name = "metroSetBadge1";
            this.metroSetBadge1.NormalBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetBadge1.NormalBadgeTextColor = System.Drawing.Color.White;
            this.metroSetBadge1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetBadge1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetBadge1.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetBadge1.PressBadgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.metroSetBadge1.PressBadgeTextColor = System.Drawing.Color.White;
            this.metroSetBadge1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetBadge1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetBadge1.PressTextColor = System.Drawing.Color.White;
            this.metroSetBadge1.Size = new System.Drawing.Size(8, 8);
            this.metroSetBadge1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetBadge1.StyleManager = null;
            this.metroSetBadge1.TabIndex = 5;
            this.metroSetBadge1.Text = "metroSetBadge1";
            this.metroSetBadge1.ThemeAuthor = "Narwin";
            this.metroSetBadge1.ThemeName = "MetroLite";
            // 
            // lbTenNganHang
            // 
            this.lbTenNganHang.AutoSize = true;
            this.lbTenNganHang.Location = new System.Drawing.Point(191, 70);
            this.lbTenNganHang.Name = "lbTenNganHang";
            this.lbTenNganHang.Size = new System.Drawing.Size(78, 22);
            this.lbTenNganHang.TabIndex = 3;
            this.lbTenNganHang.Text = "TEN NH";
            // 
            // lbTenChuTK
            // 
            this.lbTenChuTK.AutoSize = true;
            this.lbTenChuTK.Location = new System.Drawing.Point(191, 26);
            this.lbTenChuTK.Name = "lbTenChuTK";
            this.lbTenChuTK.Size = new System.Drawing.Size(99, 22);
            this.lbTenChuTK.TabIndex = 2;
            this.lbTenChuTK.Text = "Tên Chủ tk";
            // 
            // lbSoThe
            // 
            this.lbSoThe.AutoSize = true;
            this.lbSoThe.Location = new System.Drawing.Point(191, 116);
            this.lbSoThe.Name = "lbSoThe";
            this.lbSoThe.Size = new System.Drawing.Size(59, 22);
            this.lbSoThe.TabIndex = 1;
            this.lbSoThe.Text = "so the";
            // 
            // tabRutTien
            // 
            this.tabRutTien.Controls.Add(this.cb_rutTien_taiKhoanNguon);
            this.tabRutTien.Controls.Add(this.btn_RutTien);
            this.tabRutTien.Controls.Add(this.checkBox_RutTien_inHoaDon);
            this.tabRutTien.Controls.Add(this.tableTablayoutRutTien);
            this.tabRutTien.Controls.Add(this.label7);
            this.tabRutTien.Controls.Add(this.label1);
            this.tabRutTien.Controls.Add(this.inp_rutTien_soTienRut);
            this.tabRutTien.Location = new System.Drawing.Point(4, 44);
            this.tabRutTien.Name = "tabRutTien";
            this.tabRutTien.Padding = new System.Windows.Forms.Padding(3);
            this.tabRutTien.Size = new System.Drawing.Size(706, 511);
            this.tabRutTien.TabIndex = 1;
            this.tabRutTien.Text = "Rút Tiền";
            this.tabRutTien.UseVisualStyleBackColor = true;
            // 
            // cb_rutTien_taiKhoanNguon
            // 
            this.cb_rutTien_taiKhoanNguon.FormattingEnabled = true;
            this.cb_rutTien_taiKhoanNguon.Location = new System.Drawing.Point(94, 67);
            this.cb_rutTien_taiKhoanNguon.Name = "cb_rutTien_taiKhoanNguon";
            this.cb_rutTien_taiKhoanNguon.Size = new System.Drawing.Size(500, 30);
            this.cb_rutTien_taiKhoanNguon.TabIndex = 5;
            // 
            // btn_RutTien
            // 
            this.btn_RutTien.BackColor = System.Drawing.Color.Brown;
            this.btn_RutTien.ForeColor = System.Drawing.Color.White;
            this.btn_RutTien.Location = new System.Drawing.Point(97, 424);
            this.btn_RutTien.Name = "btn_RutTien";
            this.btn_RutTien.Size = new System.Drawing.Size(494, 54);
            this.btn_RutTien.TabIndex = 4;
            this.btn_RutTien.Text = "Rút Tiền";
            this.btn_RutTien.UseVisualStyleBackColor = false;
            this.btn_RutTien.Click += new System.EventHandler(this.btn_RutTien_Click);
            // 
            // checkBox_RutTien_inHoaDon
            // 
            this.checkBox_RutTien_inHoaDon.AutoSize = true;
            this.checkBox_RutTien_inHoaDon.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox_RutTien_inHoaDon.Location = new System.Drawing.Point(287, 392);
            this.checkBox_RutTien_inHoaDon.Name = "checkBox_RutTien_inHoaDon";
            this.checkBox_RutTien_inHoaDon.Size = new System.Drawing.Size(119, 26);
            this.checkBox_RutTien_inHoaDon.TabIndex = 3;
            this.checkBox_RutTien_inHoaDon.Text = "In Hoá Đơn";
            this.checkBox_RutTien_inHoaDon.UseVisualStyleBackColor = true;
            // 
            // tableTablayoutRutTien
            // 
            this.tableTablayoutRutTien.BackColor = System.Drawing.Color.Transparent;
            this.tableTablayoutRutTien.ColumnCount = 3;
            this.tableTablayoutRutTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.61728F));
            this.tableTablayoutRutTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.38272F));
            this.tableTablayoutRutTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableTablayoutRutTien.Controls.Add(this.btn_100, 0, 0);
            this.tableTablayoutRutTien.Controls.Add(this.btn_200, 1, 0);
            this.tableTablayoutRutTien.Controls.Add(this.btn_300, 2, 0);
            this.tableTablayoutRutTien.Controls.Add(this.btn_1000, 0, 1);
            this.tableTablayoutRutTien.Controls.Add(this.btn_5000, 1, 1);
            this.tableTablayoutRutTien.Controls.Add(this.btn_soKhac, 2, 1);
            this.tableTablayoutRutTien.ForeColor = System.Drawing.Color.DimGray;
            this.tableTablayoutRutTien.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableTablayoutRutTien.Location = new System.Drawing.Point(94, 210);
            this.tableTablayoutRutTien.Name = "tableTablayoutRutTien";
            this.tableTablayoutRutTien.RowCount = 2;
            this.tableTablayoutRutTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTablayoutRutTien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableTablayoutRutTien.Size = new System.Drawing.Size(500, 163);
            this.tableTablayoutRutTien.TabIndex = 2;
            // 
            // btn_100
            // 
            this.btn_100.AutoSize = true;
            this.btn_100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_100.Location = new System.Drawing.Point(3, 3);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(160, 75);
            this.btn_100.TabIndex = 0;
            this.btn_100.Text = "100.000 VNĐ";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_200
            // 
            this.btn_200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_200.Location = new System.Drawing.Point(169, 3);
            this.btn_200.Name = "btn_200";
            this.btn_200.Size = new System.Drawing.Size(156, 75);
            this.btn_200.TabIndex = 1;
            this.btn_200.Text = "200.000 VNĐ";
            this.btn_200.UseVisualStyleBackColor = true;
            this.btn_200.Click += new System.EventHandler(this.btn_200_Click);
            // 
            // btn_300
            // 
            this.btn_300.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_300.Location = new System.Drawing.Point(331, 3);
            this.btn_300.Name = "btn_300";
            this.btn_300.Size = new System.Drawing.Size(166, 75);
            this.btn_300.TabIndex = 2;
            this.btn_300.Text = "500.000 VNĐ";
            this.btn_300.UseVisualStyleBackColor = true;
            this.btn_300.Click += new System.EventHandler(this.btn_300_Click);
            // 
            // btn_1000
            // 
            this.btn_1000.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1000.Location = new System.Drawing.Point(3, 84);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(160, 76);
            this.btn_1000.TabIndex = 3;
            this.btn_1000.Text = "1.000.000 VNĐ";
            this.btn_1000.UseVisualStyleBackColor = true;
            this.btn_1000.Click += new System.EventHandler(this.btn_1000_Click);
            // 
            // btn_5000
            // 
            this.btn_5000.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5000.Location = new System.Drawing.Point(169, 84);
            this.btn_5000.Name = "btn_5000";
            this.btn_5000.Size = new System.Drawing.Size(156, 76);
            this.btn_5000.TabIndex = 4;
            this.btn_5000.Text = "5.000.000 VNĐ";
            this.btn_5000.UseVisualStyleBackColor = true;
            this.btn_5000.Click += new System.EventHandler(this.btn_5000_Click);
            // 
            // btn_soKhac
            // 
            this.btn_soKhac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_soKhac.Location = new System.Drawing.Point(331, 84);
            this.btn_soKhac.Name = "btn_soKhac";
            this.btn_soKhac.Size = new System.Drawing.Size(166, 76);
            this.btn_soKhac.TabIndex = 5;
            this.btn_soKhac.Text = "Số Khác";
            this.btn_soKhac.UseVisualStyleBackColor = true;
            this.btn_soKhac.Click += new System.EventHandler(this.btn_soKhac_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(90, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "*Chọn tài khoản nguồn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(91, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Nhập số tiền";
            // 
            // inp_rutTien_soTienRut
            // 
            this.inp_rutTien_soTienRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_rutTien_soTienRut.Location = new System.Drawing.Point(94, 151);
            this.inp_rutTien_soTienRut.Multiline = true;
            this.inp_rutTien_soTienRut.Name = "inp_rutTien_soTienRut";
            this.inp_rutTien_soTienRut.PlaceholderText = " Nhập số tiền cần rút";
            this.inp_rutTien_soTienRut.Size = new System.Drawing.Size(500, 34);
            this.inp_rutTien_soTienRut.TabIndex = 0;
            this.inp_rutTien_soTienRut.Leave += new System.EventHandler(this.inp_rutTien_soTienRut_Leave);
            // 
            // tabChuyenTien
            // 
            this.tabChuyenTien.Controls.Add(this.inp_chuyenTien_MoTa);
            this.tabChuyenTien.Controls.Add(this.inp_chuyenTien_soTien);
            this.tabChuyenTien.Controls.Add(this.metroSetLabel7);
            this.tabChuyenTien.Controls.Add(this.cb_ChuyenTien_ChonTaiKhoanNguon);
            this.tabChuyenTien.Controls.Add(this.cb_ChuyenTien_ChonTenNganHang);
            this.tabChuyenTien.Controls.Add(this.inp_ChuyenTien_SoTaiKhoan);
            this.tabChuyenTien.Controls.Add(this.metroSetLabel2);
            this.tabChuyenTien.Controls.Add(this.metroSetLabel8);
            this.tabChuyenTien.Controls.Add(this.metroSetLabel3);
            this.tabChuyenTien.Controls.Add(this.metroSetLabel1);
            this.tabChuyenTien.Controls.Add(this.btn_ChuyenTien);
            this.tabChuyenTien.Controls.Add(this.checkBox_ChuyenTien_InHoaDon);
            this.tabChuyenTien.Controls.Add(this.label3);
            this.tabChuyenTien.Location = new System.Drawing.Point(4, 44);
            this.tabChuyenTien.Name = "tabChuyenTien";
            this.tabChuyenTien.Padding = new System.Windows.Forms.Padding(3);
            this.tabChuyenTien.Size = new System.Drawing.Size(706, 511);
            this.tabChuyenTien.TabIndex = 2;
            this.tabChuyenTien.Text = "Chuyển Tiền";
            this.tabChuyenTien.UseVisualStyleBackColor = true;
            // 
            // inp_chuyenTien_MoTa
            // 
            this.inp_chuyenTien_MoTa.Location = new System.Drawing.Point(178, 271);
            this.inp_chuyenTien_MoTa.Multiline = true;
            this.inp_chuyenTien_MoTa.Name = "inp_chuyenTien_MoTa";
            this.inp_chuyenTien_MoTa.PlaceholderText = " mô tả (không bắt buộc)";
            this.inp_chuyenTien_MoTa.Size = new System.Drawing.Size(394, 72);
            this.inp_chuyenTien_MoTa.TabIndex = 16;
            // 
            // inp_chuyenTien_soTien
            // 
            this.inp_chuyenTien_soTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_chuyenTien_soTien.Location = new System.Drawing.Point(178, 171);
            this.inp_chuyenTien_soTien.Multiline = true;
            this.inp_chuyenTien_soTien.Name = "inp_chuyenTien_soTien";
            this.inp_chuyenTien_soTien.PlaceholderText = " số tiền cần chuyển";
            this.inp_chuyenTien_soTien.Size = new System.Drawing.Size(394, 32);
            this.inp_chuyenTien_soTien.TabIndex = 14;
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel7.IsDerivedStyle = true;
            this.metroSetLabel7.Location = new System.Drawing.Point(59, 171);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(106, 21);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 15;
            this.metroSetLabel7.Text = "Số tiền";
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // cb_ChuyenTien_ChonTaiKhoanNguon
            // 
            this.cb_ChuyenTien_ChonTaiKhoanNguon.FormattingEnabled = true;
            this.cb_ChuyenTien_ChonTaiKhoanNguon.Location = new System.Drawing.Point(178, 220);
            this.cb_ChuyenTien_ChonTaiKhoanNguon.Name = "cb_ChuyenTien_ChonTaiKhoanNguon";
            this.cb_ChuyenTien_ChonTaiKhoanNguon.Size = new System.Drawing.Size(394, 30);
            this.cb_ChuyenTien_ChonTaiKhoanNguon.TabIndex = 10;
            // 
            // cb_ChuyenTien_ChonTenNganHang
            // 
            this.cb_ChuyenTien_ChonTenNganHang.FormattingEnabled = true;
            this.cb_ChuyenTien_ChonTenNganHang.Location = new System.Drawing.Point(178, 74);
            this.cb_ChuyenTien_ChonTenNganHang.Name = "cb_ChuyenTien_ChonTenNganHang";
            this.cb_ChuyenTien_ChonTenNganHang.Size = new System.Drawing.Size(394, 30);
            this.cb_ChuyenTien_ChonTenNganHang.TabIndex = 10;
            // 
            // inp_ChuyenTien_SoTaiKhoan
            // 
            this.inp_ChuyenTien_SoTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_ChuyenTien_SoTaiKhoan.Location = new System.Drawing.Point(178, 122);
            this.inp_ChuyenTien_SoTaiKhoan.Multiline = true;
            this.inp_ChuyenTien_SoTaiKhoan.Name = "inp_ChuyenTien_SoTaiKhoan";
            this.inp_ChuyenTien_SoTaiKhoan.PlaceholderText = " số tài khoản cần chuyển";
            this.inp_ChuyenTien_SoTaiKhoan.Size = new System.Drawing.Size(394, 32);
            this.inp_ChuyenTien_SoTaiKhoan.TabIndex = 5;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(59, 122);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(106, 21);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 13;
            this.metroSetLabel2.Text = "Số tài khoản";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel8.IsDerivedStyle = true;
            this.metroSetLabel8.Location = new System.Drawing.Point(60, 284);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(100, 46);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 12;
            this.metroSetLabel8.Text = "Mô tả";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(59, 220);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(100, 46);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 12;
            this.metroSetLabel3.Text = "Tài khoản nguồn";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(59, 74);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(101, 30);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 12;
            this.metroSetLabel1.Text = "Chọn ngân hàng";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // btn_ChuyenTien
            // 
            this.btn_ChuyenTien.BackColor = System.Drawing.Color.Brown;
            this.btn_ChuyenTien.ForeColor = System.Drawing.Color.White;
            this.btn_ChuyenTien.Location = new System.Drawing.Point(178, 405);
            this.btn_ChuyenTien.Name = "btn_ChuyenTien";
            this.btn_ChuyenTien.Size = new System.Drawing.Size(394, 54);
            this.btn_ChuyenTien.TabIndex = 9;
            this.btn_ChuyenTien.Text = "Chuyển Tiền";
            this.btn_ChuyenTien.UseVisualStyleBackColor = false;
            this.btn_ChuyenTien.Click += new System.EventHandler(this.btn_ChuyenTien_Click);
            // 
            // checkBox_ChuyenTien_InHoaDon
            // 
            this.checkBox_ChuyenTien_InHoaDon.AutoSize = true;
            this.checkBox_ChuyenTien_InHoaDon.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox_ChuyenTien_InHoaDon.Location = new System.Drawing.Point(294, 363);
            this.checkBox_ChuyenTien_InHoaDon.Name = "checkBox_ChuyenTien_InHoaDon";
            this.checkBox_ChuyenTien_InHoaDon.Size = new System.Drawing.Size(119, 26);
            this.checkBox_ChuyenTien_InHoaDon.TabIndex = 8;
            this.checkBox_ChuyenTien_InHoaDon.Text = "In Hoá Đơn";
            this.checkBox_ChuyenTien_InHoaDon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(178, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Chọn ngân hàng, số tài khoản cần chuyển";
            // 
            // tabTraCuuSoDu
            // 
            this.tabTraCuuSoDu.Controls.Add(this.lb_TraCuu);
            this.tabTraCuuSoDu.Controls.Add(this.cb_TraCuuSoDu);
            this.tabTraCuuSoDu.Controls.Add(this.label9);
            this.tabTraCuuSoDu.Controls.Add(this.btn_TraCuuSoDu);
            this.tabTraCuuSoDu.Location = new System.Drawing.Point(4, 44);
            this.tabTraCuuSoDu.Name = "tabTraCuuSoDu";
            this.tabTraCuuSoDu.Size = new System.Drawing.Size(706, 511);
            this.tabTraCuuSoDu.TabIndex = 3;
            this.tabTraCuuSoDu.Text = "Tra Cứu Số Dư";
            this.tabTraCuuSoDu.UseVisualStyleBackColor = true;
            // 
            // lb_TraCuu
            // 
            this.lb_TraCuu.AutoSize = true;
            this.lb_TraCuu.Location = new System.Drawing.Point(261, 226);
            this.lb_TraCuu.Name = "lb_TraCuu";
            this.lb_TraCuu.Size = new System.Drawing.Size(0, 22);
            this.lb_TraCuu.TabIndex = 13;
            this.lb_TraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_TraCuuSoDu
            // 
            this.cb_TraCuuSoDu.FormattingEnabled = true;
            this.cb_TraCuuSoDu.Location = new System.Drawing.Point(85, 74);
            this.cb_TraCuuSoDu.Name = "cb_TraCuuSoDu";
            this.cb_TraCuuSoDu.Size = new System.Drawing.Size(500, 30);
            this.cb_TraCuuSoDu.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(85, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "*Chọn tài khoản nguồn";
            // 
            // btn_TraCuuSoDu
            // 
            this.btn_TraCuuSoDu.BackColor = System.Drawing.Color.Brown;
            this.btn_TraCuuSoDu.ForeColor = System.Drawing.Color.White;
            this.btn_TraCuuSoDu.Location = new System.Drawing.Point(85, 132);
            this.btn_TraCuuSoDu.Name = "btn_TraCuuSoDu";
            this.btn_TraCuuSoDu.Size = new System.Drawing.Size(500, 44);
            this.btn_TraCuuSoDu.TabIndex = 10;
            this.btn_TraCuuSoDu.Text = "Tra cứu";
            this.btn_TraCuuSoDu.UseVisualStyleBackColor = false;
            this.btn_TraCuuSoDu.Click += new System.EventHandler(this.btn_TraCuuSoDu_Click);
            // 
            // tabSaoKe
            // 
            this.tabSaoKe.Controls.Add(this.button9);
            this.tabSaoKe.Controls.Add(this.listBox_SaoKe);
            this.tabSaoKe.Location = new System.Drawing.Point(4, 44);
            this.tabSaoKe.Name = "tabSaoKe";
            this.tabSaoKe.Size = new System.Drawing.Size(706, 511);
            this.tabSaoKe.TabIndex = 4;
            this.tabSaoKe.Text = "Sao kê";
            this.tabSaoKe.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Brown;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(180, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(326, 43);
            this.button9.TabIndex = 11;
            this.button9.Text = "Sao kê";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // listBox_SaoKe
            // 
            this.listBox_SaoKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox_SaoKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.267326F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_SaoKe.FormattingEnabled = true;
            this.listBox_SaoKe.ItemHeight = 16;
            this.listBox_SaoKe.Location = new System.Drawing.Point(0, 91);
            this.listBox_SaoKe.Name = "listBox_SaoKe";
            this.listBox_SaoKe.Size = new System.Drawing.Size(706, 420);
            this.listBox_SaoKe.TabIndex = 12;
            // 
            // tabDoiPin
            // 
            this.tabDoiPin.Controls.Add(this.label8);
            this.tabDoiPin.Controls.Add(this.metroSetLabel6);
            this.tabDoiPin.Controls.Add(this.metroSetLabel5);
            this.tabDoiPin.Controls.Add(this.metroSetLabel4);
            this.tabDoiPin.Controls.Add(this.textBox4);
            this.tabDoiPin.Controls.Add(this.textBox3);
            this.tabDoiPin.Controls.Add(this.textBox2);
            this.tabDoiPin.Controls.Add(this.button10);
            this.tabDoiPin.Location = new System.Drawing.Point(4, 44);
            this.tabDoiPin.Name = "tabDoiPin";
            this.tabDoiPin.Size = new System.Drawing.Size(706, 511);
            this.tabDoiPin.TabIndex = 5;
            this.tabDoiPin.Text = "Đổi PIN";
            this.tabDoiPin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(267, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "*Nhập PIN cũ và PIN mới";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(62, 114);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(107, 45);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 15;
            this.metroSetLabel6.Text = "Mã PIN cũ";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(62, 189);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(107, 45);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 15;
            this.metroSetLabel5.Text = "Mã PIN mới";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Arial", 10.69307F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(62, 258);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(107, 45);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 15;
            this.metroSetLabel4.Text = "Nhập lại PIN mới";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(194, 114);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(394, 32);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(194, 189);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(394, 32);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(194, 258);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(394, 32);
            this.textBox2.TabIndex = 14;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Maroon;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(194, 357);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(394, 54);
            this.button10.TabIndex = 5;
            this.button10.Text = "Rút Tiền";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.267326F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.Maroon;
            this.btn_logout.Location = new System.Drawing.Point(666, 8);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(60, 32);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Thoát";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 651);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainUI";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.tabMain.ResumeLayout(false);
            this.tabThongTinTK.ResumeLayout(false);
            this.tabThongTinTK.PerformLayout();
            this.tabRutTien.ResumeLayout(false);
            this.tabRutTien.PerformLayout();
            this.tableTablayoutRutTien.ResumeLayout(false);
            this.tableTablayoutRutTien.PerformLayout();
            this.tabChuyenTien.ResumeLayout(false);
            this.tabChuyenTien.PerformLayout();
            this.tabTraCuuSoDu.ResumeLayout(false);
            this.tabTraCuuSoDu.PerformLayout();
            this.tabSaoKe.ResumeLayout(false);
            this.tabDoiPin.ResumeLayout(false);
            this.tabDoiPin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabThongTinTK;
        private System.Windows.Forms.TabPage tabRutTien;
        private System.Windows.Forms.TabPage tabChuyenTien;
        private TabPage tabTraCuuSoDu;
        private Label lbTenChuTK;
        private Label lbSoThe;
        private TextBox inp_rutTien_soTienRut;
        private Label label1;
        private TableLayoutPanel tableTablayoutRutTien;
        private Button btn_200;
        private Button btn_300;
        private CheckBox checkBox_RutTien_inHoaDon;
        private Button btn_RutTien;
        private Label lbTenNganHang;
        private MetroSet_UI.Controls.MetroSetBadge metroSetBadge1;
        private Button btn_5000;
        private Button btn_soKhac;
        private Button btn_100;
        private PictureBox pictureBox1;
        private Button btn_ChuyenTien;
        private CheckBox checkBox_ChuyenTien_InHoaDon;
        private Label label3;
        private TextBox inp_ChuyenTien_SoTaiKhoan;
        private ComboBox cb_ChuyenTien_ChonTenNganHang;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private Label label6;
        private Label label2;
        private Label label5;
        private Label label4;
        private TabPage tabSaoKe;
        private TabPage tabDoiPin;
        private ComboBox cb_rutTien_taiKhoanNguon;
        private Button btn_1000;
        private Label label7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private ComboBox cb_ChuyenTien_ChonTaiKhoanNguon;
        private Button btn_TraCuuSoDu;
        private Button button9;
        private Label label8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button10;
        private ComboBox cb_TraCuuSoDu;
        private Label label9;
        private Label lb_TraCuu;
        private TextBox inp_chuyenTien_soTien;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private TextBox inp_chuyenTien_MoTa;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private ListBox listBoxSoTaiKhoan;
        private ListBox listBox_SaoKe;
        private Button btn_logout;
    }
}