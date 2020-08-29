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
    public partial class FormXuatVatTu : DevExpress.XtraEditors.XtraForm
    {
        private static bool isCreating = false;
        public FormXuatVatTu()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQLVT);

        }

        private void FormXuatVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsQLVTDataSet_DATA.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.dsQLVT.PhieuXuat);
            // TODO: This line of code loads data into the 'dsQLVTDataSet_DATA.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.dsQLVT.CTPX);

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
                grEditL.Enabled = grEditR.Enabled = false;
                barEditL.Visible = barEditR.Visible = false;
            }
            else
            {
                cmbCN.Enabled = false;
                grEditL.Enabled = grEditR.Enabled = true;
                barEditL.Visible = barEditR.Visible = true;
            }
            btnSaveL.Enabled = btnUndoL.Enabled = btnSaveR.Enabled = btnUndoR.Enabled = false;
            grEditL.Enabled = grEditR.Enabled = false;

            cmbMaVT_R.Enabled = btnSaveR.Enabled = false;
            txtMaPXL.Enabled = txtMaPXR.Enabled = txtMaNVL.Enabled = txtMaVTR.Enabled = false;
            txtDonGiaR.Properties.MinValue = txtSLR.Properties.MinValue = 0;
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
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Fill(this.dsQLVT.PhieuXuat);
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTPXTableAdapter.Fill(this.dsQLVT.CTPX);
                    //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                }
            }
            else
            {
                Program.servername = cmbCN.SelectedValue.ToString();
            }
        }

        private void btnAddL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPX.AddNew();
            btnSaveL.Enabled = btnUndoL.Enabled = grEditL.Enabled = true;
            btnAddL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = false;
            //disable ctddh
            standAloneR.Enabled = gridPX.Enabled = gridCTPX.Enabled = false;

            isCreating = true;

            txtMaPXL.Enabled = true;
            txtMaNVL.Text = Program.username;
            txtMaPXL.Focus();
        }

        private void btnDeleteL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bdsCTPX.Count > 0)
                {
                    MessageBox.Show("Phiếu xuất đã lập phiếu chi tiết, không thể xóa phiếu xuất hàng này!", "Notification", MessageBoxButtons.OK);
                    return;
                }
                else if (MessageBox.Show("Bạn có muốn Xóa phiếu xuất hàng này ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsPX.RemoveCurrent();
                        this.phieuXuatTableAdapter.Update(this.dsQLVT.PhieuXuat);
                        MessageBox.Show("Xoá phiếu xuất hàng thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa phiếu xuát\n" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi xóa phiếu xuất\n" + exc.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSaveL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isCreating)
            {

                if (txtMaPXL.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã phiếu xuất không được để trống");
                    txtMaPXL.Focus();
                    return;
                }
                else
                {
                    SqlDataReader myReader;
                    string strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_CHECK_MAPX] @mapx = N'" + txtMaPXL.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int value = myReader.GetInt32(0);
                    myReader.Close();

                    if (value.Equals(1))
                    {
                        MessageBox.Show("Mã phiếu xuất đã tồn tại!!!\nVui lòng nhập lại!!!");
                        txtMaPXL.Focus();
                        return;
                    }
                }

                if (txtNgayL.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày tháng không được để trống");
                    txtNgayL.Focus();
                    return;
                }
                if (txtHoTenL.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ tên không được để trống");
                    txtHoTenL.Focus();
                    return;
                }

                try
                {
                    bdsPX.EndEdit();
                    bdsPX.ResetCurrentItem();
                    this.phieuXuatTableAdapter.Update(this.dsQLVT.PhieuXuat);
                    this.phieuXuatTableAdapter.Fill(this.dsQLVT.PhieuXuat);

                    btnSaveL.Enabled = btnUndoL.Enabled = grEditL.Enabled = false;
                    btnAddL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = true;
                    gridPX.Enabled = gridCTPX.Enabled = true;
                    standAloneR.Enabled = true;
                    MessageBox.Show("Thêm phiếu xuất thành công!", "", MessageBoxButtons.OK);

                    txtMaPXL.Enabled = false;
                    isCreating = false;
                    txtMaPXL.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi phiếu xuất\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {
                    bdsPX.EndEdit();
                    bdsPX.ResetCurrentItem();
                    this.phieuXuatTableAdapter.Update(this.dsQLVT.PhieuXuat);
                    this.phieuXuatTableAdapter.Fill(this.dsQLVT.PhieuXuat);
                    MessageBox.Show("Cập nhật phiếu xuất thành công!", "", MessageBoxButtons.OK);
                    txtMaPXL.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi phiếu xuất\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUndoL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAddL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = true;
            gridCTPX.Enabled = gridPX.Enabled = true;
            standAloneR.Enabled = true;
            btnSaveL.Enabled = btnUndoL.Enabled = grEditL.Enabled = false;
            txtMaPXL.Enabled = false;
            if (isCreating)
            {
                isCreating = false;
                this.phieuXuatTableAdapter.Fill(this.dsQLVT.PhieuXuat);
            }
            else
            {
                bdsPX.CancelEdit();
            }
            gridPX.Focus();
        }

        private void btnRefreshL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsQLVT.EnforceConstraints = false;
            this.phieuXuatTableAdapter.Fill(this.dsQLVT.PhieuXuat);
        }

        private void btnExitL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnExitR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnAddR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTPX.AddNew();
            cmbMaVT_R.SelectedIndex = -1;
            cmbMaVT_R.Enabled = btnSaveR.Enabled = btnUndoR.Enabled = grEditR.Enabled = true;
            btnAddR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = false;

            standAloneL.Enabled = gridCTPX.Enabled = gridPX.Enabled = false;

            isCreating = true;

            txtMaPXR.Enabled = false;
            txtMaPXR.EditValue = txtMaPXL.Text;
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
                else
                {
                    SqlDataReader myReader;
                    string strlenh = "EXEC	[dbo].[SP_SOLUONGTON] @mavt = N'" + txtMaVTR.Text.Trim() + "'";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int value = myReader.GetInt32(0);
                    myReader.Close();
                    if (int.Parse(txtSLR.Value.ToString()) > value)
                    {
                        MessageBox.Show("Số lượng tồn không đủ để xuất hàng");
                        txtSLR.Focus();
                        return;
                    }
                }
                if (txtDonGiaR.Text.Trim().Equals(""))
                {
                    MessageBox.Show("đơn giá không được để trống");
                    txtDonGiaR.Focus();
                    return;
                }

                try
                {
                    bdsCTPX.EndEdit();
                    bdsCTPX.ResetCurrentItem();
                    this.cTPXTableAdapter.Update(this.dsQLVT.CTPX);
                    this.cTPXTableAdapter.Fill(this.dsQLVT.CTPX);
                    try
                    {
                        SqlDataReader myReader;
                        string strlenh = "EXEC [dbo].[SP_CAPNHAT_SOLUONGTON_PX] @mavt = N'" + txtMaVTR.Text.Trim() + "', @SL = " + txtSLR.Value.ToString().Trim() + "";
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
                    btnAddR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = gridPX.Enabled = true;
                    standAloneL.Enabled = gridCTPX.Enabled = true;
                    MessageBox.Show("Thêm chi tiết phiếu xuất thành công!", "", MessageBoxButtons.OK);
                    cmbMaVT_R.Enabled = btnSaveR.Enabled = false;
                    isCreating = false;
                    txtMaPXR.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết phiếu xuất\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUndoR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSaveR.Enabled = btnUndoR.Enabled = grEditR.Enabled = false;
            cmbMaVT_R.Enabled = false;
            btnAddR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = true;
            standAloneL.Enabled = gridCTPX.Enabled = gridPX.Enabled = true;
            if (isCreating)
            {
                isCreating = false;
                this.cTPXTableAdapter.Fill(this.dsQLVT.CTPX);
            }
            else
            {
                bdsCTPX.CancelEdit();
            }
            gridCTPX.Focus();
        }

        private void btnRefreshR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsQLVT.EnforceConstraints = false;
            this.cTPXTableAdapter.Fill(this.dsQLVT.CTPX);
        }

        private void cmbMaVT_R_MouseClick(object sender, MouseEventArgs e)
        {
            cmbMaVT_R.DataSource = null;
            DataTable dt = Program.ExecSqlDataTable("EXEC[dbo].[SP_LAY_MAVT_CTPX] @mapx = N'" + txtMaPXL.Text.Trim() + "'");
            BindingSource bdsMaVT = new BindingSource();
            bdsMaVT.DataSource = dt;
            cmbMaVT_R.DataSource = bdsMaVT;
            cmbMaVT_R.DisplayMember = "TENVT";
            cmbMaVT_R.ValueMember = "MAVT";
            cmbMaVT_R.SelectedIndex = -1;
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

        private void cmbMaVT_R_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbMaVT_R.Text = cmbMaVT_R.SelectedValue.ToString();
            txtMaVTR.EditValue = cmbMaVT_R.SelectedValue.ToString();

            SqlDataReader myReader;
            string strlenh = "EXEC [dbo].[SP_SOLUONG_CTPX]" +
                             "@mavt = N'" + txtMaVTR.Text.ToString().Trim() + "'";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Read();
            int soLuong = int.Parse(myReader.GetValue(0).ToString());
            //double dongia = double.Parse(myReader.GetValue(1).ToString());
            myReader.Close();
            //txtDonGiaR.Properties.MinValue = (Decimal)dongia;
            txtDonGiaR.Properties.MinValue = 0;
            txtDonGiaR.Properties.MaxValue = decimal.MaxValue;
            //txtDonGiaR.Text = dongia.ToString();
            txtSLR.Properties.MinValue = 1;
            txtSLR.Properties.MaxValue = soLuong;
        }

        private void txtMaPXL_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}