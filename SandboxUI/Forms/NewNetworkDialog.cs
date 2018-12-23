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

            ((DataGridViewComboBoxColumn)dgvLayerConfiguration.Columns[1]).DataSource = Enum.GetNames(typeof(ActivationMethod));
            Network = new NeuralNetwork(inputCount);
        }

        public new NeuralNetwork ShowDialog()
        {
            base.ShowDialog();
            return Network;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Network = null;
            Close();
        }
        
        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            string path = Misc.Utility.GetFilePathFromUser("Network Configuration File", "ncf");
            Network = NeuralNetwork.LoadFromConfigurationFile(path);
            UpdateViewFromConfig();
        }

        private Configuration GetConfigFromDgv()
        {
            Configuration config = new Configuration(dgvLayerConfiguration.Rows.Count - 1);
            config.InputCount = int.Parse(dgvLayerConfiguration.Rows[0].Cells[3].Value.ToString());

            for(int i = 1; i < dgvLayerConfiguration.Rows.Count - 1; i++)
            {
                config.ActivationMethods[i] = (ActivationMethod)((DataGridViewComboBoxCell)dgvLayerConfiguration.Rows[i].Cells[1]).Value;
                config.NodeCounts[i] = int.Parse(dgvLayerConfiguration.Rows[i].Cells[3].ToString());
                config.LearningRates[i] = double.Parse(dgvLayerConfiguration.Rows[i].Cells[2].ToString());
            }
            return config;
        }

        /// <summary>Updates the view of the current <see cref="NewNetworkDialog"/> add layer control panel
        /// from the current network configuration.</summary>
        private void UpdateViewFromConfig()
        {
            dgvLayerConfiguration.Rows.Clear();
            dgvLayerConfiguration.Rows.Add(0, ML_Library.ActivationMethod.Sigmoid, 0.3, 2);
            foreach(DataGridViewCell cell in dgvLayerConfiguration.Rows)
            {
                SwitchCellState(cell, false);
            }
            var config = Network.Configuration;
            for(int i = 0; i < config.NodeCounts.Length; i++)
            {
                dgvLayerConfiguration.Rows.Add(i, config.ActivationMethods[i], config.LearningRates[i], config.NodeCounts[i]);
            }
        }

        private void SwitchCellState(DataGridViewCell cell, bool enabled)
        {
            cell.ReadOnly = !enabled;
            if (enabled)
            {
                cell.Style.BackColor = cell.OwningColumn.DefaultCellStyle.BackColor;
                cell.Style.ForeColor = cell.OwningColumn.DefaultCellStyle.ForeColor;
            }
            else
            {
                cell.Style.BackColor = Color.LightGray;
                cell.Style.ForeColor = Color.DarkGray;
            }
        }

        private void btnCreateNetwork_Click(object sender, EventArgs e)
        {
            dgvLayerConfiguration.Rows.Add(0, ML_Library.ActivationMethod.Sigmoid, 0.3, 2);
            foreach (DataGridViewCell cell in dgvLayerConfiguration.Rows[0].Cells)
            {
                SwitchCellState(cell, false);
            }

            //Network = NeuralNetwork.LoadFromConfiguration(GetConfigFromDgv());
            //Close();
        }

        private void dgvLayerConfiguration_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvLayerConfiguration.Rows[e.RowIndex].Cells[0].Value = dgvLayerConfiguration.Rows.Count - 1;
        }
    }
}
