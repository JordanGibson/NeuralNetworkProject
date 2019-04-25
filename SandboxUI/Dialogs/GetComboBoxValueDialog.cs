using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxUI.Dialogs
{
    public partial class GetComboBoxValueDialog : BaseDialog
    {
        public GetComboBoxValueDialog(Type dataSource)
        {
            InitializeComponent();
            cboValue.DataSource = Enum.GetNames(dataSource);
        }

        public object ShowDialog(string message)
        {
            lblMessage.Text = message;
            ShowDialog();
            return cboValue.SelectedValue;
        }

        public void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            cboValue.SelectedIndex = -1;
            Close();
        }
    }
}
