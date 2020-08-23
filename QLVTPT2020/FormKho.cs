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
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        private static bool isCreating = false;
        public FormKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_QLVT);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.ds_QLVT.Kho);

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
                grEdit.Enabled = false;
                barEdit.Visible = false;
            }
            else
            {
                cmbCN.Enabled = false;
                grEdit.Enabled = true;
                barEdit.Visible = true;
            }
            txtMaCN.Enabled = false;
            txtMaKho.Enabled = false;

            btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = false;
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.ds_QLVT.Kho);

                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.AddNew();
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = grCN.Enabled = txtMaCN.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = true;

            isCreating = true;

            txtMaCN.EditValue = Program.mMACN;
            txtMaCN.Enabled = false;
            gridKho.Enabled = false;
            txtMaKho.Enabled = true;
            txtMaKho.Focus();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRefresh.Enabled = btnExit.Enabled = gridKho.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa kho này ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Update(this.ds_QLVT.Kho);
                    MessageBox.Show("Xóa kho thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isCreating)
            {
                if (txtMaKho.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã kho không được để trống");
                    txtMaKho.Focus();
                    return;
                }
                else
                {
                    SqlDataReader myReader;
                    String strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_CHECK_MAKHO] @makho = N'" + txtMaKho.Text.Trim() + "' "
                        + "SELECT  'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int value = myReader.GetInt32(0);
                    myReader.Close();

                    if (value.Equals(1))
                    {
                        MessageBox.Show("Mã kho đã tồn tại!!!\nVui lòng nhập lại!!!");
                        txtMaKho.Focus();
                        return;
                    }
                }

                if (txtTenKho.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên kho không được để trống");
                    txtTenKho.Focus();
                    return;
                }
                else
                {
                    SqlDataReader myReader;
                    String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_CHECK_TENKHO] @tenkho = N'" + txtTenKho.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int value = myReader.GetInt32(0);
                    myReader.Close();

                    if (value.Equals(1))
                    {
                        MessageBox.Show("Tên kho đã tồn tại!!!\nVui lòng nhập lại!!!");
                        txtTenKho.Focus();
                        return;
                    }


                    if (txtDiaChi.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Địa chỉ không được để trống");
                        txtDiaChi.Focus();
                        return;
                    }
                }

                try
                {
                    bdsKho.EndEdit();
                    bdsKho.ResetCurrentItem();
                    btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = false;
                    btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = grCN.Enabled = gridKho.Enabled = true;
                    this.khoTableAdapter.Update(this.ds_QLVT.Kho);
                    this.khoTableAdapter.Fill(this.ds_QLVT.Kho);
                    MessageBox.Show("Thêm kho thành công!", "", MessageBoxButtons.OK);
                    txtMaKho.Enabled = false;
                    isCreating = false;
                    gridKho.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi kho\n" + "Mã kho chỉ tối đa 4 ký tự. Vui lòng nhập lại!!!", "", MessageBoxButtons.OK);
                    txtMaKho.Focus();
                }
            }
            else
            {
                try
                {
                    bdsKho.EndEdit();
                    bdsKho.ResetCurrentItem();
                    btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = false;
                    btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = grCN.Enabled = gridKho.Enabled = true;
                    this.khoTableAdapter.Update(this.ds_QLVT.Kho);
                    this.khoTableAdapter.Fill(this.ds_QLVT.Kho);
                    MessageBox.Show("Cập nhật kho thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi kho\n" + ex.Message, "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnExit.Enabled = grCN.Enabled = gridKho.Enabled = true;
            if (isCreating)
            {
                isCreating = false;
                //btnThem.Enabled =btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = grCN.Enabled = gridviewKho.Enabled = true;
                txtMaKho.Enabled = false;
                this.khoTableAdapter.Fill(this.ds_QLVT.Kho);
            }
            else
            {
                bdsKho.CancelEdit();
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ds_QLVT.EnforceConstraints = false;
            this.khoTableAdapter.Fill(this.ds_QLVT.Kho);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtMaKho_KeyPress(object sender, KeyPressEventArgs e)
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