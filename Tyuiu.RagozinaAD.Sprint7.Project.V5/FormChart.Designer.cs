namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonChart = new Button();
            chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartInfo).BeginInit();
            SuspendLayout();
            // 
            // buttonChart
            // 
            buttonChart.Location = new Point(20, 20);
            buttonChart.Name = "buttonChart";
            buttonChart.Size = new Size(142, 58);
            buttonChart.TabIndex = 0;
            buttonChart.Text = "button1";
            buttonChart.UseVisualStyleBackColor = true;
            buttonChart.Click += buttonChart_Click;
            // 
            // chartInfo
            // 
            chartArea1.Name = "ChartArea1";
            chartInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartInfo.Legends.Add(legend1);
            chartInfo.Location = new Point(21, 89);
            chartInfo.Name = "chartInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartInfo.Series.Add(series1);
            chartInfo.Size = new Size(472, 318);
            chartInfo.TabIndex = 1;
            chartInfo.Text = "chart1";
            // 
            // FormChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chartInfo);
            Controls.Add(buttonChart);
            Name = "FormChart";
            Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)chartInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
    }
}