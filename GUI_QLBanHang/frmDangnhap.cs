using BUS_QLBanHang;
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
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length == 0 || txtMatKhau.Text.Trim().Length == 0)
            {
                DiaLogHelper.Alert("Bạn cần nhập đầy đủ thông tin đăng nhập");
                return;
            }
            string matKhau = StringHelper.MD5Hash(txtMatKhau.Text);
            frmMain.nhanVien = BUS_NhanVien.DangNhap(txtEmail.Text, matKhau);   
            if (frmMain.nhanVien != null)
            {
                DiaLogHelper.Alert("Đăng nhập thành công");
                this.Close();
            }
            else
            {
                DiaLogHelper.Alert("Sai thông tin đăng nhập");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                DiaLogHelper.Alert("Bạn cần nhập email nhận thông tin phục hồi mật khẩu");
                txtEmail.Focus();
                return;
            }
            if(!EmailHelper.IsValidEmail(txtEmail.Text))
            {
                DiaLogHelper.Alert("Địa chỉ email không hợp lệ");
                txtEmail.Focus();
                return;
            }
            string email = txtEmail.Text.Trim();
            if(BUS_NhanVien.DaTonTaiEmail(email) == false)
            {
                DiaLogHelper.Alert("Địa chỉ email không tồn tại");
                txtEmail.Focus();
                return;
            }
            string matkhauMoi = StringHelper.GetRandomString(8);
            string subject = "Bạn đã sử dụng tính năng quên mật khẩu";
            string msg = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là: " + matkhauMoi;
            string result = EmailHelper.SendMail(txtEmail.Text.Trim(), subject, msg);
            if (result == "")
            {
                DiaLogHelper.Alert("Một email phục hồi mật khẩu đã được gửi đến bạn");
                if (BUS_NhanVien.CreatePassword(txtEmail.Text.Trim(), StringHelper.MD5Hash(matkhauMoi)) > 0)
                {
                    DiaLogHelper.Alert("Mật khẩu mới của bạn đã được tạo");
                }
            }
            else
            {
                DiaLogHelper.Alert("Lỗi gửi mail: " + result);
            }
        }
    }
}
