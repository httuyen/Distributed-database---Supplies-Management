using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTPT2020
{
    public partial class XtraBKet : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraBKet(string startDay, string endDay, string nhomQuyen, string loaiPhieu)
        {
            InitializeComponent();
            if (loaiPhieu.Equals("PHIEUNHAP"))
            {
                lblLoaiPhieu.Text = "PHIẾU NHẬP";
            }
            else
            {
                lblLoaiPhieu.Text = "PHIẾU XUẤT";
            }
            this.sP_BANGKECTTableAdapter2.Connection.ConnectionString = Program.connstr;
            this.sP_BANGKECTTableAdapter2.Fill(qlvT_DATHANGDataSet_DATA1.SP_BANGKECT, Convert.ToDateTime(startDay), Convert.ToDateTime(endDay), nhomQuyen, loaiPhieu);
        }

    }
}