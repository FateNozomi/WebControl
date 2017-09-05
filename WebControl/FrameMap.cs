using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebControl
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class FrameMap : Form
    {
        uint rows = 6;
        uint columns = 36;

        public FrameMap()
        {
            InitializeComponent();
            wbFrameMap.AllowWebBrowserDrop = false;
            wbFrameMap.IsWebBrowserContextMenuEnabled = false;
            wbFrameMap.WebBrowserShortcutsEnabled = false;
            wbFrameMap.ObjectForScripting = this;
            constructResult();
        }

        // Empty Map for reference
        private void loadEmptyMap()
        {
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendLine("<html>");
            sb2.AppendLine("<body>");
            sb2.AppendLine("<table border='0' width=100% height=100%>");

            sb2.AppendLine("<tr height=1%>");
            for (uint i = 0; i < columns + 1; i++)
            {
                if (i == 0)
                {
                    sb2.AppendLine("<td width=1%></td>");
                }
                else
                {
                    sb2.AppendLine("<td align=center><font size=2>" + i + "</font></td>");
                }
            }
            sb2.AppendLine("</tr>");

            for (uint i = 0; i < rows; i++)
            {
                sb2.AppendLine("<tr>");
                for (uint j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        sb2.AppendLine("<td align=center><font size=2>" + (rows - i) + "</font></td>");
                    }
                    sb2.AppendLine("<td align=center width=" + (100 / columns) + "% ");
                    sb2.Append("bgcolor='lightgrey'>");
                    sb2.AppendLine("</td>");
                }
                sb2.AppendLine("</tr>");
            }
            sb2.AppendLine("</table>");
            sb2.AppendLine("</body>");
            sb2.AppendLine("</html>");
            wbFrameMap.DocumentText = sb2.ToString();
            wbFrameMap.Document.Write(sb2.ToString());
        }

        private void constructResult(string text = "", string mag = "")
        {
            uint status = 0;
            string rc = "0"; // Reject Code

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html>");
            sb.AppendLine("<body>");
            sb.AppendLine("<table border='0' width=100% height=100%>");

            sb.AppendLine("<tr height=1%>");
            for (uint i = 0; i < columns + 1; i++)
            {
                if (i == 0)
                {
                    sb.AppendLine("<td width=1%></td>");
                }
                else
                {
                    sb.AppendLine("<td align=center><font size=2>" + i + "</font></td>");
                }
            }
            sb.AppendLine("</tr>");

            for (uint i = 0; i < rows; i++)
            {
                sb.AppendLine("<tr>");
                for (uint j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        sb.AppendLine("<td align=center><font size=2>" + (rows - i) + "</font></td>");
                    }
                    sb.Append("<td align=center width=" + (100 / columns) + "% ");
                    int[] unitCoord = GetUnitCoord(i, j);
                    sb.Append("title='Unit #" + unitCoord[1] + "," + unitCoord[0] + "' ");
                    // Attach onclick event
                    sb.Append("onclick=\"window.external.Test('" + "Unit #" + unitCoord[1] + "," + unitCoord[0] + "')\" ");
                    if (status == 0)
                    {
                        sb.Append("bgcolor='green'>" + rc.ToString());
                    }
                    else
                    {
                        sb.Append("bgcolor='red'>" + rc.ToString());
                    }

                    sb.AppendLine("</td>");
                }
                sb.AppendLine("</tr>");
            }
            sb.AppendLine("</table>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            wbFrameMap.DocumentText = sb.ToString();
        }

        private int[] GetUnitCoord(uint r, uint c)
        {
            int x = (int)c;
            int y = (int)(rows - r);
            y--;

            int[] unit = new int[2];

            // Start from Index of 1 instead of 0
            unit[0] = ++y;
            unit[1] = ++x;

            return unit;
        }

        public void Test(string message)
        {
            MessageBox.Show(message, "Client Code");
        }
    }
}
