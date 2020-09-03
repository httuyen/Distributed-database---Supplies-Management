using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLVTPT2020
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "USER")
            {
                //btnCreateAcc.Enabled = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
            }
            else
            {
                //btnCreateAcc.Enabled = true;
                ribbonPage2.Visible = true;
                ribbonPage3.Visible = true;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FormNhanVien f = new FormNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormVatTu));
            if (frm != null) frm.Activate();
            else
            {
                FormVatTu f = new FormVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void FormMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Program.servername = Program.serverNameDN;
            Program.formDangNhap.Show();
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKho));
            if (frm != null) frm.Activate();
            else
            {
                FormKho f = new FormKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDonDatHang));
            if (frm != null) frm.Activate();
            else
            {
                FormDonDatHang f = new FormDonDatHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnNhapVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhapVatTu));
            if (frm != null) frm.Activate();
            else
            {
                FormNhapVatTu f = new FormNhapVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXuatVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXuatVatTu));
            if (frm != null) frm.Activate();
            else
            {
                FormXuatVatTu f = new FormXuatVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCreateAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTaiKhoan f = new FormTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormInDSNV));
            if (frm != null) frm.Activate();
            else
            {
                FormInDSNV f = new FormInDSNV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormInVT));
            if (frm != null) frm.Activate();
            else
            {
                FormInVT f = new FormInVT();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDSDH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormInDH));
            if (frm != null) frm.Activate();
            else
            {
                FormInDH f = new FormInDH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInBK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormInBangKet));
            if (frm != null) frm.Activate();
            else
            {
                FormInBangKet f = new FormInBangKet();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form1));
            if (frm != null) frm.Activate();
            else
            {
                Form1 f = new Form1();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}