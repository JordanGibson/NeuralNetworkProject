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
using SandboxUI.ProjectHelper;
using SandboxUI.Dialogs;

namespace SandboxUI.Dialogs
{
    public partial class BaseNetworkConfigurationDialog : BaseDialog
    {
        protected NeuralNetwork Network;
        protected ProjectSettings projectSettings;

        public Configuration previousConfiguration;
        public int MaxDepth { get; set; } = 20;
        public int OutputCount { get; set; } = -1;

        public BaseNetworkConfigurationDialog()
        {
            InitializeComponent();
        }

        public BaseNetworkConfigurationDialog(string formTitle, ProjectSettings projectSettings, NeuralNetwork network = null) : base(formTitle)
        {
            InitializeComponent();

            ((DataGridViewComboBoxColumn)dgvLayerConfiguration.Columns[1]).DataSource = Enum.GetNames(typeof(ActivationMethod));
            Network = Network == null ? new NeuralNetwork(projectSettings.InputCount) : network;
            this.projectSettings = projectSettings;
            OutputCount = projectSettings.OutputCount;

            UpdateViewFromConfig();
        }

        public new NeuralNetwork ShowDialog()
        {
            base.ShowDialog();
            return Network;
        }
        
        public void btnLoadConfig_Click(object sender, EventArgs e)
        {
            Configuration newConfiguration = GetConfigFromDgv();
            //if (previousConfiguration.Equals(newConfiguration) && !Configuration.IsBlank(previousConfiguration))
            //{
            //    DarkMessageBoxYesNo darkMessageBox = new DarkMessageBoxYesNo();
            //    DialogResult dialogResult = darkMessageBox.ShowDialog("Are you sure you want to load a new network configuration?", "Confirm");
            //    if (dialogResult == DialogResult.No)
            //        return;
            //    previousConfiguration = newConfiguration;
            //}
            string path = Misc.Utility.GetOpenFilePath("Network Configuration File", "ncf");
            if (path == "")
                return;
            NeuralNetwork network = NeuralNetwork.LoadFromConfigurationFile(path);

            if (network.InputCount != projectSettings.InputCount || network.Configuration.NodeCounts.Last() != projectSettings.OutputCount)
            {
                DarkMessageBox messageBox = new DarkMessageBox();
                messageBox.ShowDialog("The network loaded is incompatable with the project type " + projectSettings.Name + ". " +
                    "\nProject Configuration:\nInput Count: " + projectSettings.InputCount + "  Output Count: " + projectSettings.OutputCount +
                    "\nLoaded Configuration:\nInput Count: " + network.InputCount + "  Output Count: " + network.Configuration.NodeCounts.Last(), "Load Failed - Configuration Mismatch");
                return;
            }
            Network = network;
            UpdateViewFromConfig();
        }

        protected Configuration GetConfigFromDgv()
        {
            Configuration config = new Configuration(dgvLayerConfiguration.Rows.Count - 1);
            config.InputCount = Network.InputCount;

            for(int i = 0; i < dgvLayerConfiguration.Rows.Count - 1; i++)
            {
                config.ActivationMethods[i] = (ActivationMethod)Enum.Parse(typeof(ActivationMethod), ((DataGridViewComboBoxCell)dgvLayerConfiguration.Rows[i].Cells[1]).Value.ToString());
                config.NodeCounts[i] = int.Parse(dgvLayerConfiguration.Rows[i].Cells[3].Value.ToString());
                config.LearningRates[i] = double.Parse(dgvLayerConfiguration.Rows[i].Cells[2].Value.ToString());
            }
            return config;
        }

        /// <summary>Updates the view of the current <see cref="NewNetworkDialog"/> add layer control panel
        /// from the current network configuration.</summary>
        protected void UpdateViewFromConfig()
        {
            dgvLayerConfiguration.Rows.Clear();
            var config = Network.Configuration;
            for(int i = 0; i < config.LearningRates.Length; i++)
            {
                dgvLayerConfiguration.Rows.Add(i, config.ActivationMethods[i].ToString(), config.LearningRates[i], config.NodeCounts[i]);
            }
            RenumberLayers();
            previousConfiguration = GetConfigFromDgv().Copy();
        }

