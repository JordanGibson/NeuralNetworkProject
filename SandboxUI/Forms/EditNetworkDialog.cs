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
using Newtonsoft.Json;
using SandboxUI.ProjectHelper;

namespace SandboxUI.Forms
{
    public partial class EditNetworkDialog : BaseNetworkConfigurationDialog
    {
        private NeuralNetwork ExistingNetwork;
        private int MaxDepth { get; set; } = 20;
        private int InputCount { get { return Network.InputCount; } }
        private int OutputCount { get; set; }

        public EditNetworkDialog(NeuralNetwork network, ProjectSettings projectSettings) : base("New Network Configuration", network, projectSettings)
        {
            InitializeComponent();
            ((DataGridViewComboBoxColumn)dgvLayerConfiguration.Columns[1]).DataSource = Enum.GetNames(typeof(ActivationMethod));

            ExistingNetwork = network.Copy();

            Network = network;
            if(Network.HasLayers)
                OutputCount = network.Structure.Last().NodeCount;

            UpdateViewFromConfig();
        }

        public new NeuralNetwork ShowDialog()
        {
            base.ShowDialog();
            return Network;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Network = ExistingNetwork;
            Close();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            string path = Misc.Utility.GetSaveFilePath("Network Configuration File", "ncf");
            Configuration configuration = NeuralNetwork.LoadFromConfiguration(GetConfigFromDgv()).Configuration;
            System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(configuration));
        }
    }
}
