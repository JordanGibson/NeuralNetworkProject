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
    public partial class DarkMessageBoxYesNo : DarkMessageBox
    {
        public DarkMessageBoxYesNo()
        {
            InitializeComponent();
        }

        public new DialogResult ShowDialog(string message, string title)
        {
            base.ShowDialog(message, title);
            return DialogResult;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
