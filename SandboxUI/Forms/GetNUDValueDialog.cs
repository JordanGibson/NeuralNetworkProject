using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxUI.Forms
{
    public partial class GetNUDValueDialog : BaseDialog
    {
        bool cancel = false;

        public GetNUDValueDialog(int decimalPlaces)
        {
            InitializeComponent();
        }

        public double ShowDialog(string message, Type dataSource = null)
        {
            lblMessage.Text = message;
            ShowDialog();
            return cancel ? -1 : (double)nudValue.Value;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }
    }
}
