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

namespace SandboxUI.Dialogs
{
    public partial class EditNetworkDialog : BaseNetworkConfigurationDialog
    {
        public NeuralNetwork ExistingNetwork;
        public int MaxDepth { get; set; } = 20;
        public int InputCount { get { return Network.InputCount; } }
        public int OutputCount { get; set; }

        public EditNetworkDialog(NeuralNetwork network, ProjectSettings projectSettings) : base("Edit Network Configuration", projectSettings, network)
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

        public void btnCancel_Click(object sender, EventArgs e)
        {
            Network = ExistingNetwork;
            Close();
        }

        public void btnSaveConfig_Click(object sender, EventArgs e)
        {
            string path = Misc.Utility.GetSaveFilePath("Network Configuration File", "ncf");
            Configuration configuration = NeuralNetwork.LoadFromConfiguration(GetConfigFromDgv()).Configuration;
            System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(configuration));
        }
    }
}
