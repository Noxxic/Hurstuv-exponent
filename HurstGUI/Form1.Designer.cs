namespace HurstGUI
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonVypocti = new System.Windows.Forms.Button();
            this.chartHurst = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Hurst = new System.Windows.Forms.Label();
            this.lbl_rovnice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartHurst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVypocti
            // 
            this.buttonVypocti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonVypocti.Location = new System.Drawing.Point(0, 0);
            this.buttonVypocti.Name = "buttonVypocti";
            this.buttonVypocti.Size = new System.Drawing.Size(67, 41);
            this.buttonVypocti.TabIndex = 0;
            this.buttonVypocti.Text = "Proveď";
            this.buttonVypocti.UseVisualStyleBackColor = true;
            this.buttonVypocti.Click += new System.EventHandler(this.buttonVypocti_Click);
            // 
            // chartHurst
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHurst.ChartAreas.Add(chartArea2);
            this.chartHurst.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartHurst.Legends.Add(legend2);
            this.chartHurst.Location = new System.Drawing.Point(0, 0);
            this.chartHurst.Name = "chartHurst";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartHurst.Series.Add(series2);
            this.chartHurst.Size = new System.Drawing.Size(284, 217);
            this.chartHurst.TabIndex = 1;
            this.chartHurst.Text = "chart1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartHurst);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(284, 262);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonVypocti);
            this.splitContainer2.Size = new System.Drawing.Size(284, 41);
            this.splitContainer2.SplitterDistance = 213;
            this.splitContainer2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_rovnice);
            this.panel1.Controls.Add(this.lbl_Hurst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 41);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Hurst
            // 
            this.lbl_Hurst.AutoSize = true;
            this.lbl_Hurst.Location = new System.Drawing.Point(13, 4);
            this.lbl_Hurst.Name = "lbl_Hurst";
            this.lbl_Hurst.Size = new System.Drawing.Size(97, 13);
            this.lbl_Hurst.TabIndex = 0;
            this.lbl_Hurst.Text = "Hustův exponent:  ";
            // 
            // lbl_rovnice
            // 
            this.lbl_rovnice.AutoSize = true;
            this.lbl_rovnice.Location = new System.Drawing.Point(13, 19);
            this.lbl_rovnice.Name = "lbl_rovnice";
            this.lbl_rovnice.Size = new System.Drawing.Size(89, 13);
            this.lbl_rovnice.TabIndex = 1;
            this.lbl_rovnice.Text = "Rovnice přímky: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartHurst)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVypocti;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHurst;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Hurst;
        private System.Windows.Forms.Label lbl_rovnice;
    }
}

