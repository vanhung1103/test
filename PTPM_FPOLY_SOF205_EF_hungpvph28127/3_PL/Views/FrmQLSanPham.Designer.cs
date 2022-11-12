namespace _3_PL.Views
{
    partial class FrmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLSanPham));
            this.dtg_view = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.tbx_mota = new System.Windows.Forms.TextBox();
            this.tbx_nambaohanh = new System.Windows.Forms.TextBox();
            this.cb_mausac = new System.Windows.Forms.ComboBox();
            this.cb_nsx = new System.Windows.Forms.ComboBox();
            this.cb_dongsp = new System.Windows.Forms.ComboBox();
            this.cb_tensp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_view
            // 
            this.dtg_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_view.Location = new System.Drawing.Point(12, 213);
            this.dtg_view.Name = "dtg_view";
            this.dtg_view.RowHeadersWidth = 62;
            this.dtg_view.RowTemplate.Height = 33;
            this.dtg_view.Size = new System.Drawing.Size(1186, 375);
            this.dtg_view.TabIndex = 0;
            this.dtg_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_CellClick);
            this.dtg_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_view_CellContentClick);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(985, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(112, 56);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(985, 77);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 56);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::_3_PL.Properties.Resources.delete__1_;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(985, 151);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 56);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tbx_mota
            // 
            this.tbx_mota.Location = new System.Drawing.Point(353, 149);
            this.tbx_mota.Name = "tbx_mota";
            this.tbx_mota.Size = new System.Drawing.Size(297, 31);
            this.tbx_mota.TabIndex = 8;
            // 
            // tbx_nambaohanh
            // 
            this.tbx_nambaohanh.Location = new System.Drawing.Point(353, 90);
            this.tbx_nambaohanh.Name = "tbx_nambaohanh";
            this.tbx_nambaohanh.Size = new System.Drawing.Size(297, 31);
            this.tbx_nambaohanh.TabIndex = 10;
            // 
            // cb_mausac
            // 
            this.cb_mausac.FormattingEnabled = true;
            this.cb_mausac.Location = new System.Drawing.Point(12, 90);
            this.cb_mausac.Name = "cb_mausac";
            this.cb_mausac.Size = new System.Drawing.Size(297, 33);
            this.cb_mausac.TabIndex = 11;
            // 
            // cb_nsx
            // 
            this.cb_nsx.FormattingEnabled = true;
            this.cb_nsx.Location = new System.Drawing.Point(12, 149);
            this.cb_nsx.Name = "cb_nsx";
            this.cb_nsx.Size = new System.Drawing.Size(297, 33);
            this.cb_nsx.TabIndex = 12;
            // 
            // cb_dongsp
            // 
            this.cb_dongsp.FormattingEnabled = true;
            this.cb_dongsp.Location = new System.Drawing.Point(353, 28);
            this.cb_dongsp.Name = "cb_dongsp";
            this.cb_dongsp.Size = new System.Drawing.Size(297, 33);
            this.cb_dongsp.TabIndex = 13;
            // 
            // cb_tensp
            // 
            this.cb_tensp.FormattingEnabled = true;
            this.cb_tensp.Location = new System.Drawing.Point(12, 28);
            this.cb_tensp.Name = "cb_tensp";
            this.cb_tensp.Size = new System.Drawing.Size(297, 33);
            this.cb_tensp.TabIndex = 15;
            // 
            // FrmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1219, 600);
            this.Controls.Add(this.cb_tensp);
            this.Controls.Add(this.cb_dongsp);
            this.Controls.Add(this.cb_nsx);
            this.Controls.Add(this.cb_mausac);
            this.Controls.Add(this.tbx_nambaohanh);
            this.Controls.Add(this.tbx_mota);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtg_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLSanPham";
            this.Text = "FrmQLSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_view;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox tbx_mota;
        private System.Windows.Forms.TextBox tbx_nambaohanh;
        private System.Windows.Forms.ComboBox cb_mausac;
        private System.Windows.Forms.ComboBox cb_nsx;
        private System.Windows.Forms.ComboBox cb_dongsp;
        private System.Windows.Forms.ComboBox cb_tensp;
    }
}