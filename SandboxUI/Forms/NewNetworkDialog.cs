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

namespace SandboxUI.Forms
{
    public partial class NewNetworkDialog : BaseDialog
    {
        private NeuralNetwork Network;
        private int InputCount { get { return Network.InputCount; } }
        private int OutputCount { get; set; }

        public NewNetworkDialog(int inputCount, int outputCount) : base("New Network Configuration")
        {
            InitializeComponent();

            ((DataGridViewComboBoxColumn)dgvLayerConfiguration.Columns[1]).DataSource = Enum.GetNames(typeof(ActivationMethod));
            Network = new NeuralNetwork(inputCount);
            OutputCount = outputCount;

            UpdateViewFromConfig();
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
        private void UpdateViewFromConfig()
        {
            dgvLayerConfiguration.Rows.Clear();
            var config = Network.Configuration;
            for(int i = 0; i < config.LearningRates.Length; i++)
            {
                dgvLayerConfiguration.Rows.Add(i, config.ActivationMethods[i].ToString(), config.LearningRates[i], config.NodeCounts[i]);
            }
        }

        private void SwitchCellState(DataGridViewCell cell, bool isEnabled)
        {
            cell.ReadOnly = !isEnabled;
            if (isEnabled)
            {
                cell.Style.BackColor = cell.OwningColumn.DefaultCellStyle.BackColor;
                cell.Style.ForeColor = cell.OwningColumn.DefaultCellStyle.ForeColor;
            }
            else
            {
                cell.Style.BackColor = Color.FromArgb(45, 45, 45);
                cell.Style.ForeColor = Color.GhostWhite;
            }
        }

        private void btnCreateNetwork_Click(object sender, EventArgs e)
        {
            Network = NeuralNetwork.LoadFromConfiguration(GetConfigFromDgv());
            Close();
        }
        
        private void FillColumnWithValue(string value, int columnIndex)
        {
            dgvLayerConfiguration.ClearSelection();
            pnlContent.Focus();
            for (int i = 0; i < dgvLayerConfiguration.Rows.Count - 1; i++)
            {
                dgvLayerConfiguration.Rows[i].Cells[columnIndex].Value = value;
            }
        }

        private void lblActivationMethod_Click(object sender, EventArgs e)
        {
            GetComboBoxValueDialog cboDialog = new GetComboBoxValueDialog(typeof(ActivationMethod));
            string result = cboDialog.ShowDialog("Fill Activation Method").ToString();
            if (result.ToString() == "")
                return;
            FillColumnWithValue(result, 1);
        }

        private void lblLearningRate_Click(object sender, EventArgs e)
        {
            GetNUDValueDialog nudDialog = new GetNUDValueDialog(3);
            double result = nudDialog.ShowDialog("Fill Learning Rate");
            if (result == -1)
                return;
            FillColumnWithValue(result.ToString(), 2);
        }

        private void dgvLayerConfiguration_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvLayerConfiguration.Rows[dgvLayerConfiguration.RowCount - 1].Cells[0].Value = dgvLayerConfiguration.RowCount - 1;
        }
        
        private void dgvLayerConfiguration_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dgvLayerConfiguration.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += new KeyPressEventHandler(ValidateInputWithDecimal);
            }
            if(dgvLayerConfiguration.CurrentCell.ColumnIndex == 3)
            {
                e.Control.KeyPress += new KeyPressEventHandler(ValidateInputNoDecimal);
            }
        }

        private void ValidateInputWithDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar) && 
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void ValidateInputNoDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
