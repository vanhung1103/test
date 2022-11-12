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
using System.Windows.Media;

namespace _3_PL.Views
{
    public partial class FrmChucVu : Form
    {
        private IQLChucVuService _IQlchucVuService;
        public ChucVu _cv;
        public Guid _id;
        public FrmChucVu()
        {
            _cv = new ChucVu();
            _IQlchucVuService = new ChucVuService();
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
            foreach (var item in _IQlchucVuService.GetAll())
            {
                dataGridView1.Rows.Add(item.Id, item.Ma, item.Ten);
            }
        }
        public void resetform()
        {
            LoadData();
            _cv = null;
            tbx_ma.Text = "";
            tbx_ten.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
             if (_IQlchucVuService.GetAll().Any(x => x.Ma == tbx_ma.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                 var cv = new ChucVu()
                {
                    Id = new Guid(),
                    Ma = tbx_ma.Text,
                    Ten = tbx_ten.Text,
                };
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_IQlchucVuService.Add(cv));
                }
            }
            resetform();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_cv.Ma == tbx_ma.Text || (_cv.Ma != tbx_ma.Text && _IQlchucVuService.GetAll().FirstOrDefault(x => x.Ma == tbx_ma.Text) == null))
            {
                    _cv.Id = _id;
                    _cv.Ma = tbx_ma.Text;
                    _cv.Ten = tbx_ten.Text;
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_IQlchucVuService.Update(_cv));
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
            
                
                _cv.Id = _id;
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show(_IQlchucVuService.Delete(_cv));
                }
                resetform();
            
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
            tbx_ma.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbx_ten.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
