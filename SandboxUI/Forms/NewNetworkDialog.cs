using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML_Library;
using SandboxUI.Controls;

namespace SandboxUI.Forms
{
    public partial class NewNetworkDialog : BaseDialogForm
    {
        private NeuralNetwork Network;

        public NewNetworkDialog(int inputCount) : base("New Network Configuration")
        {
            InitializeComponent();
            Network = new NeuralNetwork(inputCount);

            flpAddLayerControls.Controls.Add(new AddLayerControl(inputCount) { Height = 80 });
        }

        public new NeuralNetwork ShowDialog()
        {
            base.ShowDialog();
            return Network;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private new void Close()
        {
            
        }
    }
}
