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
    public partial class RevampedForm : Form
    {
        int rows = 6;
        int columns = 36;

        public RevampedForm()
        {
            InitializeComponent();

            SetupControls();
            //constructResult();

        }

        private void SetupControls()
        {
            // Get the percentage to set as the row width and column width.
            float rowPercent = (float)(100.0 / (rows + 1));
            float colPercent = (float)(100.0 / (columns + 1));
            tlpGrid.RowCount = rows + 1;
            tlpGrid.ColumnCount = columns + 1;
            tlpGrid.RowStyles.Clear();
            tlpGrid.ColumnStyles.Clear();

            // Add a row style for the row header.
            tlpGrid.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            // Some issue with the program, had to have differences in code between rows and columns.
            // Add a column style for the column header.
            //tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            // Make each row a percentage of the number of rows + header.
            for (int i = 0; i < rows; i++)
            {
                tlpGrid.RowStyles.Add(new RowStyle(SizeType.Percent, rowPercent));
            }

            // Make each column a percentage of the number of columns + header.
            for (int i = 0; i <= columns; i++)
            {
                tlpGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colPercent));
            }

            int status = 0;
            string rejectCode = "0"; // Reject Code

            for (int row = 0; row <= rows; row++)
            {
                for (int column = 0; column <= columns; column++)
                {
                    Label label;
                    if (row == 0 && column == 0)
                    {
                        // Do nothing.
                        continue;
                    }
                    if (row == 0)
                    {
                        label = new Label
                        {
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Padding = new Padding(0),
                            Margin = new Padding(0),
                            Text = column.ToString(),
                        };
                    }
                    else if (column == 0)
                    {
                        label = new Label
                        {
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Padding = new Padding(0),
                            Margin = new Padding(0),
                            Text = row.ToString(),
                        };
                    }
                    else
                    {
                        label = new Label
                        {
                            BorderStyle = BorderStyle.FixedSingle,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Padding = new Padding(0),
                            Margin = new Padding(0),
                            Text = rejectCode,
                            BackColor = status == 0 ? Color.Green : Color.Red
                        };
                    }
                    tlpGrid.Controls.Add(label, column, row);
                }
            }
        }

        //private void constructResult()
        //{
        //    int status = 0;
        //    string rc = "0"; // Reject Code

        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("<html>");
        //    sb.AppendLine("<body>");
        //    sb.AppendLine("<table border='0' width=100% height=100%>");

        //    sb.AppendLine("<tr height=1%>");
        //    for (int i = 0; i < columns + 1; i++)
        //    {
        //        if (i == 0)
        //        {
        //            sb.AppendLine("<td width=1%></td>");
        //        }
        //        else
        //        {
        //            sb.AppendLine("<td align=center><font size=2>" + i + "</font></td>");
        //        }
        //    }
        //    sb.AppendLine("</tr>");

        //    for (int i = 0; i < rows; i++)
        //    {
        //        sb.AppendLine("<tr>");
        //        for (int j = 0; j < columns; j++)
        //        {
        //            if (j == 0)
        //            {
        //                sb.AppendLine("<td align=center><font size=2>" + (rows - i) + "</font></td>");
        //            }
        //            sb.AppendLine("<td align=center width=" + (100 / columns) + "% ");
        //            int[] unitCoord = GetUnitCoord(i, j);
        //            sb.Append("title='Unit #" + unitCoord[1] + "," + unitCoord[0] + "' ");
        //            if (status == 0)
        //            {
        //                sb.Append("bgcolor='green'>" + rc);
        //            }
        //            else
        //            {
        //                sb.Append("bgcolor='red'>" + rc);
        //            }

        //            sb.AppendLine("</td>");
        //        }
        //        sb.AppendLine("</tr>");
        //    }
        //    sb.AppendLine("</table>");
        //    sb.AppendLine("</body>");
        //    sb.AppendLine("</html>");
        //    wbMap.DocumentText = sb.ToString();
        //}

        //private int[] GetUnitCoord(int r, int c)
        //{
        //    int x = c;
        //    int y = (rows - r);
        //    y--;

        //    int[] unit = new int[2];

        //    // Start from Index of 1 instead of 0
        //    unit[0] = ++y;
        //    unit[1] = ++x;

        //    return unit;
        //}
    }
}
