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
    public partial class FrmQuanLy : Form
    {
        public FrmQuanLy()
        {
            InitializeComponent();
        }
        

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) // Open frmTaiKhoan
        {
           // FrmTaiKhoan tk = new FrmTaiKhoan();
           // tk.ShowDialog();

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmTaiKhoan")
                {
                    f.Activate();
                    return;
                }

            }
            FrmTaiKhoan fm = new FrmTaiKhoan();
            fm.MdiParent = this;
            fm.Show();
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //FrmQLThuThu qltt = new FrmQLThuThu();
            //qltt.ShowDialog();

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmQLThuThu")
                {
                    f.Activate();
                    return;
                }

            }
            FrmQLThuThu fm = new FrmQLThuThu();
            fm.MdiParent = this;
            fm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //FrmThongKe tk = new FrmThongKe();
            //tk.ShowDialog();

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmThongKe")
                {
                    f.Activate();
                    return;
                }

            }
            FrmThongKe fm = new FrmThongKe();
            fm.MdiParent = this;
            fm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //FrmQuyDinh tk = new FrmQuyDinh();
            //tk.ShowDialog();

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "FrmQuyDinh")
                {
                    f.Activate();
                    return;
                }

            }
            FrmQuyDinh fm = new FrmQuyDinh();
            fm.MdiParent = this;
            fm.Show();
        }

        private void FrmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
                this.Hide();
                FrmDangNhap dn = new FrmDangNhap();
                dn.Show(); 
        }
    }
}