        public void btnCreateNetwork_Click(object sender, EventArgs e)
        {
            Configuration config = GetConfigFromDgv();
            if(config.NodeCounts.Last() != projectSettings.OutputCount)
            {
                DarkMessageBoxYesNo darkMessageBox = new DarkMessageBoxYesNo();
                var dr = darkMessageBox.ShowDialog("This network does not have the correct output count for the project type " + projectSettings.Name + ". The correct output count is " + projectSettings.OutputCount + ". Would you like to add another layer to the end of the network with the configuration:\nActivation Method: " + config.ActivationMethods.Last() + " Learning Rate: " + config.LearningRates.Last() + " Node Count: " + projectSettings.OutputCount, "Incorrect Output Count");
                if (dr == DialogResult.Yes)
                {
                    var lastRow = dgvLayerConfiguration.Rows[dgvLayerConfiguration.RowCount - 2];
                    dgvLayerConfiguration.Rows.Add(dgvLayerConfiguration.RowCount, lastRow.Cells[1].Value, lastRow.Cells[2].Value, projectSettings.OutputCount);
                    RenumberLayers();
                }
                else
                    return;
            }
            config = GetConfigFromDgv();
            Network = NeuralNetwork.LoadFromConfiguration(config);
            Close();
        }
        
        public void FillColumnWithValue(string value, int columnIndex)
        {
            dgvLayerConfiguration.ClearSelection();
            pnlContent.Focus();
            for (int i = 0; i < dgvLayerConfiguration.Rows.Count - 1; i++)
            {
                dgvLayerConfiguration.Rows[i].Cells[columnIndex].Value = value;
            }
        }

        public void lblActivationMethod_Click(object sender, EventArgs e)
        {
            GetComboBoxValueDialog cboDialog = new GetComboBoxValueDialog(typeof(ActivationMethod));
            object result = cboDialog.ShowDialog("Fill Activation Method");
            if (result == null)
                return;
            FillColumnWithValue(result.ToString(), 1);
        }

        public void lblLearningRate_Click(object sender, EventArgs e)
        {
            GetNUDValueDialog nudDialog = new GetNUDValueDialog(3);
            double result = -1;
            try { result = nudDialog.ShowDialog("Fill Learning Rate"); } catch (ApplicationException) { }
            if (result == -1)
                return;
            FillColumnWithValue(result.ToString(), 2);
        }

        public void dgvLayerConfiguration_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int layerCount = dgvLayerConfiguration.RowCount - 1;
            dgvLayerConfiguration.Rows[e.RowIndex].Cells[0].Value = layerCount;
        }
        
        public void dgvLayerConfiguration_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ValidateInputWithDecimal);
            e.Control.KeyPress -= new KeyPressEventHandler(ValidateInputNoDecimal);
            if (dgvLayerConfiguration.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += new KeyPressEventHandler(ValidateInputWithDecimal);
            }
            if (dgvLayerConfiguration.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += new KeyPressEventHandler(ValidateInputNoDecimal);
            }
        }

        protected void ValidateInputWithDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar) && 
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        protected void ValidateInputNoDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void dgvLayerConfiguration_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell == null || e.StateChanged != DataGridViewElementStates.Selected)
                return;
            
            if(e.Cell.ColumnIndex == 0)
            {
                e.Cell.Selected = false;
                dgvLayerConfiguration.Rows[e.Cell.RowIndex].Cells[e.Cell.ColumnIndex + 1].Selected = true;
            }
        }

        protected void RenumberLayers()
        {
            for(int i = 0; i < dgvLayerConfiguration.Rows.Count; i++)
            {
                var row = dgvLayerConfiguration.Rows[i];
                row.Cells[0].Value = i;
            }
        }

        public void lblLayerNumber_Click(object sender, EventArgs e)
        {
            int rowCount = dgvLayerConfiguration.Rows.Count;
            GetNUDValueDialog nudDialog = new GetNUDValueDialog(0, 1 - rowCount, MaxDepth - rowCount);
            int rowsToAdd = 0;
            try { rowsToAdd = (int)nudDialog.ShowDialog("Add / Remove Layers"); } catch(ApplicationException) { }
            if (rowsToAdd + rowCount > MaxDepth)
            {
                MessageBox.Show("You cannot have more than 20 layers in a network!");
                rowsToAdd = MaxDepth - rowCount;
            }
            if(rowsToAdd + rowCount < 0)
            {
                MessageBox.Show(string.Format("You cannot have {0} layers in a network", rowCount + rowsToAdd));
                rowsToAdd = -rowCount;
            }
            for (int i = 0; i < Math.Abs(rowsToAdd); i++)
            {
                if (rowsToAdd < 0)
                    dgvLayerConfiguration.Rows.RemoveAt(rowCount - i - 2);
                if (rowsToAdd > 0)
                    dgvLayerConfiguration.Rows.Insert(dgvLayerConfiguration.RowCount - 1, new DataGridViewRow());
            }
            RenumberLayers();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            dgvLayerConfiguration.Rows.Clear();
            dgvLayerConfiguration.Refresh();
        }
    }
}
