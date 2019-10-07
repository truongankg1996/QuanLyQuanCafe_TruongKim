using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyQuanCafe_Winform.Model;
using System.Security.Cryptography;

namespace QuanLyQuanCafe_Winform
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
                Application.Exit(); 
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void BtDangNhap_Click(object sender, EventArgs e)
        {

            var taiKhoan = DataProvider.Ins.DB.TaiKhoan.Where(x => x.TenDangNhap == txbTenDangNhap.Text && x.MatKhau == txbMaKhau.Text).SingleOrDefault();
            if (taiKhoan != null)
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Hàm hỗ trợ
        //Phần mã hóa mật khẩu
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        #endregion
    }
}