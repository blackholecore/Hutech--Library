using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmQLSach s = new FrmQLSach();
            //s.ShowDialog();
            foreach (Form f in this.MdiChildren) 
            {
                if (f.Name == "FrmQLSach")
                {
                    f.Activate();
                    return;
                }

            }
            FrmQLSach fm = new FrmQLSach();
            fm.MdiParent = this;
            fm.Show();
        }

        private void quảnLýĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmQLDocGia dg = new FrmQLDocGia();
            //dg.ShowDialog();

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmQLDocGia")
                {
                    f.Activate();
                    return;
                }

            }
            FrmQLDocGia fm = new FrmQLDocGia();
            fm.MdiParent = this;
            fm.Show();
        }

        private void quảnLýThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmQLThe t = new FrmQLThe();
            //t.ShowDialog();

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmQLThe")
                {
                    f.Activate();
                    return;
                }

            }
            FrmQLThe fm = new FrmQLThe();
            fm.MdiParent = this;
            fm.Show();
        }

        private void theoDõiMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmMuonTraSach a = new FrmMuonTraSach();
            //a.ShowDialog();

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmMuonTraSach")
                {
                    f.Activate();
                    return;
                }

            }
            FrmMuonTraSach fm = new FrmMuonTraSach();
            fm.MdiParent = this;
            fm.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();

        }
        
    }
}
