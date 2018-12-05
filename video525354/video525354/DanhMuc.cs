using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video525354
{
    public class DanhMuc
    {
        Dictionary<string, SanPham> dssp = new Dictionary<string, SanPham>();
        public string MaDM { get; set; }
        public string TenDM { get; set; }

        public void ThemSP(SanPham sp)
        {
            if (dssp.ContainsKey(sp.MaSP) == false)

            {
                this.dssp.Add(sp.MaSP, sp);
                sp.Nhom = this;
            }
            
        }
        public Dictionary<string, SanPham> Sanphams
        {
            get { return this.dssp; }
            set { this.dssp = value; }
        }
        public override string ToString()
        {
            return this.TenDM;
        }

    }
}
