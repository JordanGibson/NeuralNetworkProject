using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using Bunifu.Framework;
using Bunifu;
using BunifuAnimatorNS;
using ML_Library;

namespace SandboxUI.Forms
{
    public partial class BaseSolutionForm : Form
    {
        protected NeuralNetwork Network;
        
        public BaseSolutionForm()
        {
            InitializeComponent();
        }

        public BaseSolutionForm(string formTitle)
        {
            InitializeComponent();

            lblWindowTitle.Text = formTitle;
        }

        public virtual double GetCurrentError()
        {
            throw new NotImplementedException();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximizeWindow_Click(object sender, EventArgs e)
        {
            ToggleWindowState();
        }

        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlWindowBar_DoubleClick(object sender, EventArgs e)
        {
            ToggleWindowState();
        }

        private void ToggleWindowState()
        {
            WindowState = WindowState == FormWindowState.Maximized ?
                 FormWindowState.Normal :
                 FormWindowState.Maximized;
        }

        private void UpdateUIStatus()
        {
            bool isNetworkLoaded = Network != null;
            lblActivationMethod.Enabled = isNetworkLoaded;
            lblLearningRate.Enabled = isNetworkLoaded;
            btnEditNetwork.Enabled = isNetworkLoaded;
            btnClearNetwork.Enabled = isNetworkLoaded;

            if (isNetworkLoaded)
            {
                lblNetworkStructure.Text = "Structure: " + Network.InputCount + "-" + string.Join("-", Network.Structure.Select(l => l.NodeCount));
                if (Network.CurrentError == double.PositiveInfinity)
                    lblCurrentError.Text = "Current Error: N/A";
                else
                    lblCurrentError.Text = "Current Error: " + Network.CurrentError;
            }
            else
            {
                lblNetworkStructure.Text = "Structure: N/A";
                lblCurrentError.Text = "Current Error: N/A";
            }
        }

        private void btnNewNetwork_Click(object sender, EventArgs e)
        {
            NewNetworkDialog newNetworkDialog = new NewNetworkDialog(2, 1);
            Network = newNetworkDialog.ShowDialog();
            UpdateUIStatus();
        }

        private void btnEditNetwork_Click(object sender, EventArgs e)
        {

        }

        private void btnClearNetwork_Click(object sender, EventArgs e)
        {
            Network = null;
            UpdateUIStatus();
        }

        private void clickableLabels_MouseEnter(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.FromArgb(100, 20, 20);
            Cursor = Cursors.Hand;
        }

        private void clickableLabels_MouseLeave(object sender, EventArgs e)
        {
            var label = sender as Label;
            label.ForeColor = Color.White;
            Cursor = Cursors.Default;

        }

        private void lblLearningRate_Click(object sender, EventArgs e)
        {
            string message = string.Join(" - ", Network.LearningRates);
            DarkMessageBox darkMessageBox = new DarkMessageBox();
            darkMessageBox.ShowDialog(message, "Learning Rates");
        }

        private void lblActivationMethod_Click(object sender, EventArgs e)
        {
            string message = string.Join(" - ", Network.ActivationMethods);
            DarkMessageBox darkMessageBox = new DarkMessageBox();
            darkMessageBox.ShowDialog(message, "Learning Rates");
        }
    }
}
