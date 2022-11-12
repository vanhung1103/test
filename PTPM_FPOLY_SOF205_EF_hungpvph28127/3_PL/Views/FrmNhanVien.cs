using _1_DAL.DomainClass;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
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
    public partial class FrmNhanVien : Form
    {
        public IQLNhanVienService _iqLNhanVienService;
        public IQLChucVuService _iqLChucVuService;
        public IQLCuaHangService _iqLCuaHangService;
        public NhanVien _nv;
        public Guid _id;
        public FrmNhanVien()
        {
            _iqLNhanVienService = new NhanVienService();
            _iqLChucVuService = new ChucVuService();
            _iqLCuaHangService = new CuaHangService();
            InitializeComponent();
            LoadDataGridView();
            LoadCombobox();
        }
        public void LoadDataGridView()
        {

           
            dtg_view.ColumnCount = 12;
            dtg_view.Columns[0].Name = "Id";
            dtg_view.Columns[0].Visible = false;
            dtg_view.Columns[1].Name = "Mã";
            dtg_view.Columns[2].Name = "Tên";
            dtg_view.Columns[3].Name = "Cửa Hàng";
            dtg_view.Columns[4].Name = "Chức Vụ";
            dtg_view.Columns[5].Name = "Người gửi BC";
            dtg_view.Columns[6].Name = "Giới tính";
            dtg_view.Columns[7].Name = "Ngày sinh";
            dtg_view.Columns[8].Name = "Địa chỉ";
            dtg_view.Columns[9].Name = "SĐT";
            dtg_view.Columns[10].Name = "Mật khẩu";
            dtg_view.Columns[11].Name = "Trạng Thái";

            dtg_view.Rows.Clear();
            foreach (var item in _iqLNhanVienService.GetAll())
            {
                dtg_view.Rows.Add(item.NhanVien.Id,
                    item.NhanVien.Ma,
                    string.Concat(item.NhanVien.Ho, " ", item.NhanVien.TenDem, " ", item.NhanVien.Ten),
                    _iqLNhanVienService.GetByIdcv((Guid)item.NhanVien.IdCv).Ten,
                    _iqLNhanVienService.GetByIdch((Guid)item.NhanVien.IdCh).Ten,
                    item.NhanVien.IdGuiBc != null ? _iqLNhanVienService.GetAll().FirstOrDefault(x => x.NhanVien.Id == item.NhanVien.IdGuiBc).NhanVien.Ma : " ",
                    item.NhanVien.GioiTinh,
                    item.NhanVien.NgaySinh.ToString(),
                    item.NhanVien.DiaChi,
                    item.NhanVien.Sdt,
                    item.NhanVien.MatKhau,
                    item.NhanVien.TrangThai == 1 ? "Hoạt động" : "Không hoạt động"
                    );

            }
        }
        public void Resetfrom()
        {
            LoadDataGridView();
            
            tbx_ma.Text = "";
            tbx_ten.Text = "";
            tbx_tendem.Text = "";
            tbx_ho.Text = "";
            tbx_sdt.Text = "";
            tbx_diachi.Text = "";
            tbx_mk.Text = "";
            dtp_ngaysinh.Value = DateTime.Now;
            cbb_chucvu.Text = "";
            cbb_gioitinh.Text = "";
            cbb_cuahang.Text = "";
            cbb_guibc.Text = "";
            cb_hd.Checked = true;
            cb_khd.Checked = false;
        }
        public void LoadCombobox()
        {
            foreach (var item in _iqLChucVuService.GetAll())
            {
                cbb_chucvu.Items.Add(item.Ten);
            }
            foreach (var item in _iqLCuaHangService.GetAll())
            {
                cbb_cuahang.Items.Add(item.Ten);
            }
            foreach (var item in _iqLNhanVienService.GetAll())
            {
                cbb_guibc.Items.Add(item.NhanVien.Ma);
            }
            cbb_gioitinh.Items.Add("Nam");
            cbb_gioitinh.Items.Add("Nữ");

        }
        private void tbx_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tbx_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (_iqLNhanVienService.GetAll().Any(x => x.NhanVien.Ma == tbx_ma.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else if (cbb_gioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính");
            }
            else if (!cb_hd.Checked && !cb_khd.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else
            {
                NhanVienView nv = new NhanVienView();
                nv.NhanVien = new NhanVien();
                nv.ChucVu = new ChucVu();
                nv.CuaHang = new CuaHang();
                nv.NhanVien.Id = _id;
                nv.NhanVien.Ma = tbx_ma.Text;
                nv.NhanVien.Ten = tbx_ten.Text;
                nv.NhanVien.TenDem = tbx_tendem.Text;
                nv.NhanVien.Ho = tbx_ho.Text;
                nv.NhanVien.MatKhau = tbx_mk.Text;
                nv.NhanVien.GioiTinh = cbb_gioitinh.Text;
                nv.NhanVien.DiaChi = tbx_diachi.Text;
                nv.NhanVien.Sdt = tbx_sdt.Text;
                nv.NhanVien.IdCh = _iqLNhanVienService.GetnameCuaHang(cbb_cuahang.Text).Id;
                nv.NhanVien.IdCv = _iqLNhanVienService.Getnamechucvu(cbb_chucvu.Text).Id;
                nv.NhanVien.IdGuiBc = cbb_guibc.Text != "" ? _iqLNhanVienService.GetAll().FirstOrDefault(x => x.NhanVien.Ma == cbb_guibc.Text).NhanVien.Id : null;
                nv.NhanVien.TrangThai = cb_hd.Checked ? 1 : 0;
                nv.NhanVien.NgaySinh = dtp_ngaysinh.Value;

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_iqLNhanVienService.Add(nv));
                }
                LoadDataGridView();
                Resetfrom();
            }



           
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (tbx_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên");
            }
            else if (_iqLNhanVienService.GetAll().Any(x => x.NhanVien.Ma == tbx_ma.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
            }
            else if (cbb_gioitinh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giới tính");
            }
            else if (!cb_hd.Checked && !cb_khd.Checked)
            {
                MessageBox.Show("Vui lòng chọn trạng thái");
            }
            else
            {
                NhanVienView nv = new NhanVienView();
                nv.NhanVien = new NhanVien();
                nv.ChucVu = new ChucVu();
                nv.CuaHang = new CuaHang();
                nv.NhanVien.Id = _id;
                nv.NhanVien.Ma = tbx_ma.Text;
                nv.NhanVien.Ten = tbx_ten.Text;
                nv.NhanVien.TenDem = tbx_tendem.Text;
                nv.NhanVien.Ho = tbx_ho.Text;
                nv.NhanVien.MatKhau = tbx_mk.Text;
                nv.NhanVien.GioiTinh = cbb_gioitinh.Text;
                nv.NhanVien.DiaChi = tbx_diachi.Text;
                nv.NhanVien.Sdt = tbx_sdt.Text;
                nv.NhanVien.IdCh = _iqLNhanVienService.GetnameCuaHang(cbb_cuahang.Text).Id;
                nv.NhanVien.IdCv = _iqLNhanVienService.Getnamechucvu(cbb_chucvu.Text).Id;
                nv.NhanVien.IdGuiBc = cbb_guibc.Text != "" ? _iqLNhanVienService.GetAll().FirstOrDefault(x => x.NhanVien.Ma == cbb_guibc.Text).NhanVien.Id : null;
                nv.NhanVien.TrangThai = cb_hd.Checked ? 1 : 0;
                nv.NhanVien.NgaySinh = dtp_ngaysinh.Value;

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_iqLNhanVienService.Update(nv));
                }
                LoadDataGridView();
                Resetfrom();
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            NhanVienView nv = new NhanVienView();
            nv.NhanVien = new NhanVien();
            nv.NhanVien.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iqLNhanVienService.Delete(nv));
            }
            LoadDataGridView();
        }

        private void dtg_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtg_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = (Guid)dtg_view.CurrentRow.Cells[0].Value;
            tbx_ma.Text = dtg_view.CurrentRow.Cells[1].Value.ToString();
            tbx_ten.Text = dtg_view.CurrentRow.Cells[2].Value.ToString();
            cbb_cuahang.Text = dtg_view.CurrentRow.Cells[3].Value.ToString();
            cbb_chucvu.Text = dtg_view.CurrentRow.Cells[4].Value.ToString();
            cbb_guibc.Text = dtg_view.CurrentRow.Cells[5].Value.ToString();
            cbb_gioitinh.Text = dtg_view.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaysinh.Text = dtg_view.CurrentRow.Cells[7].Value.ToString();
            tbx_diachi.Text = dtg_view.CurrentRow.Cells[8].Value.ToString();
            tbx_sdt.Text = dtg_view.CurrentRow.Cells[9].Value.ToString();
            tbx_mk.Text = dtg_view.CurrentRow.Cells[10].Value.ToString();
            var b = dtg_view.CurrentRow.Cells[11].Value == "Không hoạt động" ? cb_khd.Checked = true : cb_hd.Checked = true;
           
        }
    }
}
