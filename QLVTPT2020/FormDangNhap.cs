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
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DSPM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            //this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANGDataSet_DSPM.V_DS_PHANMANH);
            string chuoiketnoi = "Data Source=TUYEN-PC\\SERVER;Initial Catalog=QLVT_DATHANG;Integrated Security=True";
            Program.conn.ConnectionString = chuoiketnoi;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DS_PHANMANH");
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = dt;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = -1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Login name không được trống", "", MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            else
            {
                Program.mlogin = txtUsername.Text;
                Program.password = txtPassword.Text;
                if (Program.KetNoi() == 0) return;

                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.serverNameDN = cmbChiNhanh.SelectedValue.ToString();
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();


                Program.username = Program.myReader.GetString(0);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
                FormMain frmMain = new FormMain();
                frmMain.statusMaNV.Text = "Mã nhân viên : " + Program.username;
                frmMain.statusTenNV.Text = "Họ và tên : " + Program.mHoten;
                frmMain.statusNhomQuyen.Text = "Nhóm quyền : " + Program.mGroup;
                frmMain.Show();
                this.Hide();
                //MessageBox.Show("Nhan vien - Nhom : " + Program.mHoten + " - " + Program.mGroup, "", MessageBoxButtons.OK);
            }
        }
        private void cmbChiNhanh_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();

            }
            catch (Exception) { };
        }

        private void FormDangNhap_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}