using DTO_QLBanHang;
using GUI_QLBanHang.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    
    public partial class frmMain : Form
    {
        public static NhanVien nhanVien;
        public frmMain()
        {
            InitializeComponent();
        }

        #region 
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

     

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            resetMenu();
        }
        private void resetMenu()
        {
            if (nhanVien == null)
            {
                //Hethong
                mniDangxuat.Enabled = false;
                mniDangnhap.Enabled = true;
                mniHosoNV.Enabled = false;
                mniThoat.Enabled = true;
                //Danhmuc
                mniDanhmuc.Visible = false;
                mniSanpham.Enabled = false;
                mniNhanvien.Enabled = false;
                mniKhachhang.Enabled = false;
                //Thongke
                mniThongke.Visible = false;
                mniThongkeSP.Enabled = false;
                //Chao
                mniChao.Visible = false;
                mniThongtin.Enabled = false;
                mniDangxuat2.Enabled = false;
            }
            else
            {
                //Hethong
                mniDangxuat.Enabled = true;
                mniDangnhap.Enabled = false;
                mniHosoNV.Enabled = true;
                //Danhmuc
                mniDanhmuc.Visible = true;
                mniSanpham.Enabled = true;
                mniNhanvien.Enabled = nhanVien.VaiTro == 1 ? true : false;
                mniKhachhang.Enabled = true;
                //Thongke
                mniThongke.Visible = true;
                mniThongkeSP.Enabled = nhanVien.VaiTro == 1 ? true : false;
                //Chao
                mniChao.Visible = true;
                mniThongtin.Enabled = true;
                mniDangxuat2.Enabled = true;
                mniChao.Text = "Chào" + nhanVien.Email;
            }
        }
        private void OpenOrActiveFrom(Form frm)
        {
            Form frm1 = this.MdiChildren.FirstOrDefault(f => f.Name == frm.Name);
            if (frm1 != null)
            {
                frm1.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
        
        //Hệ thống
        private void DangNhap()
        {
            frmDangnhap frm = new frmDangnhap();
            frm.ShowDialog();
            resetMenu();
        }
        private void DangXuat()
        {
            nhanVien = null;
            foreach (var f in this.MdiChildren)
            {
                f.Close();
            }
        }
        private void mniDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mniDangxuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void mniThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mniHosoNV_Click(object sender, EventArgs e)
        {
            frmHosonhanvien frm = new frmHosonhanvien();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                resetMenu();
                DiaLogHelper.Alert("Cập nhật mật khẩu thành công. Bạn cần đăng nhập lại");
                DangNhap();
            }
        }

        //Danh mục
        private void mniSanpham_Click(object sender, EventArgs e)
        {
            frmHang frm = new frmHang();
            OpenOrActiveFrom(frm);
        }

        private void mniNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            OpenOrActiveFrom(frm);
        }

        private void mniKhachhang_Click(object sender, EventArgs e)
        {
            frmKhachhang frm = new frmKhachhang();
            OpenOrActiveFrom(frm);
        }



        //Thống kê
        private void mniThongkeSP_Click(object sender, EventArgs e)
        {
            var frm = new frmThongKe();
            OpenOrActiveFrom(frm);
        }

        //Hướng dẫn
        private void mniHuongdansd_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Application.StartupPath + @"\Docs\help.pdf";
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                DiaLogHelper.Error("Lỗi: " + ex.Message);
            }
        }

        private void mniGioithieuPM_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Application.StartupPath + @"\Docs\help.pdf";
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                DiaLogHelper.Error("Lỗi: " + ex.Message);
            }
        }



        //Chào 
        private void mniThongtin_Click(object sender, EventArgs e)
        {

        }

        private void mniDangxuat2_Click(object sender, EventArgs e)
        {
            DangXuat();
        }
    }
}
