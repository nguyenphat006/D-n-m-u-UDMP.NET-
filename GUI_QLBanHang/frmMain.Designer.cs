namespace GUI_QLBanHang
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHosoNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSanpham = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongkeSP = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHuongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHuongdansd = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGioithieuPM = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChao = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangxuat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.mniDanhmuc,
            this.mniThongke,
            this.mniHuongdan,
            this.mniChao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1768, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDangnhap,
            this.mniDangxuat,
            this.mniHosoNV,
            this.mniThoat});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hệThốngToolStripMenuItem.Image = global::GUI_QLBanHang.Properties.Resources.system;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(179, 42);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mniDangnhap
            // 
            this.mniDangnhap.Enabled = false;
            this.mniDangnhap.Image = global::GUI_QLBanHang.Properties.Resources.user__1_;
            this.mniDangnhap.Name = "mniDangnhap";
            this.mniDangnhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mniDangnhap.Size = new System.Drawing.Size(440, 46);
            this.mniDangnhap.Text = "Đăng nhập";
            this.mniDangnhap.Click += new System.EventHandler(this.mniDangnhap_Click);
            // 
            // mniDangxuat
            // 
            this.mniDangxuat.Image = global::GUI_QLBanHang.Properties.Resources.logout;
            this.mniDangxuat.Name = "mniDangxuat";
            this.mniDangxuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mniDangxuat.Size = new System.Drawing.Size(440, 46);
            this.mniDangxuat.Text = "Đăng xuất";
            this.mniDangxuat.Click += new System.EventHandler(this.mniDangxuat_Click);
            // 
            // mniHosoNV
            // 
            this.mniHosoNV.Image = global::GUI_QLBanHang.Properties.Resources.speaker;
            this.mniHosoNV.Name = "mniHosoNV";
            this.mniHosoNV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mniHosoNV.Size = new System.Drawing.Size(440, 46);
            this.mniHosoNV.Text = "Hồ sơ nhân viên";
            this.mniHosoNV.Click += new System.EventHandler(this.mniHosoNV_Click);
            // 
            // mniThoat
            // 
            this.mniThoat.Name = "mniThoat";
            this.mniThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mniThoat.Size = new System.Drawing.Size(440, 46);
            this.mniThoat.Text = "Thoát";
            this.mniThoat.Click += new System.EventHandler(this.mniThoat_Click);
            // 
            // mniDanhmuc
            // 
            this.mniDanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSanpham,
            this.mniNhanvien,
            this.mniKhachhang});
            this.mniDanhmuc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mniDanhmuc.Image = global::GUI_QLBanHang.Properties.Resources.menu;
            this.mniDanhmuc.Name = "mniDanhmuc";
            this.mniDanhmuc.Size = new System.Drawing.Size(190, 42);
            this.mniDanhmuc.Text = "Danh mục";
            // 
            // mniSanpham
            // 
            this.mniSanpham.Image = global::GUI_QLBanHang.Properties.Resources.brand_identity;
            this.mniSanpham.Name = "mniSanpham";
            this.mniSanpham.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mniSanpham.Size = new System.Drawing.Size(379, 46);
            this.mniSanpham.Text = "Sản phẩm";
            this.mniSanpham.Click += new System.EventHandler(this.mniSanpham_Click);
            // 
            // mniNhanvien
            // 
            this.mniNhanvien.Image = global::GUI_QLBanHang.Properties.Resources.profile;
            this.mniNhanvien.Name = "mniNhanvien";
            this.mniNhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.mniNhanvien.Size = new System.Drawing.Size(379, 46);
            this.mniNhanvien.Text = "Nhân viên";
            this.mniNhanvien.Click += new System.EventHandler(this.mniNhanvien_Click);
            // 
            // mniKhachhang
            // 
            this.mniKhachhang.Image = global::GUI_QLBanHang.Properties.Resources.user__1_;
            this.mniKhachhang.Name = "mniKhachhang";
            this.mniKhachhang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.mniKhachhang.Size = new System.Drawing.Size(379, 46);
            this.mniKhachhang.Text = "Khách hàng";
            this.mniKhachhang.Click += new System.EventHandler(this.mniKhachhang_Click);
            // 
            // mniThongke
            // 
            this.mniThongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniThongkeSP});
            this.mniThongke.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mniThongke.Image = global::GUI_QLBanHang.Properties.Resources.bar_chart;
            this.mniThongke.Name = "mniThongke";
            this.mniThongke.Size = new System.Drawing.Size(179, 42);
            this.mniThongke.Text = "Thống kê";
            // 
            // mniThongkeSP
            // 
            this.mniThongkeSP.Image = global::GUI_QLBanHang.Properties.Resources.brand_identity;
            this.mniThongkeSP.Name = "mniThongkeSP";
            this.mniThongkeSP.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.mniThongkeSP.Size = new System.Drawing.Size(477, 46);
            this.mniThongkeSP.Text = "Thống kê sản phẩm ";
            this.mniThongkeSP.Click += new System.EventHandler(this.mniThongkeSP_Click);
            // 
            // mniHuongdan
            // 
            this.mniHuongdan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHuongdansd,
            this.mniGioithieuPM});
            this.mniHuongdan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mniHuongdan.Image = global::GUI_QLBanHang.Properties.Resources.user_guide;
            this.mniHuongdan.Name = "mniHuongdan";
            this.mniHuongdan.Size = new System.Drawing.Size(202, 42);
            this.mniHuongdan.Text = "Hướng dẫn";
            // 
            // mniHuongdansd
            // 
            this.mniHuongdansd.Image = global::GUI_QLBanHang.Properties.Resources.info;
            this.mniHuongdansd.Name = "mniHuongdansd";
            this.mniHuongdansd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.mniHuongdansd.Size = new System.Drawing.Size(490, 46);
            this.mniHuongdansd.Text = "Hướng dẫn sử dụng";
            this.mniHuongdansd.Click += new System.EventHandler(this.mniHuongdansd_Click);
            // 
            // mniGioithieuPM
            // 
            this.mniGioithieuPM.Image = global::GUI_QLBanHang.Properties.Resources.speaker;
            this.mniGioithieuPM.Name = "mniGioithieuPM";
            this.mniGioithieuPM.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.mniGioithieuPM.Size = new System.Drawing.Size(490, 46);
            this.mniGioithieuPM.Text = "Giới thiệu phần mềm";
            this.mniGioithieuPM.Click += new System.EventHandler(this.mniGioithieuPM_Click);
            // 
            // mniChao
            // 
            this.mniChao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mniChao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniThongtin,
            this.mniDangxuat2});
            this.mniChao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mniChao.Image = global::GUI_QLBanHang.Properties.Resources.account;
            this.mniChao.Name = "mniChao";
            this.mniChao.Size = new System.Drawing.Size(325, 42);
            this.mniChao.Text = "Chào abc@gmailcom";
            this.mniChao.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // mniThongtin
            // 
            this.mniThongtin.Image = global::GUI_QLBanHang.Properties.Resources.profile;
            this.mniThongtin.Name = "mniThongtin";
            this.mniThongtin.Size = new System.Drawing.Size(361, 46);
            this.mniThongtin.Text = "Thông tin";
            this.mniThongtin.Click += new System.EventHandler(this.mniThongtin_Click);
            // 
            // mniDangxuat2
            // 
            this.mniDangxuat2.Image = global::GUI_QLBanHang.Properties.Resources.logout;
            this.mniDangxuat2.Name = "mniDangxuat2";
            this.mniDangxuat2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mniDangxuat2.Size = new System.Drawing.Size(361, 46);
            this.mniDangxuat2.Text = "Đăng xuất";
            this.mniDangxuat2.Click += new System.EventHandler(this.mniDangxuat2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 1002);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "FrmMain - Quản lý bán hàng";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mniDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mniHosoNV;
        private System.Windows.Forms.ToolStripMenuItem mniThoat;
        private System.Windows.Forms.ToolStripMenuItem mniDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mniSanpham;
        private System.Windows.Forms.ToolStripMenuItem mniNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mniKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mniThongke;
        private System.Windows.Forms.ToolStripMenuItem mniThongkeSP;
        private System.Windows.Forms.ToolStripMenuItem mniHuongdan;
        private System.Windows.Forms.ToolStripMenuItem mniHuongdansd;
        private System.Windows.Forms.ToolStripMenuItem mniGioithieuPM;
        private System.Windows.Forms.ToolStripMenuItem mniChao;
        private System.Windows.Forms.ToolStripMenuItem mniThongtin;
        private System.Windows.Forms.ToolStripMenuItem mniDangxuat2;
    }
}

