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
    public partial class FormInVT : DevExpress.XtraEditors.XtraForm
    {
        public FormInVT()
        {
            InitializeComponent();
        }

        private void FormInVT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet_DATA.SP_IN_DSVT' table. You can move, or remove it, as needed.
            this.sP_IN_DSVTTableAdapter.Fill(this.qLVT_DATHANGDataSet_DATA.SP_IN_DSVT);

        }
    }
}