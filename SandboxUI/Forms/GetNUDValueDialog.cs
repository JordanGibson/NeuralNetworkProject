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
        public NumericUpDown NudValue { get { return nudValue; } }
        bool cancel = false;

        public GetNUDValueDialog(int decimalPlaces, int minimum = 0, int maximum = 10000)
        {
            InitializeComponent();
            nudValue.DecimalPlaces = decimalPlaces;
            nudValue.Minimum = minimum;
            nudValue.Maximum = maximum;
            nudValue.Increment = (decimal)(1 * Math.Pow(10, -decimalPlaces));
        }

        public double ShowDialog(string message)
        {
            lblMessage.Text = message;
            ShowDialog();
            return cancel ? throw new ApplicationException("User cancel was unhandled") : (double)nudValue.Value;
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
