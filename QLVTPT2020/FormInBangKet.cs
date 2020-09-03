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
    public partial class FormInBangKet : DevExpress.XtraEditors.XtraForm
    {
        private static string startDay = "";
        private static string endDay = "";
        private static string loaiPhieu = "";
        public FormInBangKet()
        {
            InitializeComponent();
        }

        private void FormInBangKet_Load(object sender, EventArgs e)
        {
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "MM, yyyy";
            dateTimeStart.ShowUpDown = true;

            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = "MM, yyyy";
            dateTimeEnd.ShowUpDown = true;
            dateTimeEnd.MaxDate = DateTime.Now;

            cmbLoaiPhieu.Items.Add("Phiếu nhập");
            cmbLoaiPhieu.Items.Add("Phiếu Xuất");
        }

        private void cmbLoaiPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiPhieu.SelectedIndex == -1)
            {
                return;
            }else if(cmbLoaiPhieu.SelectedIndex == 0)
            {
                loaiPhieu = "PHIEUNHAP";
            }else
            {
                loaiPhieu = "PHIEUXUAT";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dateTimeStart.Value.ToLocalTime() > dateTimeEnd.Value.ToLocalTime())
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Notification");
                return;
            }
            if(cmbLoaiPhieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phiếu cần truy xuất!","Notification");
                return;
            }
            XtraBKet xtraBangKet = new XtraBKet(dateTimeStart.Value.ToShortDateString() , dateTimeEnd.Value.ToShortDateString(), Program.mGroup, loaiPhieu);
            xtraBangKet.CreateDocument();
            documentViewer1.DocumentSource = xtraBangKet;
        }
    }
}