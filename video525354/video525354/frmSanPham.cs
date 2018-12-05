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
    public partial class frmSanPham : Form
    {

        public static List<DanhMuc> dsdm = new List<DanhMuc>();
        public static List<SanPham> dssp = new List<SanPham>();

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            frmDanhMuc frmDM = new frmDanhMuc();
            
            frmDanhMuc.Cothaydoi = false;
            frmDM.ShowDialog();
            if (frmDanhMuc.Cothaydoi==true)
            {
                comboBox1.Items.Clear();
                foreach (DanhMuc dm in dsdm)
                {
                    comboBox1.Items.Add(dm);
                }
            }
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Chưa chọn danh mục");
            else
            {
                DanhMuc dm = comboBox1.SelectedItem as DanhMuc;
                SanPham sp = new SanPham();
                sp.MaSP = txtMasp.Text;
                sp.TenSP = txtTensp.Text;
                sp.DonGia =int.Parse( txtDongia.Text);
                sp.HanDung =dtHandung.Value;
                sp.Xuatsu = txtXuatxu.Text;
                dm.ThemSP(sp);
                dssp.Add(sp);
                
                HienThiSanPhamLenListBox();
                XoaTrang();
            }
        }

        private void XoaTrang()
        {
            txtTensp.Text = "";
            txtMasp.Text = "";
            txtDongia.Text = "";
            txtXuatxu.Text = "";
            txtMasp.Focus();
        }

        private void HienThiSanPhamLenListBox()
        {
            listBox1.Items.Clear();
            foreach(SanPham sp in dssp)
            {
                listBox1.Items.Add(sp);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            SanPham sp = listBox1.SelectedItem as SanPham;
            txtMasp.Text = sp.MaSP;
            txtTensp.Text = sp.TenSP;
            txtDongia.Text =sp.DonGia.ToString();
            txtXuatxu.Text = sp.Xuatsu;
            dtHandung.Value = sp.HanDung;
            comboBox1.SelectedItem = sp.Nhom;
            //DanhMuc dm = comboBox1.SelectedItem as DanhMuc;
            //comboBox1.Text = sp.Nhom.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SanPham sp = listBox1.SelectedItem as SanPham;
                DialogResult ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    XoaTrang();
                    listBox1.Items.Remove(sp);
                    dssp.Remove(sp);
                    HienThiSanPhamLenListBox();
                }
                else
                    return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
