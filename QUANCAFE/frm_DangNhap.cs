using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANCAFE
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private int soLanDangNhapSai = 0;
        private const int SoLanDangNhapToiDa = 3;
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void btn_DN_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from TAIKHOAN where TenDangNhap = '" + txt_DN.Text + "' and MatKhau = '" + txt_MK.Text + "'";
            int kq = (int)lopchung.getData(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm_Main main = new frm_Main();
                main.Show();
                this.Hide();
            }
            else
            {
                soLanDangNhapSai++;
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng nhập lại");


            }
            if (soLanDangNhapSai == SoLanDangNhapToiDa)
            {
                MessageBox.Show("Nhập sai quá 3 lần, thoát ứng dụng");
                Application.Exit();
            }


        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát không? ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
