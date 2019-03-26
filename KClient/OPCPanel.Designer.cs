namespace KClient
{
    partial class OPCPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxDevice = new System.Windows.Forms.GroupBox();
            this.textBoxSin = new System.Windows.Forms.TextBox();
            this.labelSin = new System.Windows.Forms.Label();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.labelRandom = new System.Windows.Forms.Label();
            this.textBoxRamp = new System.Windows.Forms.TextBox();
            this.labelRamp = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDevice
            // 
            this.groupBoxDevice.Controls.Add(this.chart);
            this.groupBoxDevice.Controls.Add(this.textBoxSin);
            this.groupBoxDevice.Controls.Add(this.labelSin);
            this.groupBoxDevice.Controls.Add(this.textBoxRandom);
            this.groupBoxDevice.Controls.Add(this.labelRandom);
            this.groupBoxDevice.Controls.Add(this.textBoxRamp);
            this.groupBoxDevice.Controls.Add(this.labelRamp);
            this.groupBoxDevice.Location = new System.Drawing.Point(13, 3);
            this.groupBoxDevice.Name = "groupBoxDevice";
            this.groupBoxDevice.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxDevice.Size = new System.Drawing.Size(127, 234);
            this.groupBoxDevice.TabIndex = 3;
            this.groupBoxDevice.TabStop = false;
            this.groupBoxDevice.Text = "DEVICE";
            // 
            // textBoxSin
            // 
            this.textBoxSin.Location = new System.Drawing.Point(13, 118);
            this.textBoxSin.Name = "textBoxSin";
            this.textBoxSin.Size = new System.Drawing.Size(100, 20);
            this.textBoxSin.TabIndex = 5;
            // 
            // labelSin
            // 
            this.labelSin.AutoSize = true;
            this.labelSin.Location = new System.Drawing.Point(13, 102);
            this.labelSin.Name = "labelSin";
            this.labelSin.Size = new System.Drawing.Size(22, 13);
            this.labelSin.TabIndex = 4;
            this.labelSin.Text = "Sin";
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(13, 79);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(100, 20);
            this.textBoxRandom.TabIndex = 3;
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Location = new System.Drawing.Point(13, 63);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(47, 13);
            this.labelRandom.TabIndex = 2;
            this.labelRandom.Text = "Random";
            // 
            // textBoxRamp
            // 
            this.textBoxRamp.Location = new System.Drawing.Point(13, 39);
            this.textBoxRamp.Name = "textBoxRamp";
            this.textBoxRamp.Size = new System.Drawing.Size(100, 20);
            this.textBoxRamp.TabIndex = 1;
            // 
            // labelRamp
            // 
            this.labelRamp.AutoSize = true;
            this.labelRamp.Location = new System.Drawing.Point(13, 23);
            this.labelRamp.Name = "labelRamp";
            this.labelRamp.Size = new System.Drawing.Size(35, 13);
            this.labelRamp.TabIndex = 0;
            this.labelRamp.Text = "Ramp";
            // 
            // chartSin
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(13, 150);
            this.chart.Name = "chartSin";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series3";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(99, 69);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // OPCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDevice);
            this.Name = "OPCPanel";
            this.Size = new System.Drawing.Size(153, 242);
            this.groupBoxDevice.ResumeLayout(false);
            this.groupBoxDevice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.TextBox textBoxSin;
        private System.Windows.Forms.Label labelSin;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.TextBox textBoxRamp;
        private System.Windows.Forms.Label labelRamp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
