using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ML_Library;

namespace SandboxUI.Controls
{
    public partial class AddLayerControl : UserControl
    {
        public AddLayerControl(int firstLayerCount = 0)
        {
            InitializeComponent();

            if (firstLayerCount != 0)
            {
                nudNodeCount.Value = firstLayerCount;
                nudNodeCount.Enabled = false;
            }

            cboActivationMethod.DataSource = Enum.GetNames(typeof(ActivationMethod));
        }
    }
}
