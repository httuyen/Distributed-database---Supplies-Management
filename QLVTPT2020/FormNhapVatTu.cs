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
using System.Data.SqlClient;

namespace QLVTPT2020
{
    public partial class FormNhapVatTu : DevExpress.XtraEditors.XtraForm
    {
        private static bool isCreating = false;
        public FormNhapVatTu()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQLVT);

        }

        private void FormNhapVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.dsQLVT.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.dsQLVT.CTPN);

            cmbMSDDH.SelectedIndex = -1;
            cmbMaVT_R.SelectedIndex = -1;

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MACN FROM CHINHANH");
            BindingSource bdsCN = new BindingSource();
            bdsCN.DataSource = dt;
            Program.mMACN = ((DataRowView)bdsCN[0])["MACN"].ToString();
            cmbCN.DataSource = Program.bds_dspm;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbCN.Enabled = true;
                //grEdit_L.Enabled = grEdit_R.Enabled = false;
                standAloneL.Visible = standAloneR.Visible = false;
            }
            else
            {
                cmbCN.Enabled = false;
                //grEdit_L.Enabled = grEdit_R.Enabled = true;
                barEditL.Visible = barEditR.Visible = true;
            }

            txtDonGiaR.Enabled = false;
            btnSaveR.Enabled = btnUndoR.Enabled = btnSaveL.Enabled = btnUndoL.Enabled = cmbMaVT_R.Enabled = txtSLR.Enabled = false;
            grEditL.Enabled = grEditR.Enabled = false;

            if (bdsPN.Count > 0)
            {
                btnDeleteL.Enabled = true;
            }
            else
            {
                btnDeleteL.Enabled = false;
            }
            txtNgayL.Enabled = false;
            txtMaNVL.Enabled = false;
            cmbMaVT_R.Enabled = false;
            //if (bdsCTPN.Count > 0)
            //{
            //    btnDeleteR.Enabled = true;
            //}
            //else
            //{
            //    btnDeleteR.Enabled = false;
            //}
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Program.chuyenCN)
            {
                if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                Program.servername = cmbCN.SelectedValue.ToString();

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
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    //this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Fill(this.dsQLVT.PhieuNhap);
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPNTableAdapter.Fill(this.dsQLVT.CTPN);
                    //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                }
            }
            else
            {
                Program.servername = cmbCN.SelectedValue.ToString();
            }
        }

        private void cmbMSDDH_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dt = Program.ExecSqlDataTable("DECLARE @return_value int EXEC	@return_value = [dbo].[SP_MADH_CHUACOPN]");
            BindingSource bdsMSDDH = new BindingSource();
            bdsMSDDH.DataSource = dt;
            cmbMSDDH.DataSource = bdsMSDDH;
            cmbMSDDH.DisplayMember = "MasoDDH";
            cmbMSDDH.ValueMember = "MasoDDH";
            cmbMSDDH.SelectedIndex = -1;
        }

        private void btnAddL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbMSDDH.SelectedIndex = -1;
            bdsPN.AddNew();
            grEditL.Enabled = true;
            btnSaveL.Enabled = btnUndoL.Enabled = true;
            btnAddL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = false;
            //disable ctddh
            standAloneR.Enabled = gridCTPN.Enabled = gridPN.Enabled = grEditR.Enabled = false;

            isCreating = true;

            txtMaPNL.Enabled = true;
            txtMaNVL.Text = Program.username;
            txtNgayL.Text = DateTime.Now.ToShortDateString();
            txtMaPNL.Focus();
        }

        private void btnDeleteL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bdsCTPN.Count > 0)
                {
                    MessageBox.Show("Phiếu nhập đã lập phiếu chi tiết, không thể xóa phiếu nhập hàng này!", "Notification", MessageBoxButtons.OK);
                    return;
                }
                else if (MessageBox.Show("Bạn có muốn Xóa phiếu nhập hàng này ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsPN.RemoveCurrent();
                        this.phieuNhapTableAdapter.Update(this.dsQLVT.PhieuNhap);
                        MessageBox.Show("Xóa phiếu nhập thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu nhập\n" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi xóa phiếu nhập\n" + exc.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSaveL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaPNL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã phiếu nhập không được để trống");
                txtMaPNL.Focus();
                return;
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_CHECK_MAPN] @MAPN = N'" + txtMaPNL.Text.Trim() + "' SELECT	'Return Value' = @return_value ";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);
                myReader.Close();

                if (value.Equals(1))
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!!!\nVui lòng nhập lại!!!");
                    txtMaPNL.Focus();
                    return;
                }
            }

            if (txtNgayL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ngày tháng không được để trống");
                txtNgayL.Focus();
                return;
            }
            if (txtMSDDHL.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã đơn hàng không được để trống");
                txtMSDDHL.Focus();
                return;
            }

            try
            {
                bdsPN.EndEdit();
                bdsPN.ResetCurrentItem();
                this.phieuNhapTableAdapter.Update(this.dsQLVT.PhieuNhap);
                this.phieuNhapTableAdapter.Fill(this.dsQLVT.PhieuNhap);

                grEditL.Enabled = btnSaveL.Enabled = btnUndoL.Enabled = false;
                btnAddL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = gridPN.Enabled = true;
                standAloneR.Enabled = gridCTPN.Enabled = true;
                MessageBox.Show("Thêm phiếu nhập thành công!", "", MessageBoxButtons.OK);

                txtMaPNL.Enabled = false;
                isCreating = false;
                txtMaPNL.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi phiếu nhập\n" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnUndoL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grEditL.Enabled = btnSaveL.Enabled = btnUndoL.Enabled = false;
            btnAddL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = gridPN.Enabled = true;
            standAloneR.Enabled = gridCTPN.Enabled = true;
            txtMaPNL.Enabled = false;
            if (isCreating)
            {
                isCreating = false;
                this.phieuNhapTableAdapter.Fill(this.dsQLVT.PhieuNhap);
            }
            else
            {
                bdsPN.CancelEdit();
            }
            gridPN.Focus();
        }

        private void btnRefreshL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsQLVT.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Fill(this.dsQLVT.PhieuNhap);
        }

        private void btnExitL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnAddR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTPN.AddNew();
            cmbMaVT_R.SelectedIndex = -1;
            btnSaveR.Enabled = btnUndoR.Enabled = grEditR.Enabled = true;
            cmbMaVT_R.Enabled = btnSaveR.Enabled = txtSLR.Enabled = true;
            btnAddR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = false;
            //disable ctddh
            standAloneL.Enabled = gridCTPN.Enabled = gridPN.Enabled = grEditL.Enabled = false;

            isCreating = true;

            txtMaPNR.Enabled = false;
            txtMaPNR.EditValue = txtMaPNL.Text;
            txtMaVTR.Enabled = false;

            txtSLR.Focus();
        }

        private void btnSaveR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isCreating)
            {

                if (txtMaVTR.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã vật tư không được để trống");
                    txtMaVTR.Focus();
                    return;
                }
                if (txtSLR.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Số lượng không được để trống");
                    txtSLR.Focus();
                    return;
                }
                else if (int.Parse(txtSLR.Value.ToString().Trim()) > Program.soLuong)
                {
                    MessageBox.Show("Không thể nhập quá số lượng đơn đặt hàng");
                    txtSLR.Focus();
                    return;
                }
                if (txtDonGiaR.Text.Trim().Equals(""))
                {
                    MessageBox.Show("đơn giá không được để trống");
                    txtDonGiaR.Focus();
                    return;
                }

                try
                {
                    bdsCTPN.EndEdit();
                    bdsCTPN.ResetCurrentItem();
                    this.cTPNTableAdapter.Update(this.dsQLVT.CTPN);
                    this.cTPNTableAdapter.Fill(this.dsQLVT.CTPN);

                    try
                    {
                        SqlDataReader myReader;
                        string strlenh = "EXEC	[dbo].[SP_CAPNHAT_SOLUONGTON_PN] @mavt = N'" + txtMaVTR.Text.Trim() + "', @SL = " + txtSLR.Value.ToString().Trim() + "";
                        myReader = Program.ExecSqlDataReader(strlenh);
                        myReader.Read();
                        myReader.Close();
                        //if (myReader == null) MessageBox.Show("Lỗi cập nhật số lượng tồn");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi cập nhật số lượng tồn\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                    btnSaveR.Enabled = btnUndoR.Enabled = grEditR.Enabled = false;
                    btnAddR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = gridPN.Enabled = true;
                    standAloneL.Enabled = gridCTPN.Enabled = true;
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công!", "", MessageBoxButtons.OK);
                    cmbMaVT_R.SelectedIndex = -1;
                    Program.soLuong = 0;
                    isCreating = false;
                    cmbMaVT_R.Enabled = btnSaveR.Enabled = txtSLR.Enabled = false;
                    txtMaPNR.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết phiếu nhập\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUndoR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAddR.Enabled  = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = true;
            standAloneL.Enabled = gridCTPN.Enabled = gridPN.Enabled = true;
            btnSaveR.Enabled = btnUndoR.Enabled = txtSLR.Enabled = cmbMaVT_R.Enabled = false;
            if (isCreating)
            {
                isCreating = false;
                this.cTPNTableAdapter.Fill(this.dsQLVT.CTPN);
            }
            else
            {
                bdsCTPN.CancelEdit();
            }
            gridCTPN.Focus();
        }

        private void btnRefreshR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsQLVT.EnforceConstraints = false;
            this.cTPNTableAdapter.Fill(this.dsQLVT.CTPN);
        }

        private void btnExitR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cmbMSDDH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //txtMSDDH.Text = cmbMSDDH.SelectedValue.ToString();
            try
            {
                if (cmbMaVT_R.SelectedIndex != -1)
                {
                    txtMSDDHL.EditValue = cmbMSDDH.SelectedValue.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void cmbMaVT_R_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbMaVT_R.SelectedIndex >= 0)
            {
                txtMaVTR.EditValue = cmbMaVT_R.SelectedValue.ToString();
            }
            else
            {
                txtMaVTR.EditValue = "";
            }
        }

        private void cmbMaVT_R_MouseClick(object sender, MouseEventArgs e)
        {
            cmbMaVT_R.DataSource = null;
            DataTable dt = Program.ExecSqlDataTable(
                "EXEC [dbo].[SP_LAY_MAVT_CTPN] @mapn = N'"
                + txtMaPNR.Text.Trim() + "',@msddh = N'"
                + txtMSDDHL.Text.Trim() + "'");
            BindingSource bdsMaVT = new BindingSource();
            bdsMaVT.DataSource = dt;
            cmbMaVT_R.DataSource = bdsMaVT;
            cmbMaVT_R.DisplayMember = "TENVT";
            cmbMaVT_R.ValueMember = "MAVT";
            cmbMaVT_R.SelectedIndex = -1;
        }

        private void cmbMaVT_R_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                txtMaVTR.EditValue = cmbMaVT_R.SelectedValue.ToString();
                SqlDataReader myReader;
                string strLenh = "EXEC	[dbo].[SP_SOLUONG_DONGIA_CTPN] @mavt = N'" + txtMaVTR.Text.Trim() + "',@msddh = N'" + txtMSDDHL.Text.Trim() + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) return;
                myReader.Read();
                Program.soLuong = int.Parse(myReader.GetValue(0).ToString());
                double dongia = double.Parse(myReader.GetValue(1).ToString());
                myReader.Close();
                txtDonGiaR.Text = dongia.ToString();
                txtSLR.Properties.MinValue = 1;
                txtSLR.Properties.MaxValue = Program.soLuong;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu");
            }
        }

        private void gridPN_Click(object sender, EventArgs e)
        {
            if (txtMaPNR.Text.Equals(""))
            {
                cmbMaVT_R.Enabled = false;
            }
            else
            {
                cmbMaVT_R.Enabled = true;
            }
        }

        private void txtMaPNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar > (char)47) && (e.KeyChar < (char)58) || (e.KeyChar > (char)64) && (e.KeyChar < (char)91)))
                e.Handled = false;
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8) || (e.KeyChar > (char)96) && (e.KeyChar < (char)123))
                e.Handled = false;
            else
            {
                MessageBox.Show("chỉ bao gồm chữ cái và số!");
                e.Handled = true;
            }
        }

        private void cmbMSDDH_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbMSDDH.SelectedIndex >= 0)
            {
                txtMSDDHL.EditValue = cmbMSDDH.SelectedValue.ToString();
            }
            else
            {
                txtMSDDHL.EditValue = "";
            }
        }

        private void FormNhapVatTu_Leave(object sender, EventArgs e)
        {
            Program.servername = Program.serverNameDN;
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
        }
    }
}