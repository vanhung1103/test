using _1_DAL.DomainClass;
using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class FrmNSX : Form
    {
        private IQLNsxService _iqLNsxService;
        public Nsx _nsx;
        public Guid _id;
        public FrmNSX()
        {
            _nsx = new Nsx();
            _iqLNsxService = new NSXService();
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Mã";
            dataGridView1.Columns[2].Name = "Tên";

            dataGridView1.Rows.Clear();
            foreach (var item in  _iqLNsxService.GetAll())
            {
                dataGridView1.Rows.Add(item.Id, item.Ma, item.Ten);
            }
        }
        public void resetform()
        {
            LoadData();
            _nsx = null;
            tbx_ma.Text = "";
            tbx_ten.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if ( _iqLNsxService.GetAll().Any(x => x.Ma == tbx_ma.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                var nsx = new Nsx()
                {
                    Id = new Guid(),
                    Ma = tbx_ma.Text,
                    Ten = tbx_ten.Text,
                };
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show( _iqLNsxService.Add(nsx));
                }
            }
            resetform();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_nsx.Ma == tbx_ma.Text || (_nsx.Ma != tbx_ma.Text && _iqLNsxService.GetAll().FirstOrDefault(x => x.Ma == tbx_ma.Text) == null))
            {
                _nsx.Id = _id;
                _nsx.Ma = tbx_ma.Text;
                _nsx.Ten = tbx_ten.Text;
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show( _iqLNsxService.Update(_nsx));
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
            _nsx.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show( _iqLNsxService.Delete(_nsx));
            }
            resetform();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            _id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
            tbx_ma.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbx_ten.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
