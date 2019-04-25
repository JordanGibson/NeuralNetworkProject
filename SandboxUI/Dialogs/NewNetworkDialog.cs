﻿using System;
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


namespace SandboxUI.Dialogs
{
    public partial class NewNetworkDialog : BaseNetworkConfigurationDialog
    {
        public int MaxDepth { get; set; } = 20;
        public int OutputCount { get; set; }

        public NewNetworkDialog(ProjectSettings projectSettings) : base("New Network Configuration", projectSettings)
        {
            InitializeComponent();

            ((DataGridViewComboBoxColumn)dgvLayerConfiguration.Columns[1]).DataSource = Enum.GetNames(typeof(ActivationMethod));
            Network = new NeuralNetwork(projectSettings.InputCount);
            OutputCount = projectSettings.OutputCount;

            UpdateViewFromConfig();
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            Network = null;
            Close();
        }

        public void btnCreateNetwork_Click(object sender, EventArgs e)
        {
            Network = NeuralNetwork.LoadFromConfiguration(GetConfigFromDgv());
            Close();
        }
    }
}
