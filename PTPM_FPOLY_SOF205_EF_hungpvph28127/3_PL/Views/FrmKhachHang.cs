using _1_DAL.DomainClass;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class FrmKhachHang : Form
    {
        private IQLKhachHangService _iqLKhachHangService;
        public KhachHang _kh;
        public Guid _id;
        public FrmKhachHang()
        {
            _iqLKhachHangService = new KhachHangService();
            InitializeComponent();
            LoadToGrid();
        }
        public void LoadToGrid()
        {
            
            dtg_view.Rows.Clear();
            dtg_view.ColumnCount = 9;
            dtg_view.Columns[0].Name = "ID";
            dtg_view.Columns[0].Visible = false;
            dtg_view.Columns[1].Name = "Tên";
            dtg_view.Columns[2].Name = "Mã KH";
            dtg_view.Columns[3].Name = "Ngày sinh";
            dtg_view.Columns[4].Name = "SDT";
            dtg_view.Columns[5].Name = "Địa chỉ";
            dtg_view.Columns[6].Name = "Thành Phố";
            dtg_view.Columns[7].Name = "Quốc gia";
            dtg_view.Columns[8].Name = "Mật khẩu";
            foreach (var item in _iqLKhachHangService.GetAll())
            {
                dtg_view.Rows.Add(
                    item.KhachHang.Id,

                    string.Concat(item.KhachHang.Ho, " ", item.KhachHang.TenDem, " ", item.KhachHang.Ten),
                    item.KhachHang.Ma,
                    item.KhachHang.NgaySinh,
                    item.KhachHang.Sdt,
                    item.KhachHang.DiaChi,
                    item.KhachHang.ThanhPho,
                    item.KhachHang.QuocGia,
                    item.KhachHang.MatKhau
                    );
            }
        }
        public void Reset()
        {
            LoadToGrid();
            tbx_ten.Text = "";
            tbx_tendem.Text = "";
            tbx_ho.Text = "";
            tbx_ma.Text = "";
            dtp_ngaysinh.Value = DateTime.Now;
            tbx_sdt.Text = "";
            tbx_dc.Text = "";
            tbx_tp.Text = "";
            tbx_quocgia.Text = "";
            tbx_mk.Text = "";
        }
        private void tbx_dc_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void tbx_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_tp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_quocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            KhachHangView kh = new KhachHangView();
            kh.KhachHang = new KhachHang();


            kh.KhachHang.Id = _id;
            kh.KhachHang.Ma = tbx_ma.Text;
            kh.KhachHang.Ten = tbx_ten.Text;
            kh.KhachHang.TenDem = tbx_tendem.Text;
            kh.KhachHang.Ho = tbx_ho.Text;
            kh.KhachHang.NgaySinh = dtp_ngaysinh.Value;
            kh.KhachHang.MatKhau = tbx_mk.Text;
            kh.KhachHang.QuocGia = tbx_quocgia.Text;
            kh.KhachHang.ThanhPho = tbx_tp.Text;
            kh.KhachHang.DiaChi = tbx_dc.Text;
            kh.KhachHang.Sdt = tbx_sdt.Text;
               
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_iqLKhachHangService.Add(kh));
                }
            Reset();
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KhachHangView kh = new KhachHangView();
            kh.KhachHang = new KhachHang();


            kh.KhachHang.Id = _id;
            kh.KhachHang.Ma = tbx_ma.Text;
            kh.KhachHang.Ten = tbx_ten.Text;
            kh.KhachHang.TenDem = tbx_tendem.Text;
            kh.KhachHang.Ho = tbx_ho.Text;
            kh.KhachHang.NgaySinh = dtp_ngaysinh.Value;
            kh.KhachHang.MatKhau = tbx_mk.Text;
            kh.KhachHang.QuocGia = tbx_quocgia.Text;
            kh.KhachHang.ThanhPho = tbx_tp.Text;
            kh.KhachHang.DiaChi = tbx_dc.Text;
            kh.KhachHang.Sdt = tbx_sdt.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iqLKhachHangService.Update(kh));
            }
            Reset();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            KhachHangView kh = new KhachHangView();
            kh.KhachHang = new KhachHang();
            kh.KhachHang.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iqLKhachHangService.Delete(kh));
            }
            Reset();
        }

        private void dtg_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             _id = (Guid)dtg_view.CurrentRow.Cells[0].Value;
            tbx_ten.Text = dtg_view.CurrentRow.Cells[1].Value.ToString();
            tbx_ma.Text = dtg_view.CurrentRow.Cells[2].Value.ToString();
            dtp_ngaysinh.Text = dtg_view.CurrentRow.Cells[3].Value.ToString();
            tbx_sdt.Text = dtg_view.CurrentRow.Cells[4].Value.ToString();
            tbx_dc.Text = dtg_view.CurrentRow.Cells[5].Value.ToString();
            tbx_quocgia.Text = dtg_view.CurrentRow.Cells[6].Value.ToString();
            tbx_tp.Text = dtg_view.CurrentRow.Cells[7].Value.ToString();
            tbx_mk.Text = dtg_view.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
