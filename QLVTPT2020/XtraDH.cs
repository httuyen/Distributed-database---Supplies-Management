using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVTPT2020
{
    public partial class XtraDH : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraDH()
        {
            InitializeComponent();
            this.sP_IN_DSDH_CHUA_CO_PNTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_IN_DSDH_CHUA_CO_PNTableAdapter1.Fill(qlvT_DATHANGDataSet_DATA1.SP_IN_DSDH_CHUA_CO_PN);
        }

    }
}
