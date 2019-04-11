using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxUI.Forms
{
    public partial class LaunchForm : Dialogs.BaseDialog
    {
        public LaunchForm()
        {
            InitializeComponent();
        }

        private void LaunchForm_Load(object sender, EventArgs e)
        {
            txtXor.SelectAll();
            txtXor.SelectionAlignment = HorizontalAlignment.Center;
            txtXor.DeselectAll();
            txtMnist.SelectAll();
            txtMnist.SelectionAlignment = HorizontalAlignment.Center;
            txtMnist.DeselectAll();
            BringAllToFront();
        }

        private void BringAllToFront()
        {
            pbxMnist.BringToFront();
            pbxXor.BringToFront();
            txtMnist.BringToFront();
            txtXor.BringToFront();
        }

        private void btnLaunchXOR_Click(object sender, EventArgs e)
        {
            XORForm form = new XORForm();
            form.Show();
        }

        private void btnMnistLaunch_Click(object sender, EventArgs e)
        {
            MNISTForm form = new MNISTForm();
            form.Show();
        }
    }
}
