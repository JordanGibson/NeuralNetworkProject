using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using Bunifu.Framework;
using Bunifu;
using BunifuAnimatorNS;

namespace SandboxUI.Forms
{
    public partial class BaseDialogForm : Form
    {
        public BaseDialogForm()
        {
            InitializeComponent();
        }

        public BaseDialogForm(string formTitle)
        {
            InitializeComponent();

            lblWindowTitle.Text = formTitle;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
