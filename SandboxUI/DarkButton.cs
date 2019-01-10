using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxUI
{
    public partial class DarkButton : Button
    {
        public DarkButton()
        {
            InitializeComponent();
            BackColor = SystemColors.WindowFrame;
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            UseVisualStyleBackColor = true;
        }
    }
}
