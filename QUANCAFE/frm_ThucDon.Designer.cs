namespace QUANCAFE
{
    partial class frm_ThucDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_namhethan = new System.Windows.Forms.TextBox();
            this.txt_dem = new System.Windows.Forms.TextBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dem = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_LoadDS = new System.Windows.Forms.Button();
            this.datagv = new System.Windows.Forms.DataGridView();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.cb_loaikhach = new System.Windows.Forms.ComboBox();
            this.MaThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapTheThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã TĐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên TĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Cấp Thẻ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại Khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Năm Hết Hạn Thẻ";
            // 
            // txt_ma
            // 
            this.txt_ma.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma.Location = new System.Drawing.Point(186, 37);
            this.txt_ma.Multiline = true;
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(200, 32);
            this.txt_ma.TabIndex = 5;
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(186, 101);
            this.txt_ten.Multiline = true;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(200, 32);
            this.txt_ten.TabIndex = 6;
            // 
            // txt_namhethan
            // 
            this.txt_namhethan.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namhethan.Location = new System.Drawing.Point(612, 160);
            this.txt_namhethan.Multiline = true;
            this.txt_namhethan.Name = "txt_namhethan";
            this.txt_namhethan.Size = new System.Drawing.Size(200, 32);
            this.txt_namhethan.TabIndex = 7;
            // 
            // txt_dem
            // 
            this.txt_dem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dem.Location = new System.Drawing.Point(612, 91);
            this.txt_dem.Multiline = true;
            this.txt_dem.Name = "txt_dem";
            this.txt_dem.Size = new System.Drawing.Size(110, 32);
            this.txt_dem.TabIndex = 8;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(844, 91);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(200, 32);
            this.txt_timkiem.TabIndex = 9;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_them.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(82, 234);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(92, 41);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sua.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(228, 234);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(92, 41);
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(372, 234);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(92, 41);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dem
            // 
            this.btn_dem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_dem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dem.Location = new System.Drawing.Point(424, 91);
            this.btn_dem.Name = "btn_dem";
            this.btn_dem.Size = new System.Drawing.Size(92, 41);
            this.btn_dem.TabIndex = 13;
            this.btn_dem.Text = "Đếm";
            this.btn_dem.UseVisualStyleBackColor = false;
            this.btn_dem.Click += new System.EventHandler(this.btn_dem_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_timkiem.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(844, 37);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(200, 41);
            this.btn_timkiem.TabIndex = 14;
            this.btn_timkiem.Text = "Tìm Theo Ký Tự Bất Kỳ Của Tên";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_LoadDS
            // 
            this.btn_LoadDS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_LoadDS.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadDS.Location = new System.Drawing.Point(844, 151);
            this.btn_LoadDS.Name = "btn_LoadDS";
            this.btn_LoadDS.Size = new System.Drawing.Size(200, 41);
            this.btn_LoadDS.TabIndex = 15;
            this.btn_LoadDS.Text = "Load Lại Danh Sách";
            this.btn_LoadDS.UseVisualStyleBackColor = false;
            this.btn_LoadDS.Click += new System.EventHandler(this.btn_LoadDS_Click);
            // 
            // datagv
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucDon,
            this.TenThucDon,
            this.NgayCapTheThanhVien,
            this.MaLoaiKhach,
            this.NamHetHan});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagv.DefaultCellStyle = dataGridViewCellStyle5;
            this.datagv.Location = new System.Drawing.Point(82, 303);
            this.datagv.Name = "datagv";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagv.RowTemplate.Height = 24;
            this.datagv.Size = new System.Drawing.Size(962, 150);
            this.datagv.TabIndex = 16;
            this.datagv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagv_CellContentClick);
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngay.Location = new System.Drawing.Point(187, 164);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(199, 29);
            this.dtp_ngay.TabIndex = 17;
            this.dtp_ngay.UseWaitCursor = true;
            this.dtp_ngay.ValueChanged += new System.EventHandler(this.dtp_ngay_ValueChanged);
            // 
            // cb_loaikhach
            // 
            this.cb_loaikhach.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_loaikhach.FormattingEnabled = true;
            this.cb_loaikhach.Location = new System.Drawing.Point(611, 35);
            this.cb_loaikhach.Name = "cb_loaikhach";
            this.cb_loaikhach.Size = new System.Drawing.Size(200, 29);
            this.cb_loaikhach.TabIndex = 18;
            // 
            // MaThucDon
            // 
            this.MaThucDon.DataPropertyName = "MaThucDon";
            this.MaThucDon.HeaderText = "Mã TĐ";
            this.MaThucDon.Name = "MaThucDon";
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên TĐ";
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.Width = 180;
            // 
            // NgayCapTheThanhVien
            // 
            this.NgayCapTheThanhVien.DataPropertyName = "NgayCapTheThanhVien";
            this.NgayCapTheThanhVien.HeaderText = "Ngày Cấp Thẻ TV";
            this.NgayCapTheThanhVien.Name = "NgayCapTheThanhVien";
            this.NgayCapTheThanhVien.Width = 180;
            // 
            // MaLoaiKhach
            // 
            this.MaLoaiKhach.DataPropertyName = "MaLoaiKhach";
            this.MaLoaiKhach.HeaderText = "Loại Khách";
            this.MaLoaiKhach.Name = "MaLoaiKhach";
            this.MaLoaiKhach.Width = 180;
            // 
            // NamHetHan
            // 
            this.NamHetHan.DataPropertyName = "NamHetHan";
            this.NamHetHan.HeaderText = "Năm Hết Hạn";
            this.NamHetHan.Name = "NamHetHan";
            this.NamHetHan.Width = 180;
            // 
            // frm_ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 506);
            this.Controls.Add(this.cb_loaikhach);
            this.Controls.Add(this.dtp_ngay);
            this.Controls.Add(this.datagv);
            this.Controls.Add(this.btn_LoadDS);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_dem);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_dem);
            this.Controls.Add(this.txt_namhethan);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThucDon";
            this.Text = "frm_ThucDon";
            this.Load += new System.EventHandler(this.frm_ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_namhethan;
        private System.Windows.Forms.TextBox txt_dem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_LoadDS;
        private System.Windows.Forms.DataGridView datagv;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
        private System.Windows.Forms.ComboBox cb_loaikhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapTheThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHetHan;
    }
}