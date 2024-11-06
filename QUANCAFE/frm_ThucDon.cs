using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QUANCAFE
{
    public partial class frm_ThucDon : Form
    {
        public frm_ThucDon()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CS464I\QUANCAFE\QUANCAFE\Cafe.mdf;Integrated Security=True";

            string sql = "SELECT * FROM THUCDON WHERE TenThucDon like @TenThucDon";

            SqlCommand comm = new SqlCommand(sql, conn);

            comm.Parameters.AddWithValue("TenThucDon", "%" + txt_timkiem.Text.Trim() + "%");

            try
            {
                conn.Open();
                DataTable dt = lopchung.LoadData(comm);

                conn.Close();
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tìm thấy tên theo yêu cầu!", "Thông báo");
                    datagv.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên nào!", "Thông báo");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");

            }
        }
         public void loadPage()
        {
            string sql = "SELECT * FROM THUCDON";
            datagv.DataSource = lopchung.LoadData(sql);
            
        }
        

        private void frm_ThucDon_Load(object sender, EventArgs e)
        {
            loadPage();
            string sql = "SELECT * FROM LOAIKHACH";
            cb_loaikhach.DataSource = lopchung.LoadData(sql);
            cb_loaikhach.DisplayMember = "LoaiKhach";
            cb_loaikhach.ValueMember = "MaLoaiKhach";
        }
        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            int namcapthe = dtp_ngay.Value.Year;
            int namhethan = namcapthe + 1;
            txt_namhethan.Text = namhethan.ToString();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO THUCDON VALUES('" + txt_ma.Text + "', N'" + txt_ten.Text + "', CONVERT(datetime, '" + dtp_ngay.Text + "', 103), N'" + cb_loaikhach.SelectedValue + "','" + txt_namhethan.Text + "')";
            int kq = lopchung.ThemSuaXoa(sql);
            if(kq >= 0)
            {
                MessageBox.Show("Bạn đã thêm thực đơn thành công!", "Thông báo");
                loadPage();
            }else MessageBox.Show("Bạn đã thêm thực đơn thất bại!", "Thông báo");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE THUCDON SET TenThucDon = N'" + txt_ten.Text + "', NgayCapTheThanhVien = CONVERT(datetime, '" + dtp_ngay.Text + "', 103), MaLoaiKhach = N'" + cb_loaikhach.SelectedValue + "', NamHetHan = '" + txt_namhethan.Text + "' WHERE MaThucDon = '" + txt_ma.Text + "'";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq >= 0)
            {
                MessageBox.Show("Bạn đã cập nhật thực đơn thành công!", "Thông báo");
                loadPage();
            }
            else MessageBox.Show("Bạn đã cập nhật thực đơn thất bại!", "Thông báo");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM THUCDON WHERE MaThucDon = '" + txt_ma.Text + "'";
            int kq = lopchung.ThemSuaXoa(sql);
            if (kq >= 0)
            {
                MessageBox.Show("Bạn đã xóa thực đơn thành công!", "Thông báo");
                loadPage();
            }
            else MessageBox.Show("Bạn đã xóa thực đơn thất bại!", "Thông báo");
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM THUCDON";
            int kq = (int)lopchung.getData(sql);
            txt_dem.Text = kq.ToString();
        }

        

        private void datagv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = datagv.Rows[e.RowIndex];
                txt_ma.Text = row.Cells["MaThucDon"].Value.ToString();
                txt_ten.Text = row.Cells["TenThucDon"].Value.ToString();
                dtp_ngay.Text = row.Cells["NgayCapTheThanhVien"].Value.ToString();
                cb_loaikhach.Text = row.Cells["MaLoaiKhach"].Value.ToString();
                txt_namhethan.Text = row.Cells["NamHetHan"].Value.ToString();

            }
        }

        private void btn_LoadDS_Click(object sender, EventArgs e)
        {
            loadPage();
        }

       
    }
}
