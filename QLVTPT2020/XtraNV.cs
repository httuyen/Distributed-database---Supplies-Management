using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTPT2020
{
    public partial class XtraNV : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraNV()
        {
            InitializeComponent();
            this.sP_IN_DSNVTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_IN_DSNVTableAdapter1.Fill(qlvT_DATHANGDataSet_DATA1.SP_IN_DSNV);
        }

    }
}
