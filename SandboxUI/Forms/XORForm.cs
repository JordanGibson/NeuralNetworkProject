using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SandboxSolutions;
using ML_Library;

namespace SandboxUI.Forms
{
    public partial class XORForm : BaseSolutionForm
    {
        public XORForm() : base("XOR Simulation")
        {
            InitializeComponent();
        }

        private void btnNewNetwork_Click(object sender, EventArgs e)
        {
            NewNetworkDialog newNetworkDialog = new NewNetworkDialog(2, 1);
            Network = newNetworkDialog.ShowDialog();
        }
    }
}
