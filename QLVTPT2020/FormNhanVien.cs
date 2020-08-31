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
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private static bool isCreating = false;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsQLVT);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
            // TODO: This line of code loads data into the 'ds_QLVT_DATHANG.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dsQLVT.PhieuXuat);
            // TODO: This line of code loads data into the 'ds_QLVT_DATHANG.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dsQLVT.PhieuNhap);
            // TODO: This line of code loads data into the 'ds_QLVT_DATHANG.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dsQLVT.DatHang);

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
            txtMaNV.Enabled = false;
            btnSave.Enabled = false;
            btnUndo.Enabled = false;
            grEdit.Enabled = false;
            this.txtLuong.Properties.MinValue = 4000000;
            this.txtLuong.Properties.MaxValue = decimal.MaxValue;

            this.txtTTX.Properties.MinValue = 0;
            this.txtTTX.Properties.MaxValue = 1;
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);

                    //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                }
            }
            else
            {
                Program.servername = cmbCN.SelectedValue.ToString();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.AddNew();
            btnUndo.Enabled = btnSave.Enabled = grEdit.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnCCN.Enabled = btnRefresh.Enabled = btnExit.Enabled = grCN.Enabled = false;
            isCreating = true;

            txtMaCN.EditValue = Program.mMACN;
            txtMaCN.Enabled = false;

            SqlDataReader myReader;
            String strlenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[SP_CREATE_MANV] SELECT	'Return Value' = @return_value";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Read();
            int maNV = myReader.GetInt32(0);
            myReader.Close();
            txtMaNV.Text = maNV.ToString();
            txtTTX.Text = "0";
            txtTTX.Enabled = false;
            txtNgaySinh.Properties.MaxValue = DateTime.Now;
            gridNV.Enabled = false;
            txtHo.Focus();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridNV.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnExit.Enabled = btnRefresh.Enabled = btnCCN.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (bdsPN.Count > 0)
                {
                    if (MessageBox.Show("Nhân viên đã lập phiếu nhập!\n Chuyển trạng thái nghĩ về 1(đã nghĩ việc) ?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtTTX.Text = "1";
                        bdsNV.EndEdit();
                        this.nhanVienTableAdapter.Update(this.dsQLVT.NhanVien);
                        this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
                        return;
                    }
                    else return;
                }
                if (bdsDH.Count > 0)
                {
                    if (MessageBox.Show("Nhân viên đã lập đơn đặt hàng!\n Chuyển trạng thái nghĩ về 1(đã nghĩ việc) ?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtTTX.Text = "1";
                        bdsNV.EndEdit();
                        this.nhanVienTableAdapter.Update(this.dsQLVT.NhanVien);
                        this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
                        return;
                    }
                    else return;
                }
                if (bdsPX.Count > 0)
                {
                    if (MessageBox.Show("Nhân viên đã lập phiếu xuất!\n Chuyển trạng thái nghĩ về 1(đã nghĩ việc) ?", "Notification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtTTX.Text = "1";
                        bdsNV.EndEdit();
                        this.nhanVienTableAdapter.Update(this.dsQLVT.NhanVien);
                        this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
                        return;
                    }
                    else return;
                }
                if (txtTTX.Text.ToString().Equals("1"))
                {
                    MessageBox.Show("Không thể chuyển vì nhân viên không còn làm ở chi nhánh");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsNV.RemoveCurrent();
                        this.nhanVienTableAdapter.Update(this.dsQLVT.NhanVien);
                        MessageBox.Show("Xóa thành công!", "Notification", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Lỗi xóa nhân viên\n" + exc.Message, "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isCreating)
            {
                if (txtHo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Họ nhân viên không được để trống");
                    txtHo.Focus();
                }
                else if (txtTen.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên nhân viên không được để trống");
                    txtTen.Focus();
                }
                else if (txtNgaySinh.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ngày sinh không được để trống");
                    txtNgaySinh.Focus();
                }
                else if (txtDiaChi.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Địa chỉ không được để trống");
                    txtDiaChi.Focus();
                }
                else if (txtLuong.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Lương không được để trống");
                    txtLuong.Focus();
                }
                else
                {
                    try
                    {
                        bdsNV.EndEdit();
                        bdsNV.ResetCurrentItem();
                        btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = false;

                        btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnCCN.Enabled = btnRefresh.Enabled = btnExit.Enabled = grCN.Enabled = gridNV.Enabled = true;
                        this.nhanVienTableAdapter.Update(this.dsQLVT.NhanVien);
                        this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
                        MessageBox.Show("Thêm nhân viên thành công!", "Notification", MessageBoxButtons.OK);
                        txtMaNV.Enabled = false;
                        isCreating = false;
                        gridNV.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi nhân viên\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                try
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRefresh.Enabled = btnCCN.Enabled = btnExit.Enabled = true;
                    gridNV.Enabled = true;
                    btnSave.Enabled = btnUndo.Enabled = grEdit.Enabled = false;
                    this.nhanVienTableAdapter.Update(this.dsQLVT.NhanVien);
                    this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Notification", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên\n" + ex.Message, "Notification", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUndo.Enabled = false;
            btnSave.Enabled = false;
            gridNV.Enabled = true;
            grEdit.Enabled = false;
            if (isCreating)
            {
                isCreating = false;
                btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnCCN.Enabled = btnRefresh.Enabled = btnExit.Enabled = grCN.Enabled = gridNV.Enabled = true;
                this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
            }
            else
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRefresh.Enabled = btnCCN.Enabled = btnExit.Enabled = true;
                bdsNV.CancelEdit();
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dsQLVT.EnforceConstraints = false;
            this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);
        }

        private void btnCCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTTX.Text.ToString().Equals("1"))
            {
                MessageBox.Show("Không thể chuyển vì nhân viên không còn làm ở chi nhánh");
                return;
            }
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Chuyển Chi Nhánh";
            args.Prompt = "Chi Nhánh";
            args.DefaultButtonIndex = 0;
            args.Showing += Args_Showing;
            ComboBoxEdit cmbCCN = new ComboBoxEdit();
            cmbCCN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            for (int i = 0; i < Program.bds_dspm.Count; i++)
            {
                dic.Add(((DataRowView)Program.bds_dspm[i])["TENSERVER"].ToString(), ((DataRowView)Program.bds_dspm[i])["TENCN"].ToString());
            }
            dic.Remove(Program.servername);
            cmbCCN.Properties.Items.AddRange(dic.Values);
            args.Editor = cmbCCN;

            try
            {
                var result = XtraInputBox.Show(args).ToString();
            }
            catch (Exception ex)
            {
                return;
            }

            if (cmbCCN.SelectedIndex == -1)
            {
                return;
            }

            string tenChiNhanhMoi = cmbCCN.SelectedItem.ToString();
            string maCNMoi = getMaCN(tenChiNhanhMoi);
            string backupSVName = Program.servername;
            Program.mlogin = Program.remotelogin;
            Program.password = Program.remotepassword;
            Program.servername = dic.FirstOrDefault(x => x.Value == cmbCCN.SelectedItem.ToString()).Key;
            Program.KetNoi();
            string lenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_CHUYEN_CHI_NHANH] " +
                        "@MANV = N'" + txtMaNV.Text.Trim() + "'," +
                        "@HO = N'" + txtHo.Text.Trim() + "'," +
                        "@TEN = N'" + txtTen.Text.Trim() + "'," +
                        "@DIACHI = N'" + txtDiaChi.Text.Trim() + "'," +
                        "@NGAYSINH = '" + txtNgaySinh.Text.Trim() + "'," +
                        "@LUONG = " + txtLuong.Text.Trim() + "," +
                        "@MACN = '" + maCNMoi.Trim() + "'" +
                        " SELECT  'Return Value' = @return_value";

            SqlDataReader myReader = Program.ExecSqlDataReader(lenh);

            if (myReader == null) return;

            myReader.Read();
            int returnValue = myReader.GetInt32(0);
            myReader.Close();

            if (returnValue == 0)
            {
                txtTTX.Text = "1";
                bdsNV.EndEdit();
                nhanVienTableAdapter.Update(dsQLVT.NhanVien);
                //dsQLVT.EnforceConstraints = false;
                //this.nhanVienTableAdapter.Fill(this.dsQLVT.NhanVien);

                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
                Program.servername = backupSVName;
                Program.KetNoi();
                MessageBox.Show("Chuyển chi nhánh nhân viên thành công");
            }
            else
                MessageBox.Show("Chuyển chi nhánh nhân viên thất bại");
        }

        private string getMaCN(string tenCN)
        {
            if (tenCN == null) return "";
            string[] maCN = tenCN.Split(' ');
            return "CN" + maCN[2];
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Icon = this.Icon;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTTX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormNhanVien_Leave(object sender, EventArgs e)
        {
            Program.servername = Program.serverNameDN;
            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
        }
    }
}