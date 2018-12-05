using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video525354
{
    public partial class frmDanhMuc : Form
    {
        public static bool Cothaydoi = false;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuDM_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaDM, "");
            errorProvider1.SetError(txtTenDm, "");
            if (txtMaDM.Text != "" && txtTenDm.Text != "")
            {
                DanhMuc dm = new DanhMuc();
                dm.MaDM = txtMaDM.Text;
                dm.TenDM = txtTenDm.Text;
                frmSanPham.dsdm.Add(dm);
            }
            else
            {
                if (txtMaDM.Text == "")
                    errorProvider1.SetError(txtMaDM, "Empty!");
                if (txtTenDm.Text == "")
                    errorProvider1.SetError(txtTenDm, "Empty!");
            }
            
            HienThiDanhMucLenListBox();
            txtMaDM.Text = "";
            txtTenDm.Text = "";
            txtMaDM.Focus();
            Cothaydoi = true;


        }
        private void HienThiDanhMucLenListBox()
        {
            lstDsDM.Items.Clear();
            foreach(DanhMuc dm in frmSanPham.dsdm)
            {
                lstDsDM.Items.Add(dm);
            }
        }

        private void lstDsDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDsDM.SelectedIndex == -1)
                return;
            DanhMuc dm = lstDsDM.SelectedItem as DanhMuc;
            txtMaDM.Text = dm.MaDM;
            txtTenDm.Text = dm.TenDM;
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {

            if (lstDsDM.SelectedIndex != -1)
            {
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa danh mục này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(ret==DialogResult.Yes)
                {

                    
                    DanhMuc dm = lstDsDM.SelectedItem as DanhMuc;
                    lstDsDM.Items.Remove(dm);
                    frmSanPham.dsdm.Remove(dm);

                    txtMaDM.Text = "";
                    txtTenDm.Text = "";
                    HienThiDanhMucLenListBox();
                }
            }
            Cothaydoi = true;
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }

        private void btnDongDM_Click(object sender, EventArgs e)
        {
            if (Cothaydoi == true)
                DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }
    }
}
