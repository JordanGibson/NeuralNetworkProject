using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandboxUI.Misc
{
    public static class Utility
    {
        public static string GetFilePathFromUser(string typeName = "", string extension = "")
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(!(typeName == "" && extension == ""))
                ofd.Filter = string.Format("{0} | *.{1}", typeName, extension);
            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;
            return "";
        }
    }
}
