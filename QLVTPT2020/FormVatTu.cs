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
    public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
    {
        private static bool isCreating = false;
        public FormVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.QLVT_DATHANG_DS);

        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.QLVT_DATHANG_DS.Vattu);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.QLVT_DATHANG_DS.CTPX);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.QLVT_DATHANG_DS.CTPN);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.QLVT_DATHANG_DS.CTDDH);

            if (Program.mGroup == "CONGTY")
            {
                groupBoxEdit.Enabled = false;
                barEdit.Visible = false;
            }
            else
            {
                groupBoxEdit.Enabled = true;
                barEdit.Visible = true;
            }
            btnSave.Enabled = btnUndo.Enabled = groupBoxEdit.Enabled = false;

            txtMaVT.Enabled = false;
            txtSLT.Enabled = false;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVT.AddNew();
            txtMaVT.Enabled = true;
            isCreating = true;
            groupBoxEdit.Enabled = btnSave.Enabled = btnUndo.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = gridVatTu.Enabled = txtSLT.Enabled = false;
            txtSLT.Text = "0";
            txtMaVT.Focus();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Vật tư đã tồn tại trong PN. ", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Vật tư đã tồn tại trong Đơn ĐH. ", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Vật tư đã tồn tại trong PX. ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa vật tư này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsVT.RemoveCurrent();
                    this.vattuTableAdapter.Update(this.QLVT_DATHANG_DS.Vattu);
                    MessageBox.Show("Xóa vật tư thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vật tư\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isCreating)
            {
                if (txtMaVT.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã vật tư không được để trống !", "", MessageBoxButtons.OK);
                    txtMaVT.Focus();
                    return;
                }
                else
                {
                    SqlDataReader myReader;
                    string strlenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_CHECK_MAVT] @mavt = N'" + txtMaVT.Text + "' SELECT	'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int maVTExist = myReader.GetInt32(0);
                    myReader.Close();

                    if (maVTExist == 1)
                    {
                        MessageBox.Show("Mã vật tư đã tồn tại\nvui lòng nhập lại", "", MessageBoxButtons.OK);
                        txtMaVT.Focus();
                        return;
                    }
                }

                if (txtTenVT.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên vật tư không được để trống");
                    txtTenVT.Focus();
                    return;
                }
                else
                {
                    SqlDataReader myReader;
                    string strlenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_CHECK_TENVT] @tenvt = N'" + txtTenVT.Text.Trim() + "' SELECT 'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int value = myReader.GetInt32(0);
                    myReader.Close();

                    if (value == 1)
                    {
                        MessageBox.Show("Tên vật tư đã tồn tại, vui lòng nhập lại!");
                        txtTenVT.Focus();
                        return;
                    }
                }
                if (txtDVT.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Đơn vị tính vật tư không được để trống");
                    txtDVT.Focus();
                    return;
                }
            }

            try
            {
                bdsVT.EndEdit();
                bdsVT.ResetCurrentItem();
                btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = gridVatTu.Enabled = true;
                btnSave.Enabled = btnUndo.Enabled = groupBoxEdit.Enabled = false;
                this.vattuTableAdapter.Update(this.QLVT_DATHANG_DS.Vattu);
                this.vattuTableAdapter.Fill(this.QLVT_DATHANG_DS.Vattu);
                if (isCreating)
                {
                    MessageBox.Show("Thêm Vật tư thành công!", "", MessageBoxButtons.OK);
                    txtMaVT.Enabled = false;
                    isCreating = false;
                    gridVatTu.Focus();
                }
                else
                {
                    MessageBox.Show("Cập nhật Vật tư thành công!", "", MessageBoxButtons.OK);
                    txtMaVT.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi vật tư\n" + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = gridVatTu.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = groupBoxEdit.Enabled = false;
            txtMaVT.Enabled = false;
            txtMaVT.Focus();
            if (isCreating)
            {
                isCreating = false;

                this.vattuTableAdapter.Fill(this.QLVT_DATHANG_DS.Vattu);
            }
            else
            {
                bdsVT.CancelEdit();
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QLVT_DATHANG_DS.EnforceConstraints = false;
            this.vattuTableAdapter.Fill(this.QLVT_DATHANG_DS.Vattu);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBoxEdit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = gridVatTu.Enabled = txtSLT.Enabled = false;
        }

        private void txtMaVT_KeyPress(object sender, KeyPressEventArgs e)
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