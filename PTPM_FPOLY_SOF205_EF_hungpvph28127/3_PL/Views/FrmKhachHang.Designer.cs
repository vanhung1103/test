namespace _3_PL.Views
{
    partial class FrmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhachHang));
            this.tbx_tp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_quocgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_dc = new System.Windows.Forms.TextBox();
            this.tbx_ten = new System.Windows.Forms.TextBox();
            this.dtg_view = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbx_tendem = new System.Windows.Forms.TextBox();
            this.tbx_ho = new System.Windows.Forms.TextBox();
            this.tbx_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_tp
            // 
            this.tbx_tp.Location = new System.Drawing.Point(965, 311);
            this.tbx_tp.Name = "tbx_tp";
            this.tbx_tp.Size = new System.Drawing.Size(232, 31);
            this.tbx_tp.TabIndex = 42;
            this.tbx_tp.TextChanged += new System.EventHandler(this.tbx_tp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(965, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mã";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbx_ma
            // 
            this.tbx_ma.Location = new System.Drawing.Point(965, 37);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(232, 31);
            this.tbx_ma.TabIndex = 40;
            this.tbx_ma.TextChanged += new System.EventHandler(this.tbx_ma_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(965, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Thành Phố";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(977, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Quốc gia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbx_quocgia
            // 
            this.tbx_quocgia.Location = new System.Drawing.Point(965, 393);
            this.tbx_quocgia.Name = "tbx_quocgia";
            this.tbx_quocgia.Size = new System.Drawing.Size(232, 31);
            this.tbx_quocgia.TabIndex = 37;
            this.tbx_quocgia.TextChanged += new System.EventHandler(this.tbx_quocgia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Địa chỉ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbx_dc
            // 
            this.tbx_dc.Location = new System.Drawing.Point(965, 222);
            this.tbx_dc.Name = "tbx_dc";
            this.tbx_dc.Size = new System.Drawing.Size(232, 31);
            this.tbx_dc.TabIndex = 34;
            this.tbx_dc.TextChanged += new System.EventHandler(this.tbx_dc_TextChanged);
            // 
            // tbx_ten
            // 
            this.tbx_ten.Location = new System.Drawing.Point(965, 123);
            this.tbx_ten.Name = "tbx_ten";
            this.tbx_ten.Size = new System.Drawing.Size(232, 31);
            this.tbx_ten.TabIndex = 33;
            this.tbx_ten.TextChanged += new System.EventHandler(this.tbx_ten_TextChanged);
            // 
            // dtg_view
            // 
            this.dtg_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view.Location = new System.Drawing.Point(0, 123);
            this.dtg_view.Name = "dtg_view";
            this.dtg_view.RowHeadersWidth = 62;
            this.dtg_view.RowTemplate.Height = 33;
            this.dtg_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_view.Size = new System.Drawing.Size(646, 397);
            this.dtg_view.TabIndex = 32;
            this.dtg_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::_3_PL.Properties.Resources.delete__1_;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(284, 24);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 56);
            this.btn_xoa.TabIndex = 31;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(151, 24);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 56);
            this.btn_sua.TabIndex = 30;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(12, 24);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 56);
            this.btn_them.TabIndex = 29;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(791, 489);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(300, 31);
            this.dtp_ngaysinh.TabIndex = 43;
            // 
            // tbx_tendem
            // 
            this.tbx_tendem.Location = new System.Drawing.Point(709, 123);
            this.tbx_tendem.Name = "tbx_tendem";
            this.tbx_tendem.Size = new System.Drawing.Size(232, 31);
            this.tbx_tendem.TabIndex = 44;
            // 
            // tbx_ho
            // 
            this.tbx_ho.Location = new System.Drawing.Point(709, 222);
            this.tbx_ho.Name = "tbx_ho";
            this.tbx_ho.Size = new System.Drawing.Size(232, 31);
            this.tbx_ho.TabIndex = 45;
            // 
            // tbx_sdt
            // 
            this.tbx_sdt.Location = new System.Drawing.Point(709, 311);
            this.tbx_sdt.Name = "tbx_sdt";
            this.tbx_sdt.Size = new System.Drawing.Size(232, 31);
            this.tbx_sdt.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Họ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(709, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tên đệm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(709, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "Mật Khẩu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(709, 393);
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.Size = new System.Drawing.Size(232, 31);
            this.tbx_mk.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(791, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 52;
            this.label10.Text = "Ngày Sinh";
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 600);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_mk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_sdt);
            this.Controls.Add(this.tbx_ho);
            this.Controls.Add(this.tbx_tendem);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.tbx_tp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_ma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_quocgia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_dc);
            this.Controls.Add(this.tbx_ten);
            this.Controls.Add(this.dtg_view);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhachHang";
            this.Text = "FrmKhachHang";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_tp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_ma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_quocgia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_dc;
        private System.Windows.Forms.TextBox tbx_ten;
        private System.Windows.Forms.DataGridView dtg_view;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.TextBox tbx_tendem;
        private System.Windows.Forms.TextBox tbx_ho;
        private System.Windows.Forms.TextBox tbx_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.Label label10;
    }
}