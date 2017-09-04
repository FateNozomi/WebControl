namespace WebControl
{
    partial class RevampedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpXAxis = new System.Windows.Forms.FlowLayoutPanel();
            this.splcTop = new System.Windows.Forms.SplitContainer();
            this.flpYAxis = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpGrid = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splcTop)).BeginInit();
            this.splcTop.Panel2.SuspendLayout();
            this.splcTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpXAxis
            // 
            this.flpXAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpXAxis.Location = new System.Drawing.Point(0, 0);
            this.flpXAxis.Name = "flpXAxis";
            this.flpXAxis.Size = new System.Drawing.Size(1114, 48);
            this.flpXAxis.TabIndex = 0;
            // 
            // splcTop
            // 
            this.splcTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splcTop.Location = new System.Drawing.Point(0, 0);
            this.splcTop.Name = "splcTop";
            // 
            // splcTop.Panel2
            // 
            this.splcTop.Panel2.Controls.Add(this.flpXAxis);
            this.splcTop.Size = new System.Drawing.Size(1182, 48);
            this.splcTop.SplitterDistance = 64;
            this.splcTop.TabIndex = 1;
            // 
            // flpYAxis
            // 
            this.flpYAxis.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpYAxis.Location = new System.Drawing.Point(0, 48);
            this.flpYAxis.Name = "flpYAxis";
            this.flpYAxis.Size = new System.Drawing.Size(58, 547);
            this.flpYAxis.TabIndex = 2;
            // 
            // tlpGrid
            // 
            this.tlpGrid.ColumnCount = 1;
            this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpGrid.Location = new System.Drawing.Point(58, 48);
            this.tlpGrid.Name = "tlpGrid";
            this.tlpGrid.RowCount = 1;
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGrid.Size = new System.Drawing.Size(1124, 547);
            this.tlpGrid.TabIndex = 3;
            // 
            // RevampedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 595);
            this.Controls.Add(this.tlpGrid);
            this.Controls.Add(this.flpYAxis);
            this.Controls.Add(this.splcTop);
            this.Name = "RevampedForm";
            this.Text = "RevampedForm";
            this.splcTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcTop)).EndInit();
            this.splcTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpXAxis;
        private System.Windows.Forms.SplitContainer splcTop;
        private System.Windows.Forms.FlowLayoutPanel flpYAxis;
        private System.Windows.Forms.TableLayoutPanel tlpGrid;
    }
}