using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SandboxUI.Misc
{
    //Standard color table for Dark Theme
    public class CustomToolStripColorTable : ProfessionalColorTable
    {
        public override Color ButtonSelectedHighlight => ButtonSelectedGradientMiddle;
        public override Color ButtonSelectedHighlightBorder => ButtonSelectedBorder;
        public override Color ButtonPressedHighlight => ButtonPressedGradientMiddle;
        public override Color ButtonPressedHighlightBorder => ButtonPressedBorder;
        public override Color ButtonCheckedHighlight => ButtonCheckedGradientMiddle;
        public override Color ButtonCheckedHighlightBorder => ButtonSelectedBorder;
        public override Color ButtonPressedBorder => ButtonSelectedBorder;
        public override Color ButtonSelectedBorder => Color.FromArgb(98, 98, 98);
        public override Color ButtonCheckedGradientBegin => Color.FromArgb(144, 144, 144);
        public override Color ButtonCheckedGradientMiddle => Color.FromArgb(170, 170, 170);
        public override Color ButtonCheckedGradientEnd => Color.FromArgb(170, 170, 170);
        public override Color ButtonSelectedGradientBegin => Color.FromArgb(170, 170, 170);
        public override Color ButtonSelectedGradientMiddle => Color.FromArgb(170, 170, 170);
        public override Color ButtonSelectedGradientEnd => Color.FromArgb(170, 170, 170);
        public override Color ButtonPressedGradientBegin => Color.FromArgb(170, 170, 170);
        public override Color ButtonPressedGradientMiddle => Color.FromArgb(170, 170, 170);
        public override Color ButtonPressedGradientEnd => Color.FromArgb(170, 170, 170);
        public override Color CheckBackground => Color.FromArgb(173, 173, 173);
        public override Color CheckSelectedBackground => Color.FromArgb(173, 173, 173);
        public override Color CheckPressedBackground => Color.FromArgb(140, 140, 140);
        public override Color GripDark => Color.FromArgb(22, 22, 22);
        public override Color GripLight => Color.FromArgb(83, 83, 83);
        public override Color ImageMarginGradientBegin => Color.FromArgb(85, 85, 85);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(68, 68, 68);
        public override Color ImageMarginGradientEnd => Color.FromArgb(68, 68, 68);
        public override Color ImageMarginRevealedGradientBegin => Color.FromArgb(68, 68, 68);
        public override Color ImageMarginRevealedGradientMiddle => Color.FromArgb(68, 68, 68);
        public override Color ImageMarginRevealedGradientEnd => Color.FromArgb(68, 68, 68);
        public override Color MenuStripGradientBegin => Color.FromArgb(138, 138, 138);
        public override Color MenuStripGradientEnd => Color.FromArgb(103, 103, 103);
        public override Color MenuItemSelected => Color.FromArgb(170, 170, 170);
        public override Color MenuItemBorder => Color.FromArgb(170, 170, 170);
        public override Color MenuBorder => Color.FromArgb(22, 22, 22);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(170, 170, 170);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(170, 170, 170);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(125, 125, 125);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(125, 125, 125);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(125, 125, 125);
        public override Color SeparatorDark => Color.FromArgb(22, 22, 22);
        public override Color SeparatorLight => Color.FromArgb(62, 62, 62);
        public override Color ToolStripBorder => Color.FromArgb(22, 22, 22);
        public override Color ToolStripDropDownBackground => Color.FromArgb(60, 60, 60);
        public override Color ToolStripGradientBegin => Color.FromName("DimGray");
        public override Color ToolStripGradientMiddle => Color.FromArgb(89, 89, 89);
        public override Color ToolStripGradientEnd => Color.FromArgb(88, 88, 88);
        public override Color ToolStripContentPanelGradientBegin => Color.FromArgb(68, 68, 68);
        public override Color ToolStripContentPanelGradientEnd => Color.FromArgb(68, 68, 68);
        public override Color ToolStripPanelGradientBegin => Color.FromArgb(103, 103, 103);
        public override Color ToolStripPanelGradientEnd => Color.FromArgb(103, 103, 103);
    }
}
