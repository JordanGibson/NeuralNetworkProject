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
        private NeuralNetwork ExistingNetwork;
        private int InputCount { get { return Network.InputCount; } }

        public EditNetworkDialog(NeuralNetwork network, ProjectSettings projectSettings) : base("New Network Configuration", projectSettings, network)
        {
            InitializeComponent();
            ((DataGridViewComboBoxColumn)dgvLayerConfiguration.Columns[1]).DataSource = Enum.GetNames(typeof(ActivationMethod));

            ExistingNetwork = network.Copy();

            Network = network;
            
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

        protected override void btnCreateNetwork_Click(object sender, EventArgs e)
        {
            Configuration config = GetConfigFromDgv();
            Configuration oldConfig = ExistingNetwork.Configuration;

            if (config.ActivationMethods.SequenceEqual(oldConfig.ActivationMethods) || config.NodeCounts.SequenceEqual(oldConfig.NodeCounts))
            {
                DarkMessageBoxYesNo darkMessageBox = new DarkMessageBoxYesNo();
                var result = darkMessageBox.ShowDialog("The changes made to this network configuration will require a new network be made and all training progress will be lost. Would you like to continue and create a new network?", "New Network Required");
                if (result == DialogResult.Yes)
                {
                    Network = NeuralNetwork.LoadFromConfiguration(config);
                    return;
                }
            }
            if(config.LearningRates != oldConfig.LearningRates)
            {
                for (int i = 0; i < Network.Structure.Count; i++)
                    Network.Structure[i].LearningRate = config.LearningRates[i];
            }
        }
    }
}
