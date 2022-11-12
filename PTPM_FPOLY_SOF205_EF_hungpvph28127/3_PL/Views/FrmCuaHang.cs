using _1_DAL.DomainClass;
using _2_BUS.IServices;
using _2_BUS.Services;
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
    public partial class FrmCuaHang : Form
    {
        private IQLCuaHangService _IQlCuaHangService;
        public CuaHang _ch;
        public Guid _id;
        public FrmCuaHang()
        {
            _ch = new CuaHang();
            _IQlCuaHangService = new CuaHangService();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dtg_view.ColumnCount = 6;
            dtg_view.Columns[0].Name = "Id";
            dtg_view.Columns[0].Visible = false;
            dtg_view.Columns[1].Name = "Mã";
            dtg_view.Columns[2].Name = "Tên";
            dtg_view.Columns[3].Name = "Địa chỉ";
            dtg_view.Columns[4].Name = "Thành phố";
            dtg_view.Columns[5].Name = "Quốc gia";

            dtg_view.Rows.Clear();
            foreach (var item in _IQlCuaHangService.GetAll())
            {
                dtg_view.Rows.Add(item.Id, item.Ma, item.Ten,item.DiaChi,item.ThanhPho, item.QuocGia);
            }
        }
        public void resetform()
        {
            LoadData();
            _ch = null;
            tbx_ma.Text = "";
            tbx_ten.Text = "";
            tbx_dc.Text = "";
            tbx_quocgia.Text = "";
            tbx_tp.Text = "";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (_IQlCuaHangService.GetAll().Any(x => x.Ma == tbx_ma.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                var _ch = new CuaHang()
                {
                    Id = new Guid(),
                    Ma = tbx_ma.Text,
                    Ten = tbx_ten.Text,
                    DiaChi = tbx_dc.Text,
                    ThanhPho = tbx_tp.Text,
                    QuocGia = tbx_quocgia.Text,
            };
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_IQlCuaHangService.Add(_ch));
                }
            }
            resetform();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_ch.Ma == tbx_ma.Text || (_ch.Ma != tbx_ma.Text && _IQlCuaHangService.GetAll().FirstOrDefault(x => x.Ma == tbx_ma.Text) == null))
            {
                _ch.Id = _id;
                _ch.Ma = tbx_ma.Text;
                _ch.Ten = tbx_ten.Text;
                _ch.DiaChi = tbx_dc.Text;
                _ch.ThanhPho = tbx_tp.Text;
                _ch.QuocGia = tbx_quocgia.Text;
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_IQlCuaHangService.Update(_ch));
                }
            }
            else
            {
                MessageBox.Show("Mã chức vụ đã tồn tại");
            }
            resetform();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            _ch.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_IQlCuaHangService.Delete(_ch));
            }
            resetform();
        }

        private void dtg_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = (Guid)dtg_view.CurrentRow.Cells[0].Value;
            tbx_ma.Text = dtg_view.CurrentRow.Cells[1].Value.ToString();
            tbx_ten.Text = dtg_view.CurrentRow.Cells[2].Value.ToString();
            tbx_dc.Text = dtg_view.CurrentRow.Cells[3].Value.ToString();
            tbx_tp.Text = dtg_view.CurrentRow.Cells[4].Value.ToString();
            tbx_quocgia.Text = dtg_view.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
