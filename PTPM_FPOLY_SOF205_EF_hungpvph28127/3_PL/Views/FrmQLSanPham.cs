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
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class FrmQLSanPham : Form
    {
        IQLSanPhamService _IqLSanPhamService;
        Guid _id;
        public FrmQLSanPham()
        {
            InitializeComponent();
            _IqLSanPhamService = new SanPhamService();
            LoadDataGridView();
            LoadCb_dongsp();
            LoadCb_mausac();
            LoadCb_nsx();
            LoadCb_sanpham();
        }
        public void LoadCb_mausac()
        {
            foreach (var item in _IqLSanPhamService.GetAllMau())
            {
                cb_mausac.Items.Add(item.Ten);
            }
        }
        public void LoadCb_dongsp()
        {
            foreach (var item in _IqLSanPhamService.GetAllDongsp())
            {
                cb_dongsp.Items.Add(item.Ten);
            }
        }
        public void LoadCb_sanpham()
        {
            foreach (var item in _IqLSanPhamService.GetAllSanPham())
            {
                cb_tensp.Items.Add(item.Ten);
            }
        }
        public void LoadCb_nsx()
        {
            foreach (var item in _IqLSanPhamService.GetAllNsx())
            {
                cb_nsx.Items.Add(item.Ten);
            }
        }
        public void LoadDataGridView()
        {
            int stt = 1;
            Type type = typeof(CuaHang);
            dtg_view.ColumnCount = 8;
            dtg_view.Columns[0].Name = "STT";
            dtg_view.Columns[1].Name = "Id";
            dtg_view.Columns[2].Name = "Tên SP";
            dtg_view.Columns[3].Name = "Tên Màu";
            dtg_view.Columns[4].Name = "Tên NSX";
            dtg_view.Columns[5].Name = "Tên DSP";
            dtg_view.Columns[6].Name = "Năm Bảo Hành"; 
            dtg_view.Columns[7].Name = "Mô tả";
           
            dtg_view.Rows.Clear();
            foreach (var item in _IqLSanPhamService.GetAll())
            {
                dtg_view.Rows.Add(stt++, item.ChiTietSp.Id, item.SanPham.Ten, item.MauSac.Ten, item.Nsx.Ten, item.DongSp.Ten,
                    item.ChiTietSp.NamBh, item.ChiTietSp.MoTa);
            }
        }

        private void dtg_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private SanPhamView GetDataFromGui()
        {
            SanPhamView spv = new SanPhamView();
            spv.ChiTietSp = new ChiTietSp();
            spv.SanPham = new SanPham();
            spv.ChiTietSp.IdSp =  _IqLSanPhamService.GetNameSp(cb_tensp.Text).Id;
            spv.ChiTietSp.IdDongSp = _IqLSanPhamService.GetNameDsp(cb_dongsp.Text).Id;
            spv.ChiTietSp.IdMauSac = _IqLSanPhamService.GetNameMs(cb_mausac.Text).Id;
            spv.ChiTietSp.IdNsx = _IqLSanPhamService.GetNameNsx(cb_nsx.Text).Id;
            spv.ChiTietSp.NamBh = int.Parse(tbx_nambaohanh.Text);
            spv.ChiTietSp.MoTa = tbx_mota.Text;
            return spv;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_IqLSanPhamService.Add(GetDataFromGui()));
            LoadDataGridView();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            SanPhamView spv = new SanPhamView();
            spv.ChiTietSp = new ChiTietSp();
            spv.MauSac = new MauSac();
            spv.SanPham = new SanPham();
            spv.DongSp = new DongSp();
            spv.Nsx = new Nsx();
            spv.ChiTietSp.Id = _id;
            spv.MauSac.Ten = cb_mausac.Text;
            spv.Nsx.Ten = cb_nsx.Text;
            spv.DongSp.Ten = cb_dongsp.Text;
            spv.SanPham.Ten = cb_tensp.Text;
            spv.ChiTietSp.NamBh = Convert.ToInt32(tbx_nambaohanh.Text);
            spv.ChiTietSp.MoTa = tbx_mota.Text;

            spv.ChiTietSp.IdSp = _IqLSanPhamService.GetNameSp(cb_tensp.Text).Id;
            spv.ChiTietSp.IdDongSp = _IqLSanPhamService.GetNameDsp(cb_dongsp.Text).Id;
            spv.ChiTietSp.IdMauSac = _IqLSanPhamService.GetNameMs(cb_mausac.Text).Id;
            spv.ChiTietSp.IdNsx = _IqLSanPhamService.GetNameNsx(cb_nsx.Text).Id;
            
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_IqLSanPhamService.Update(spv));
            }
            LoadDataGridView();

        }

        private void dtg_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            _id = (Guid)dtg_view.CurrentRow.Cells[1].Value;
            cb_tensp.Text = dtg_view.CurrentRow.Cells[2].Value.ToString();
            cb_mausac.Text = dtg_view.CurrentRow.Cells[3].Value.ToString();
            cb_nsx.Text = dtg_view.CurrentRow.Cells[4].Value.ToString();
            cb_dongsp.Text = dtg_view.CurrentRow.Cells[5].Value.ToString();
            tbx_nambaohanh.Text = dtg_view.CurrentRow.Cells[6].Value.ToString();
            tbx_mota.Text = dtg_view.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SanPhamView spv = new SanPhamView();
            spv.ChiTietSp = new ChiTietSp();
            spv.ChiTietSp.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_IqLSanPhamService.Delete(spv));
            }
            LoadDataGridView();
        }
    }
}
