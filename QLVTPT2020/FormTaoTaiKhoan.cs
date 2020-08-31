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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private static DataTable dtMaNV;
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            Program.mlogin = Program.remotelogin;
            Program.password = Program.remotepassword;
            Program.KetNoi();

            //DataTable dtRole = new DataTable();
            //dtRole = Program.ExecSqlDataTable("SELECT * FROM V_DS_ROLE");
            ////BindingSource bdsRole = new BindingSource();
            //cmbNQ.DataSource = dtRole;
            //cmbNQ.DisplayMember = "name";
            //cmbNQ.ValueMember = "name";

            dtMaNV = new DataTable();
            dtMaNV = Program.ExecSqlDataTable("SELECT * FROM V_DSNVCHUACOLOGIN");
            //BindingSource bdsRole = new BindingSource();
            cmbMaNV.DataSource = dtMaNV;
            cmbMaNV.DisplayMember = "NAME";
            cmbMaNV.ValueMember = "MANV";
            cmbMaNV.SelectedIndex = -1;
            cmbNQ.SelectedIndex = -1;

            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;
            Program.KetNoi();

            if (Program.mGroup == "CONGTY")
            {
                cmbNQ.Items.Add("CONGTY");
                //cmbNQ.Enabled = false;
            }
            else
            {
                cmbNQ.Items.Add("CHINHANH");
                cmbNQ.Items.Add("USER");
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtUserName.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtPassword.Focus();
            }
            else if (txtCFPass.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtCFPass.Focus();
            }
            else if (cmbNQ.Text.Trim() == "")
            {
                MessageBox.Show("Nhóm quyên không được để trống. Kiểm tra lại !!!", "Thông báo");
            }
            else if (cmbMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên cần tạo tài khoản !!!", "Thông báo");
            }
            else if (txtPassword.Text.Trim().Equals(txtCFPass.Text.Trim()) == false)
            {
                MessageBox.Show("Mật khẩu phải trùng nhau. Kiểm tra lại !!!", "Thông báo");
            }
            else
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                SqlDataReader myReader1;
                String strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_TAOLOGIN]"
                    + "@LGNAME = N'" + txtUserName.Text.Trim() + "',"
                    + "@PASS = N'" + txtPassword.Text.Trim() + "',"
                    + "@USERNAME = N'" + cmbMaNV.SelectedValue.ToString().Trim() + "',"
                    + "@ROLE = N'" + cmbNQ.Text.ToString().Trim() + "'"
                    + "SELECT  'Return Value' = @return_value";

                myReader1 = Program.ExecSqlDataReader(strlenh);

                if (myReader1 == null) return;

                myReader1.Read();
                int value = myReader1.GetInt32(0);

                myReader1.Close();
                if (value == 1 || value == 2)
                {
                    MessageBox.Show("UserName bị trùng.");
                    return;
                }
                else if (value == 0)
                {
                    MessageBox.Show("Tạo thành công");
                    txtUserName.Text = txtPassword.Text = txtCFPass.Text = "";
                    cmbMaNV.SelectedIndex = cmbNQ.SelectedIndex = -1;

                    dtMaNV = new DataTable();
                    dtMaNV = Program.ExecSqlDataTable("SELECT * FROM V_DSNVCHUACOLOGIN");
                    //BindingSource bdsRole = new BindingSource();
                    cmbMaNV.DataSource = dtMaNV;
                    cmbMaNV.DisplayMember = "NAME";
                    cmbMaNV.ValueMember = "MANV";
                    cmbMaNV.SelectedIndex = -1;
                    cmbNQ.SelectedIndex = -1;
                    //this.v_DSNVCHUACOLOGINTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DSNVCHUACOLOGIN);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
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