
namespace WinFormsApp1 {
    partial class DangKy {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbChonNganHang = new System.Windows.Forms.ComboBox();
            this.inpMaPin = new System.Windows.Forms.TextBox();
            this.inp_hoTen = new System.Windows.Forms.TextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.inp_DiaChi = new System.Windows.Forms.TextBox();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.inp_Sdt = new System.Windows.Forms.TextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Brown;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.83168F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Thoat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Thoat.Location = new System.Drawing.Point(176, 535);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(290, 48);
            this.btn_Thoat.TabIndex = 22;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.Brown;
            this.btn_DangKy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DangKy.Location = new System.Drawing.Point(176, 465);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(290, 47);
            this.btn_DangKy.TabIndex = 23;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Arial", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(174, 379);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(60, 26);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 20;
            this.metroSetLabel3.Text = "Mã PIN";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Arial", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(173, 305);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(128, 26);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 18;
            this.metroSetLabel1.Text = "Chọn ngân hàng";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // cbChonNganHang
            // 
            this.cbChonNganHang.FormattingEnabled = true;
            this.cbChonNganHang.Location = new System.Drawing.Point(174, 340);
            this.cbChonNganHang.Name = "cbChonNganHang";
            this.cbChonNganHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbChonNganHang.Size = new System.Drawing.Size(290, 30);
            this.cbChonNganHang.TabIndex = 17;
            // 
            // inpMaPin
            // 
            this.inpMaPin.Location = new System.Drawing.Point(174, 414);
            this.inpMaPin.Margin = new System.Windows.Forms.Padding(2);
            this.inpMaPin.Name = "inpMaPin";
            this.inpMaPin.Size = new System.Drawing.Size(290, 28);
            this.inpMaPin.TabIndex = 15;
            // 
            // inp_hoTen
            // 
            this.inp_hoTen.Location = new System.Drawing.Point(175, 137);
            this.inp_hoTen.Margin = new System.Windows.Forms.Padding(2);
            this.inp_hoTen.Name = "inp_hoTen";
            this.inp_hoTen.Size = new System.Drawing.Size(290, 28);
            this.inp_hoTen.TabIndex = 15;
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Arial", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel4.IsDerivedStyle = true;
            this.metroSetLabel4.Location = new System.Drawing.Point(174, 110);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(59, 18);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 19;
            this.metroSetLabel4.Text = "Họ Tên";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // inp_DiaChi
            // 
            this.inp_DiaChi.Location = new System.Drawing.Point(175, 268);
            this.inp_DiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.inp_DiaChi.Name = "inp_DiaChi";
            this.inp_DiaChi.Size = new System.Drawing.Size(290, 28);
            this.inp_DiaChi.TabIndex = 15;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Arial", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel5.IsDerivedStyle = true;
            this.metroSetLabel5.Location = new System.Drawing.Point(174, 238);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(59, 21);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 19;
            this.metroSetLabel5.Text = "Địa chỉ";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // inp_Sdt
            // 
            this.inp_Sdt.Location = new System.Drawing.Point(175, 201);
            this.inp_Sdt.Margin = new System.Windows.Forms.Padding(2);
            this.inp_Sdt.Name = "inp_Sdt";
            this.inp_Sdt.Size = new System.Drawing.Size(290, 28);
            this.inp_Sdt.TabIndex = 15;
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Arial", 9.980198F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel6.IsDerivedStyle = true;
            this.metroSetLabel6.Location = new System.Drawing.Point(171, 174);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(111, 18);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 19;
            this.metroSetLabel6.Text = "Số điện thoại";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 633);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel4);
            this.Controls.Add(this.cbChonNganHang);
            this.Controls.Add(this.inp_Sdt);
            this.Controls.Add(this.inp_DiaChi);
            this.Controls.Add(this.inp_hoTen);
            this.Controls.Add(this.inpMaPin);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetLabel1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.ComboBox cbChonNganHang;
        private System.Windows.Forms.TextBox inpMaPin;
        private System.Windows.Forms.TextBox inp_hoTen;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.TextBox inp_DiaChi;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private System.Windows.Forms.TextBox inp_Sdt;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
    }
}