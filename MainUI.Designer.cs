
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
            this.btn_MoThemTaiKhoan = new System.Windows.Forms.Button();
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
            this.tab_NapTien = new System.Windows.Forms.TabPage();
            this.btn_NapTien = new System.Windows.Forms.Button();
            this.checkBox_NapTiep_InHoaDon = new System.Windows.Forms.CheckBox();
            this.cb_NapTien_TaiKhoanNguon = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inp_NapTien_SoTienNap = new System.Windows.Forms.TextBox();
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
            this.comboBox_SaoKe = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaoKe = new System.Windows.Forms.Button();
            this.listBox_SaoKe = new System.Windows.Forms.ListBox();
            this.tabDoiPin = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.inp_pinCu = new System.Windows.Forms.TextBox();
            this.inp_pinMoi = new System.Windows.Forms.TextBox();
            this.inp_XacNhanPinMoi = new System.Windows.Forms.TextBox();
            this.btn_DoiPin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabThongTinTK.SuspendLayout();
            this.tabRutTien.SuspendLayout();
            this.tableTablayoutRutTien.SuspendLayout();
            this.tab_NapTien.SuspendLayout();
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
            this.tabMain.Controls.Add(this.tab_NapTien);
            this.tabMain.Controls.Add(this.tabChuyenTien);
            this.tabMain.Controls.Add(this.tabTraCuuSoDu);
            this.tabMain.Controls.Add(this.tabSaoKe);
            this.tabMain.Controls.Add(this.tabDoiPin);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabMain.ItemSize = new System.Drawing.Size(70, 40);
            this.tabMain.Location = new System.Drawing.Point(12, 77);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(8, 3);
            this.tabMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(714, 559);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabThongTinTK
            // 
            this.tabThongTinTK.Controls.Add(this.btn_MoThemTaiKhoan);
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
            // btn_MoThemTaiKhoan
            // 
            this.btn_MoThemTaiKhoan.BackColor = System.Drawing.Color.Brown;
            this.btn_MoThemTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MoThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btn_MoThemTaiKhoan.Location = new System.Drawing.Point(249, 385);
            this.btn_MoThemTaiKhoan.Name = "btn_MoThemTaiKhoan";
            this.btn_MoThemTaiKhoan.Size = new System.Drawing.Size(228, 80);
            this.btn_MoThemTaiKhoan.TabIndex = 12;
            this.btn_MoThemTaiKhoan.Text = "Mở thêm tài khoản";
            this.btn_MoThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_MoThemTaiKhoan.Click += new System.EventHandler(this.btn_MoThemTaiKhoan_Click);
            // 
            // listBoxSoTaiKhoan
            // 
            this.listBoxSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxSoTaiKhoan.ForeColor = System.Drawing.Color.IndianRed;
            this.listBoxSoTaiKhoan.FormattingEnabled = true;
            this.listBoxSoTaiKhoan.ItemHeight = 22;
            this.listBoxSoTaiKhoan.Location = new System.Drawing.Point(191, 156);
            this.listBoxSoTaiKhoan.Name = "listBoxSoTaiKhoan";
            this.listBoxSoTaiKhoan.Size = new System.Drawing.Size(357, 158);
            this.listBoxSoTaiKhoan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(41, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngân hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(41, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chủ tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(41, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(41, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số thẻ";
            // 
            // metroSetBadge1
            // 
            this.metroSetBadge1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetBadge1.BadgeAlignment = MetroSet_UI.Enums.BadgeAlign.TopRight;
            this.metroSetBadge1.BadgeText = "3";
            this.metroSetBadge1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetBadge1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetBadge1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetBadge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lbTenNganHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTenNganHang.ForeColor = System.Drawing.Color.Firebrick;
            this.lbTenNganHang.Location = new System.Drawing.Point(191, 70);
            this.lbTenNganHang.Name = "lbTenNganHang";
            this.lbTenNganHang.Size = new System.Drawing.Size(78, 22);
            this.lbTenNganHang.TabIndex = 3;
            this.lbTenNganHang.Text = "TEN NH";
            // 
            // lbTenChuTK
            // 
            this.lbTenChuTK.AutoSize = true;
            this.lbTenChuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTenChuTK.ForeColor = System.Drawing.Color.Firebrick;
            this.lbTenChuTK.Location = new System.Drawing.Point(191, 26);
            this.lbTenChuTK.Name = "lbTenChuTK";
            this.lbTenChuTK.Size = new System.Drawing.Size(99, 22);
            this.lbTenChuTK.TabIndex = 2;
            this.lbTenChuTK.Text = "Tên Chủ tk";
            // 
            // lbSoThe
            // 
            this.lbSoThe.AutoSize = true;
            this.lbSoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSoThe.ForeColor = System.Drawing.Color.Firebrick;
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
            this.cb_rutTien_taiKhoanNguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rutTien_taiKhoanNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_rutTien_taiKhoanNguon.FormattingEnabled = true;
            this.cb_rutTien_taiKhoanNguon.Location = new System.Drawing.Point(94, 67);
            this.cb_rutTien_taiKhoanNguon.Name = "cb_rutTien_taiKhoanNguon";
            this.cb_rutTien_taiKhoanNguon.Size = new System.Drawing.Size(500, 30);
            this.cb_rutTien_taiKhoanNguon.TabIndex = 5;
            // 
            // btn_RutTien
            // 
            this.btn_RutTien.BackColor = System.Drawing.Color.Brown;
            this.btn_RutTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.checkBox_RutTien_inHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.tableTablayoutRutTien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableTablayoutRutTien.Controls.Add(this.btn_100, 0, 0);
            this.tableTablayoutRutTien.Controls.Add(this.btn_200, 1, 0);
            this.tableTablayoutRutTien.Controls.Add(this.btn_300, 2, 0);
            this.tableTablayoutRutTien.Controls.Add(this.btn_1000, 0, 1);
            this.tableTablayoutRutTien.Controls.Add(this.btn_5000, 1, 1);
            this.tableTablayoutRutTien.Controls.Add(this.btn_soKhac, 2, 1);
            this.tableTablayoutRutTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.btn_100.Size = new System.Drawing.Size(150, 75);
            this.btn_100.TabIndex = 0;
            this.btn_100.Text = "100.000 VNĐ";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // btn_200
            // 
            this.btn_200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_200.Location = new System.Drawing.Point(159, 3);
            this.btn_200.Name = "btn_200";
            this.btn_200.Size = new System.Drawing.Size(147, 75);
            this.btn_200.TabIndex = 1;
            this.btn_200.Text = "200.000 VNĐ";
            this.btn_200.UseVisualStyleBackColor = true;
            this.btn_200.Click += new System.EventHandler(this.btn_200_Click);
            // 
            // btn_300
            // 
            this.btn_300.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_300.Location = new System.Drawing.Point(312, 3);
            this.btn_300.Name = "btn_300";
            this.btn_300.Size = new System.Drawing.Size(185, 75);
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
            this.btn_1000.Size = new System.Drawing.Size(150, 76);
            this.btn_1000.TabIndex = 3;
            this.btn_1000.Text = "1.000.000 VNĐ";
            this.btn_1000.UseVisualStyleBackColor = true;
            this.btn_1000.Click += new System.EventHandler(this.btn_1000_Click);
            // 
            // btn_5000
            // 
            this.btn_5000.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5000.Location = new System.Drawing.Point(159, 84);
            this.btn_5000.Name = "btn_5000";
            this.btn_5000.Size = new System.Drawing.Size(147, 76);
            this.btn_5000.TabIndex = 4;
            this.btn_5000.Text = "5.000.000 VNĐ";
            this.btn_5000.UseVisualStyleBackColor = true;
            this.btn_5000.Click += new System.EventHandler(this.btn_5000_Click);
            // 
            // btn_soKhac
            // 
            this.btn_soKhac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_soKhac.Location = new System.Drawing.Point(312, 84);
            this.btn_soKhac.Name = "btn_soKhac";
            this.btn_soKhac.Size = new System.Drawing.Size(185, 76);
            this.btn_soKhac.TabIndex = 5;
            this.btn_soKhac.Text = "Số Khác";
            this.btn_soKhac.UseVisualStyleBackColor = true;
            this.btn_soKhac.Click += new System.EventHandler(this.btn_soKhac_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.inp_rutTien_soTienRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_rutTien_soTienRut.Location = new System.Drawing.Point(94, 151);
            this.inp_rutTien_soTienRut.MaxLength = 15;
            this.inp_rutTien_soTienRut.Multiline = true;
            this.inp_rutTien_soTienRut.Name = "inp_rutTien_soTienRut";
            this.inp_rutTien_soTienRut.PlaceholderText = " Nhập số tiền cần rút";
            this.inp_rutTien_soTienRut.Size = new System.Drawing.Size(500, 34);
            this.inp_rutTien_soTienRut.TabIndex = 0;
            this.inp_rutTien_soTienRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_rutTien_soTienRut_KeyPress);
            // 
            // tab_NapTien
            // 
            this.tab_NapTien.Controls.Add(this.btn_NapTien);
            this.tab_NapTien.Controls.Add(this.checkBox_NapTiep_InHoaDon);
            this.tab_NapTien.Controls.Add(this.cb_NapTien_TaiKhoanNguon);
            this.tab_NapTien.Controls.Add(this.label11);
            this.tab_NapTien.Controls.Add(this.label12);
            this.tab_NapTien.Controls.Add(this.inp_NapTien_SoTienNap);
            this.tab_NapTien.ForeColor = System.Drawing.Color.Gray;
            this.tab_NapTien.Location = new System.Drawing.Point(4, 44);
            this.tab_NapTien.Name = "tab_NapTien";
            this.tab_NapTien.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NapTien.Size = new System.Drawing.Size(706, 511);
            this.tab_NapTien.TabIndex = 6;
            this.tab_NapTien.Text = "Nạp tiền";
            this.tab_NapTien.UseVisualStyleBackColor = true;
            // 
            // btn_NapTien
            // 
            this.btn_NapTien.BackColor = System.Drawing.Color.Brown;
            this.btn_NapTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NapTien.ForeColor = System.Drawing.Color.White;
            this.btn_NapTien.Location = new System.Drawing.Point(103, 299);
            this.btn_NapTien.Name = "btn_NapTien";
            this.btn_NapTien.Size = new System.Drawing.Size(494, 54);
            this.btn_NapTien.TabIndex = 11;
            this.btn_NapTien.Text = "Nạp Tiền";
            this.btn_NapTien.UseVisualStyleBackColor = false;
            this.btn_NapTien.Click += new System.EventHandler(this.btn_NapTien_Click);
            // 
            // checkBox_NapTiep_InHoaDon
            // 
            this.checkBox_NapTiep_InHoaDon.AutoSize = true;
            this.checkBox_NapTiep_InHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_NapTiep_InHoaDon.ForeColor = System.Drawing.Color.DarkRed;
            this.checkBox_NapTiep_InHoaDon.Location = new System.Drawing.Point(291, 256);
            this.checkBox_NapTiep_InHoaDon.Name = "checkBox_NapTiep_InHoaDon";
            this.checkBox_NapTiep_InHoaDon.Size = new System.Drawing.Size(119, 26);
            this.checkBox_NapTiep_InHoaDon.TabIndex = 10;
            this.checkBox_NapTiep_InHoaDon.Text = "In Hoá Đơn";
            this.checkBox_NapTiep_InHoaDon.UseVisualStyleBackColor = true;
            // 
            // cb_NapTien_TaiKhoanNguon
            // 
            this.cb_NapTien_TaiKhoanNguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NapTien_TaiKhoanNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_NapTien_TaiKhoanNguon.FormattingEnabled = true;
            this.cb_NapTien_TaiKhoanNguon.Location = new System.Drawing.Point(103, 94);
            this.cb_NapTien_TaiKhoanNguon.Name = "cb_NapTien_TaiKhoanNguon";
            this.cb_NapTien_TaiKhoanNguon.Size = new System.Drawing.Size(500, 30);
            this.cb_NapTien_TaiKhoanNguon.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(99, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "*Chọn tài khoản nguồn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(100, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 22);
            this.label12.TabIndex = 8;
            this.label12.Text = "*Nhập số tiền";
            // 
            // inp_NapTien_SoTienNap
            // 
            this.inp_NapTien_SoTienNap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_NapTien_SoTienNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_NapTien_SoTienNap.Location = new System.Drawing.Point(103, 178);
            this.inp_NapTien_SoTienNap.MaxLength = 15;
            this.inp_NapTien_SoTienNap.Multiline = true;
            this.inp_NapTien_SoTienNap.Name = "inp_NapTien_SoTienNap";
            this.inp_NapTien_SoTienNap.PlaceholderText = " Nhập số tiền cần nạp";
            this.inp_NapTien_SoTienNap.Size = new System.Drawing.Size(500, 34);
            this.inp_NapTien_SoTienNap.TabIndex = 6;
            this.inp_NapTien_SoTienNap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_NapTien_SoTienNap_KeyPress);
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
            this.inp_chuyenTien_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_chuyenTien_MoTa.Location = new System.Drawing.Point(178, 271);
            this.inp_chuyenTien_MoTa.MaxLength = 100;
            this.inp_chuyenTien_MoTa.Multiline = true;
            this.inp_chuyenTien_MoTa.Name = "inp_chuyenTien_MoTa";
            this.inp_chuyenTien_MoTa.PlaceholderText = " mô tả (không bắt buộc)";
            this.inp_chuyenTien_MoTa.Size = new System.Drawing.Size(394, 72);
            this.inp_chuyenTien_MoTa.TabIndex = 16;
            // 
            // inp_chuyenTien_soTien
            // 
            this.inp_chuyenTien_soTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_chuyenTien_soTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_chuyenTien_soTien.Location = new System.Drawing.Point(178, 171);
            this.inp_chuyenTien_soTien.MaxLength = 15;
            this.inp_chuyenTien_soTien.Multiline = true;
            this.inp_chuyenTien_soTien.Name = "inp_chuyenTien_soTien";
            this.inp_chuyenTien_soTien.PlaceholderText = " số tiền cần chuyển";
            this.inp_chuyenTien_soTien.Size = new System.Drawing.Size(394, 32);
            this.inp_chuyenTien_soTien.TabIndex = 14;
            this.inp_chuyenTien_soTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_chuyenTien_soTien_KeyPress);
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.cb_ChuyenTien_ChonTaiKhoanNguon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChuyenTien_ChonTaiKhoanNguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_ChuyenTien_ChonTaiKhoanNguon.FormattingEnabled = true;
            this.cb_ChuyenTien_ChonTaiKhoanNguon.Location = new System.Drawing.Point(178, 220);
            this.cb_ChuyenTien_ChonTaiKhoanNguon.Name = "cb_ChuyenTien_ChonTaiKhoanNguon";
            this.cb_ChuyenTien_ChonTaiKhoanNguon.Size = new System.Drawing.Size(394, 30);
            this.cb_ChuyenTien_ChonTaiKhoanNguon.TabIndex = 10;
            // 
            // cb_ChuyenTien_ChonTenNganHang
            // 
            this.cb_ChuyenTien_ChonTenNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChuyenTien_ChonTenNganHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_ChuyenTien_ChonTenNganHang.FormattingEnabled = true;
            this.cb_ChuyenTien_ChonTenNganHang.Location = new System.Drawing.Point(178, 74);
            this.cb_ChuyenTien_ChonTenNganHang.Name = "cb_ChuyenTien_ChonTenNganHang";
            this.cb_ChuyenTien_ChonTenNganHang.Size = new System.Drawing.Size(394, 30);
            this.cb_ChuyenTien_ChonTenNganHang.TabIndex = 10;
            // 
            // inp_ChuyenTien_SoTaiKhoan
            // 
            this.inp_ChuyenTien_SoTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_ChuyenTien_SoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_ChuyenTien_SoTaiKhoan.Location = new System.Drawing.Point(178, 122);
            this.inp_ChuyenTien_SoTaiKhoan.MaxLength = 5;
            this.inp_ChuyenTien_SoTaiKhoan.Multiline = true;
            this.inp_ChuyenTien_SoTaiKhoan.Name = "inp_ChuyenTien_SoTaiKhoan";
            this.inp_ChuyenTien_SoTaiKhoan.PlaceholderText = " số tài khoản cần chuyển";
            this.inp_ChuyenTien_SoTaiKhoan.Size = new System.Drawing.Size(394, 32);
            this.inp_ChuyenTien_SoTaiKhoan.TabIndex = 5;
            this.inp_ChuyenTien_SoTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_ChuyenTien_SoTaiKhoan_KeyPress);
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.btn_ChuyenTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.checkBox_ChuyenTien_InHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lb_TraCuu.Size = new System.Drawing.Size(0, 20);
            this.lb_TraCuu.TabIndex = 13;
            this.lb_TraCuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_TraCuuSoDu
            // 
            this.cb_TraCuuSoDu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TraCuuSoDu.FormattingEnabled = true;
            this.cb_TraCuuSoDu.Location = new System.Drawing.Point(85, 74);
            this.cb_TraCuuSoDu.Name = "cb_TraCuuSoDu";
            this.cb_TraCuuSoDu.Size = new System.Drawing.Size(500, 28);
            this.cb_TraCuuSoDu.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(85, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 20);
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
            this.tabSaoKe.Controls.Add(this.comboBox_SaoKe);
            this.tabSaoKe.Controls.Add(this.label10);
            this.tabSaoKe.Controls.Add(this.btnSaoKe);
            this.tabSaoKe.Controls.Add(this.listBox_SaoKe);
            this.tabSaoKe.Location = new System.Drawing.Point(4, 44);
            this.tabSaoKe.Name = "tabSaoKe";
            this.tabSaoKe.Size = new System.Drawing.Size(706, 511);
            this.tabSaoKe.TabIndex = 4;
            this.tabSaoKe.Text = "Sao kê";
            this.tabSaoKe.UseVisualStyleBackColor = true;
            // 
            // comboBox_SaoKe
            // 
            this.comboBox_SaoKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SaoKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_SaoKe.FormattingEnabled = true;
            this.comboBox_SaoKe.Location = new System.Drawing.Point(55, 63);
            this.comboBox_SaoKe.Name = "comboBox_SaoKe";
            this.comboBox_SaoKe.Size = new System.Drawing.Size(372, 30);
            this.comboBox_SaoKe.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(55, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "*Chọn tài khoản";
            // 
            // btnSaoKe
            // 
            this.btnSaoKe.BackColor = System.Drawing.Color.Brown;
            this.btnSaoKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaoKe.ForeColor = System.Drawing.Color.White;
            this.btnSaoKe.Location = new System.Drawing.Point(469, 25);
            this.btnSaoKe.Name = "btnSaoKe";
            this.btnSaoKe.Size = new System.Drawing.Size(192, 68);
            this.btnSaoKe.TabIndex = 11;
            this.btnSaoKe.Text = "Sao kê";
            this.btnSaoKe.UseVisualStyleBackColor = false;
            this.btnSaoKe.Click += new System.EventHandler(this.btnSaoKe_Click);
            // 
            // listBox_SaoKe
            // 
            this.listBox_SaoKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox_SaoKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.267326F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_SaoKe.FormattingEnabled = true;
            this.listBox_SaoKe.ItemHeight = 16;
            this.listBox_SaoKe.Location = new System.Drawing.Point(0, 123);
            this.listBox_SaoKe.Name = "listBox_SaoKe";
            this.listBox_SaoKe.Size = new System.Drawing.Size(706, 388);
            this.listBox_SaoKe.TabIndex = 12;
            // 
            // tabDoiPin
            // 
            this.tabDoiPin.Controls.Add(this.label8);
            this.tabDoiPin.Controls.Add(this.metroSetLabel6);
            this.tabDoiPin.Controls.Add(this.metroSetLabel5);
            this.tabDoiPin.Controls.Add(this.metroSetLabel4);
            this.tabDoiPin.Controls.Add(this.inp_pinCu);
            this.tabDoiPin.Controls.Add(this.inp_pinMoi);
            this.tabDoiPin.Controls.Add(this.inp_XacNhanPinMoi);
            this.tabDoiPin.Controls.Add(this.btn_DoiPin);
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(267, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "*Nhập PIN cũ và PIN mới";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // inp_pinCu
            // 
            this.inp_pinCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_pinCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_pinCu.Location = new System.Drawing.Point(194, 114);
            this.inp_pinCu.MaxLength = 3;
            this.inp_pinCu.Multiline = true;
            this.inp_pinCu.Name = "inp_pinCu";
            this.inp_pinCu.Size = new System.Drawing.Size(394, 32);
            this.inp_pinCu.TabIndex = 14;
            this.inp_pinCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_pinCu_KeyPress);
            // 
            // inp_pinMoi
            // 
            this.inp_pinMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_pinMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_pinMoi.Location = new System.Drawing.Point(194, 189);
            this.inp_pinMoi.MaxLength = 3;
            this.inp_pinMoi.Multiline = true;
            this.inp_pinMoi.Name = "inp_pinMoi";
            this.inp_pinMoi.Size = new System.Drawing.Size(394, 32);
            this.inp_pinMoi.TabIndex = 14;
            this.inp_pinMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_pinMoi_KeyPress);
            // 
            // inp_XacNhanPinMoi
            // 
            this.inp_XacNhanPinMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inp_XacNhanPinMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inp_XacNhanPinMoi.Location = new System.Drawing.Point(194, 258);
            this.inp_XacNhanPinMoi.MaxLength = 3;
            this.inp_XacNhanPinMoi.Multiline = true;
            this.inp_XacNhanPinMoi.Name = "inp_XacNhanPinMoi";
            this.inp_XacNhanPinMoi.Size = new System.Drawing.Size(394, 32);
            this.inp_XacNhanPinMoi.TabIndex = 14;
            this.inp_XacNhanPinMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_XacNhanPinMoi_KeyPress);
            // 
            // btn_DoiPin
            // 
            this.btn_DoiPin.BackColor = System.Drawing.Color.Brown;
            this.btn_DoiPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DoiPin.ForeColor = System.Drawing.Color.White;
            this.btn_DoiPin.Location = new System.Drawing.Point(194, 357);
            this.btn_DoiPin.Name = "btn_DoiPin";
            this.btn_DoiPin.Size = new System.Drawing.Size(394, 54);
            this.btn_DoiPin.TabIndex = 5;
            this.btn_DoiPin.Text = "Đổi PIN";
            this.btn_DoiPin.UseVisualStyleBackColor = false;
            this.btn_DoiPin.Click += new System.EventHandler(this.btn_DoiPin_Click);
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
            this.tab_NapTien.ResumeLayout(false);
            this.tab_NapTien.PerformLayout();
            this.tabChuyenTien.ResumeLayout(false);
            this.tabChuyenTien.PerformLayout();
            this.tabTraCuuSoDu.ResumeLayout(false);
            this.tabTraCuuSoDu.PerformLayout();
            this.tabSaoKe.ResumeLayout(false);
            this.tabSaoKe.PerformLayout();
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
        private Button btnSaoKe;
        private Label label8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private TextBox inp_pinCu;
        private TextBox inp_pinMoi;
        private TextBox inp_XacNhanPinMoi;
        private Button btn_DoiPin;
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
        private ComboBox comboBox_SaoKe;
        private Label label10;
        private TabPage tab_NapTien;
        private Button btn_NapTien;
        private CheckBox checkBox_NapTiep_InHoaDon;
        private ComboBox cb_NapTien_TaiKhoanNguon;
        private Label label11;
        private Label label12;
        private TextBox inp_NapTien_SoTienNap;
        private Button btn_MoThemTaiKhoan;
    }
}