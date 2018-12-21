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
    }
}
