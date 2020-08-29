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
    public partial class FormDonDatHang : DevExpress.XtraEditors.XtraForm
    {
        private static bool isCreating = false;
        public FormDonDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQLVT);

        }

        private void FormDonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);
            // TODO: This line of code loads data into the 'dsQLVT.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.dsQLVT.PhieuNhap);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.dsQLVT.CTDDH);
            
            txtMaNV.Enabled = false;
            txtMSDDH.Enabled = false;

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
                grEditCTDDH.Enabled = grEditDDH.Enabled = false;
                barEditL.Visible = barEditR.Visible = false;
            }
            else
            {
                cmbCN.Enabled = false;
                grEditCTDDH.Enabled = grEditDDH.Enabled = true;
                barEditL.Visible = barEditL.Visible = true;
            }

            txtMaVT.Enabled = false;
            txtMSDDH.Enabled = false;
            btnSaveL.Enabled = btnUndoL.Enabled = btnSaveR.Enabled = btnUndoR.Enabled = false;
            grEditDDH.Enabled = grEditCTDDH.Enabled = false;


            this.txtDonGia.Properties.MinValue = 0;
            this.txtDonGia.Properties.MaxValue = Decimal.MaxValue;

            this.txtSL.Properties.MinValue = 0;
            this.txtSL.Properties.MaxValue = Decimal.MaxValue;
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
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTDDHTableAdapter.Fill(this.dsQLVT.CTDDH);
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
            bdsDH.AddNew();
            btnAddL.Enabled = btnEditL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = false;
            btnSaveL.Enabled = btnUndoL.Enabled = grEditDDH.Enabled = true;

            //disable ctddh
            standAloneR.Enabled = gridCTDDH.Enabled = grEditCTDDH.Enabled = gridDH.Enabled = false;

            isCreating = true;
            gridDH.Enabled = false;
            gridCTDDH.Enabled = false;
            txtMaNV.Text = Program.username;
            txtMSDDH.Enabled = true;
            txtMSDDH.Focus();
        }

        private void btnEditL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAddL.Enabled = btnEditL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = false;
            standAloneR.Enabled = grEditCTDDH.Enabled = gridCTDDH.Enabled = false;
            btnSaveL.Enabled = btnUndoL.Enabled = true;
            grEditDDH.Enabled = true;
        }

        private void btnDeleteL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bdsCTDDH.Count > 0)
                {
                    MessageBox.Show("Đơn đặt hàng đã lập phiếu, không thể xóa đơn!", "Notification", MessageBoxButtons.OK);
                    return;
                }
                else if (MessageBox.Show("Bạn có muốn Xóa đơn đặt hàng ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsDH.RemoveCurrent();
                        this.datHangTableAdapter.Update(this.dsQLVT.DatHang);
                        MessageBox.Show("Xóa đơn đặt hàng thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa đơn đặt hàng\n" + ex.Message, "", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi xóa đơn đặt hàng\n" + exc.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnSaveL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isCreating)
            {

                if (txtMSDDH.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã đơn hàng không được để trống");
                    txtMSDDH.Focus();
                    return;
                }
                else
                {
                    SqlDataReader myReader;
                    String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_CHECK_MSDDH] @msddh = N'" + txtMSDDH.Text.Trim() + "'"
                        + "SELECT  'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int value = myReader.GetInt32(0);
                    myReader.Close();

                    if (value.Equals(1))
                    {
                        MessageBox.Show("Mã đơn hàng đã tồn tại!!!\nVui lòng nhập lại!!!");
                        txtMSDDH.Focus();
                        return;
                    }
                }

                if (txtNgay.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày tháng không được để trống");
                    txtNgay.Focus();
                    return;
                }
                if (txtNCC.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Nhà cung cấp không được để trống");
                    txtNCC.Focus();
                    return;
                }

                try
                {
                    bdsDH.EndEdit();
                    bdsDH.ResetCurrentItem();
                    this.datHangTableAdapter.Update(this.dsQLVT.DatHang);
                    this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);


                    btnAddL.Enabled = btnEditL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = gridDH.Enabled = true;
                    btnSaveL.Enabled = btnUndoL.Enabled = false;
                    standAloneR.Enabled = gridCTDDH.Enabled = grEditCTDDH.Enabled = true;
                    MessageBox.Show("Thêm đơn thành công!", "", MessageBoxButtons.OK);

                    txtMSDDH.Enabled = false;
                    isCreating = false;
                    txtMSDDH.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi đơn hàng\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {
                    bdsDH.EndEdit();
                    bdsDH.ResetCurrentItem();
                    btnSaveL.Enabled = btnUndoL.Enabled = false;
                    btnAddL.Enabled = btnEditL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = gridDH.Enabled = true;
                    this.datHangTableAdapter.Update(this.dsQLVT.DatHang);
                    this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);
                    MessageBox.Show("Cập nhật kho thành công!", "", MessageBoxButtons.OK);
                    txtMSDDH.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi kho\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUndoL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAddL.Enabled = btnEditL.Enabled = btnDeleteL.Enabled = btnRefreshL.Enabled = btnExitL.Enabled = grCN.Enabled = gridDH.Enabled = true;
            btnSaveL.Enabled = btnUndoL.Enabled = grEditDDH.Enabled = false;
            standAloneR.Enabled = gridCTDDH.Enabled = grEditCTDDH.Enabled = true;
            txtMSDDH.Enabled = false;
            if (isCreating)
            {
                isCreating = false;
                this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);
            }
            else
            {
                bdsDH.CancelEdit();
            }
            gridDH.Focus();
        }

        private void btnRefreshL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsQLVT.EnforceConstraints = false;
            this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);
        }

        private void btnExitL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnAddR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCTDDH.AddNew();
            grEditCTDDH.Enabled = true;
            btnSaveR.Enabled = btnUndoR.Enabled = true;
            btnAddR.Enabled = btnDeleteR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = false;
            //disable ctddh
            standaloneL.Enabled = gridDH.Enabled = grEditDDH.Enabled = gridCTDDH.Enabled = false;

            isCreating = true;
            txtMSDDHR.Text = txtMSDDH.Text;
            cmbMaVT_R.Focus();
        }

        private void btnDeleteR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xóa chi tiết đơn hàng ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_CHECK_XOACTDDH] " +
                    "@MADDH = N'" + txtMSDDHR.Text.ToString().Trim() + "', " +
                    "@MAVT = N'" + txtMaVT.Text.ToString().Trim() + "' " +
                    "SELECT 'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);
                if (myReader == null) return;
                myReader.Read();
                int value = myReader.GetInt32(0);
                myReader.Close();

                if (value.Equals(1))
                {
                    MessageBox.Show("Đơn đã lập phiếu nhập nên không thể xóa !!!");
                    return;
                }
                try
                {
                    bdsCTDDH.RemoveCurrent();
                    this.cTDDHTableAdapter.Update(this.dsQLVT.CTDDH);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết đơn hàng\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSaveR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isCreating)
            {
                if (txtMaVT.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã vật tư không được để trống");
                    txtMaVT.Focus();
                    return;
                }
                if (txtSL.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Số lượng không được để trống");
                    txtSL.Focus();
                    return;
                }
                if (txtDonGia.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đơn giá không được để trống");
                    txtDonGia.Focus();
                    return;
                }
                try
                {
                    bdsCTDDH.EndEdit();
                    bdsCTDDH.ResetCurrentItem();
                    this.cTDDHTableAdapter.Update(this.dsQLVT.CTDDH);
                    this.cTDDHTableAdapter.Fill(this.dsQLVT.CTDDH);
                    btnAddR.Enabled = btnDeleteR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = gridCTDDH.Enabled = true;
                    standaloneL.Enabled = gridDH.Enabled = true;
                    grEditCTDDH.Enabled = btnSaveR.Enabled = btnUndoR.Enabled = false;
                    cmbMaVT_R.SelectedIndex = -1;
                    MessageBox.Show("Thêm chi tiết đơn đặt hàng thành công!", "", MessageBoxButtons.OK);
                    isCreating = false;
                    txtMSDDHR.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết đơn hàng\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {
                    bdsCTDDH.EndEdit();
                    bdsCTDDH.ResetCurrentItem();
                    btnSaveR.Enabled = btnUndoR.Enabled = false;
                    grEditCTDDH.Enabled = false;
                    this.datHangTableAdapter.Update(this.dsQLVT.DatHang);
                    this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);
                    MessageBox.Show("Cập nhật đơn hàng thành công!", "", MessageBoxButtons.OK);
                    cmbMaVT_R.SelectedIndex = -1;
                    txtMSDDHR.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi chi tiết đơn hàng\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUndoR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAddR.Enabled = btnDeleteR.Enabled = btnRefreshR.Enabled = btnExitR.Enabled = grCN.Enabled = gridCTDDH.Enabled = true;
            standaloneL.Enabled = gridDH.Enabled = true;
            grEditCTDDH.Enabled = btnSaveR.Enabled = btnUndoR.Enabled = false;
            if (isCreating)
            {
                isCreating = false;
                this.cTDDHTableAdapter.Fill(this.dsQLVT.CTDDH);

            }
            else
            {
                bdsCTDDH.CancelEdit();
            }
            gridCTDDH.Focus();
            cmbMaVT_R.SelectedIndex = -1;
        }

        private void btnRefreshR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsQLVT.EnforceConstraints = false;
            this.cTDDHTableAdapter.Fill(this.dsQLVT.CTDDH);
        }

        private void btnExitR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMSDDHR_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gridDH_Click(object sender, EventArgs e)
        {
            cmbMaVT_R.SelectedIndex = -1;
            if (bdsCTDDH.Count > 0)
            {
                btnEditL.Enabled = btnDeleteL.Enabled = false;
            }
            else
            {
                btnEditL.Enabled = btnDeleteL.Enabled = true;
            }
        }

        private void cmbMaVT_R_Click(object sender, EventArgs e)
        {
            DataTable dt = Program.ExecSqlDataTable("DECLARE @return_value int EXEC @return_value = [dbo].[SP_LAY_MAVT] @MSDDH = N'" + txtMSDDHR.Text.Trim() + "'");
            BindingSource bdsMaVT = new BindingSource();
            bdsMaVT.DataSource = dt;
            //Program.mMACN = ((DataRowView)bdsMaVT[1])["TENVT"].ToString();
            cmbMaVT_R.DataSource = bdsMaVT;
            cmbMaVT_R.DisplayMember = "TENVT";
            cmbMaVT_R.ValueMember = "MAVT";
            cmbMaVT_R.SelectedIndex = -1;
        }

        private void gridCTDDH_Click(object sender, EventArgs e)
        {
            cmbMaVT_R.SelectedIndex = -1;
            //txtMaVT_R.EditValue = "";
        }

        private void cmbMaVT_R_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbMaVT_R.SelectedIndex >= 0)
                {
                    txtMaVT.EditValue = cmbMaVT_R.SelectedValue.ToString();
                }
                else
                {
                    txtMaVT.EditValue = "";
                }
            }
            catch
            {
                return;
            }
        }
    }
}