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
    public partial class FormInBangKeNX : DevExpress.XtraEditors.XtraForm
    {
        public FormInBangKeNX()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormInBangKeNX_Load(object sender, EventArgs e)
        {
            dateTimeStart.Format = DateTimePickerFormat.Custom;
            dateTimeStart.CustomFormat = "MM, yyyy";
            dateTimeStart.ShowUpDown = true;

            dateTimeEnd.Format = DateTimePickerFormat.Custom;
            dateTimeEnd.CustomFormat = "MM, yyyy";
            dateTimeEnd.ShowUpDown = true;
        }
    }
}