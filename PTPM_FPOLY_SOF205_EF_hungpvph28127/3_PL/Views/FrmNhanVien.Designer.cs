using System;

namespace _3_PL.Views
{
    partial class FrmNhanVien
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_view = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_diachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_hd = new System.Windows.Forms.CheckBox();
            this.cb_khd = new System.Windows.Forms.CheckBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbb_cuahang = new System.Windows.Forms.ComboBox();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.cbb_guibc = new System.Windows.Forms.ComboBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_ho = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbx_ten = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_sdt = new System.Windows.Forms.TextBox();
            this.tbx_tendem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(892, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mã";
            // 
            // tbx_ma
            // 
            this.tbx_ma.Location = new System.Drawing.Point(892, 28);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(295, 31);
            this.tbx_ma.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(892, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Chức Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(892, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Người gửi BC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(892, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cửa Hàng";
            // 
            // dtg_view
            // 
            this.dtg_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view.Location = new System.Drawing.Point(12, 124);
            this.dtg_view.Name = "dtg_view";
            this.dtg_view.RowHeadersWidth = 62;
            this.dtg_view.RowTemplate.Height = 33;
            this.dtg_view.Size = new System.Drawing.Size(860, 354);
            this.dtg_view.TabIndex = 32;
            this.dtg_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_CellClick);
            this.dtg_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_CellContentClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::_3_PL.Properties.Resources.delete__1_;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(303, 47);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 56);
            this.btn_xoa.TabIndex = 31;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(176, 47);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 56);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(45, 47);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 56);
            this.btn_them.TabIndex = 29;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(893, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(893, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Ngày Sinh";
            // 
            // tbx_diachi
            // 
            this.tbx_diachi.Location = new System.Drawing.Point(893, 455);
            this.tbx_diachi.Name = "tbx_diachi";
            this.tbx_diachi.Size = new System.Drawing.Size(295, 31);
            this.tbx_diachi.TabIndex = 45;
            this.tbx_diachi.TextChanged += new System.EventHandler(this.tbx_diachi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(893, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Địa chỉ";
            // 
            // cb_hd
            // 
            this.cb_hd.AutoSize = true;
            this.cb_hd.Location = new System.Drawing.Point(768, 89);
            this.cb_hd.Name = "cb_hd";
            this.cb_hd.Size = new System.Drawing.Size(125, 29);
            this.cb_hd.TabIndex = 51;
            this.cb_hd.Text = "Hoạt động";
            this.cb_hd.UseVisualStyleBackColor = true;
            // 
            // cb_khd
            // 
            this.cb_khd.AutoSize = true;
            this.cb_khd.Location = new System.Drawing.Point(578, 89);
            this.cb_khd.Name = "cb_khd";
            this.cb_khd.Size = new System.Drawing.Size(184, 29);
            this.cb_khd.TabIndex = 52;
            this.cb_khd.Text = "Không Hoạt Động";
            this.cb_khd.UseVisualStyleBackColor = true;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(893, 393);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(295, 31);
            this.dtp_ngaysinh.TabIndex = 53;
            this.dtp_ngaysinh.ValueChanged += new System.EventHandler(this.dtp_ngaysinh_ValueChanged);
            // 
            // cbb_cuahang
            // 
            this.cbb_cuahang.FormattingEnabled = true;
            this.cbb_cuahang.Location = new System.Drawing.Point(891, 152);
            this.cbb_cuahang.Name = "cbb_cuahang";
            this.cbb_cuahang.Size = new System.Drawing.Size(279, 33);
            this.cbb_cuahang.TabIndex = 54;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Location = new System.Drawing.Point(893, 331);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(279, 33);
            this.cbb_gioitinh.TabIndex = 55;
            // 
            // cbb_guibc
            // 
            this.cbb_guibc.FormattingEnabled = true;
            this.cbb_guibc.Location = new System.Drawing.Point(893, 269);
            this.cbb_guibc.Name = "cbb_guibc";
            this.cbb_guibc.Size = new System.Drawing.Size(279, 33);
            this.cbb_guibc.TabIndex = 56;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(891, 214);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(279, 33);
            this.cbb_chucvu.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(578, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Trạng Thái";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 25);
            this.label12.TabIndex = 62;
            this.label12.Text = "Họ";
            // 
            // tbx_ho
            // 
            this.tbx_ho.Location = new System.Drawing.Point(303, 509);
            this.tbx_ho.Name = "tbx_ho";
            this.tbx_ho.Size = new System.Drawing.Size(295, 31);
            this.tbx_ho.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-335, 846);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 25);
            this.label13.TabIndex = 64;
            this.label13.Text = "Tên";
            // 
            // tbx_ten
            // 
            this.tbx_ten.Location = new System.Drawing.Point(2, 509);
            this.tbx_ten.Name = "tbx_ten";
            this.tbx_ten.Size = new System.Drawing.Size(295, 31);
            this.tbx_ten.TabIndex = 63;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(890, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 25);
            this.label11.TabIndex = 50;
            this.label11.Text = "Sđt";
            // 
            // tbx_sdt
            // 
            this.tbx_sdt.Location = new System.Drawing.Point(893, 90);
            this.tbx_sdt.Name = "tbx_sdt";
            this.tbx_sdt.Size = new System.Drawing.Size(295, 31);
            this.tbx_sdt.TabIndex = 49;
            // 
            // tbx_tendem
            // 
            this.tbx_tendem.Location = new System.Drawing.Point(604, 509);
            this.tbx_tendem.Name = "tbx_tendem";
            this.tbx_tendem.Size = new System.Drawing.Size(295, 31);
            this.tbx_tendem.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 481);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tên đệm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Tên";
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(903, 509);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.Size = new System.Drawing.Size(295, 31);
            this.tbx_mk.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(904, 481);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Mật khẩu";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbx_ten);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbx_ho);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbb_chucvu);
            this.Controls.Add(this.cbb_guibc);
            this.Controls.Add(this.cbb_gioitinh);
            this.Controls.Add(this.cbb_cuahang);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.cb_khd);
            this.Controls.Add(this.cb_hd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbx_sdt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_diachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbx_mk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_tendem);
            this.Controls.Add(this.dtg_view);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_view;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_diachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_hd;
        private System.Windows.Forms.CheckBox cb_khd;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cbb_cuahang;
        private System.Windows.Forms.ComboBox cbb_gioitinh;
        private System.Windows.Forms.ComboBox cbb_guibc;
        private System.Windows.Forms.ComboBox cbb_chucvu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_ho;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbx_ten;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_sdt;
        private System.Windows.Forms.TextBox tbx_tendem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.Label label14;
        private EventHandler btn_xoa_Click;
        private EventHandler btn_sua_Click;
    }
}