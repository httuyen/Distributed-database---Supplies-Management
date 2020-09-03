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
    public partial class FormInDSNV : DevExpress.XtraEditors.XtraForm
    {
        public FormInDSNV()
        {
            InitializeComponent();
        }

        private void FormInDSNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.SP_IN_DSNV' table. You can move, or remove it, as needed.
            ds_QLVT.EnforceConstraints = false;
            this.sP_IN_DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_IN_DSNVTableAdapter.Fill(this.ds_QLVT.SP_IN_DSNV);
            //this.reportViewer1.RefreshReport();
           
            if (Program.mGroup == "CHINHANH")
            {
                grCN.Enabled = false;
                btnPrint.Enabled = false;
                XtraNV xtraNV = new XtraNV();
                xtraNV.CreateDocument();
                documentViewer1.DocumentSource = xtraNV;
            }
            else
            {
                btnPrint.Enabled = true;
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
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            XtraNV xtraNV = new XtraNV();
            xtraNV.CreateDocument();
            documentViewer1.DocumentSource = xtraNV;
        }

        private void FormInDSNV_Leave(object sender, EventArgs e)
        {
            Program.servername = Program.serverNameDN;
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
        }
    }
}