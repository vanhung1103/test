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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQLSanPham());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCuaHang());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmChucVu());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDongsp());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmKhachHang());
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmMauSac());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNhanVien());
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNSX());
        }
    }
}
