using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVTPT2020
{
    public partial class FormInDH : DevExpress.XtraEditors.XtraForm
    {
        public FormInDH()
        {
            InitializeComponent();
        }

        private void FormInDH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.SP_IN_DSDH_CHUA_CO_PN' table. You can move, or remove it, as needed.
            this.sP_IN_DSDH_CHUA_CO_PNTableAdapter.Fill(this.qLVT_DATHANGDataSet_DATA.SP_IN_DSDH_CHUA_CO_PN);
            if (Program.mGroup == "CHINHANH")
            {
                cmbCN.Enabled = false;
            }
            else
            {
                cmbCN.Enabled = true;
                cmbCN.DataSource = Program.bds_dspm;
                cmbCN.DisplayMember = "TENCN";
                cmbCN.ValueMember = "TENSERVER";

            }
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue != null)
            {
                if (cmbCN.ValueMember != "")
                {
                    if (Program.servername != cmbCN.SelectedValue.ToString())
                    {
                        Program.servername = cmbCN.SelectedValue.ToString();
                    }
                    if (cmbCN.SelectedIndex != Program.mChinhanh)
                    {
                        Program.mlogin = Program.remotelogin;
                        Program.password = Program.remotepassword;
                    }
                    else
                    {
                        Program.mlogin = Program.mloginDN;
                        Program.password = Program.passwordDN;
                    }
                    if (Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XtraDH xtraDH = new XtraDH();
            xtraDH.CreateDocument();
            documentViewer1.DocumentSource = xtraDH;
        }

        private void FormInDH_Leave(object sender, EventArgs e)
        {
            Program.servername = Program.serverNameDN;
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
        }
    }
}