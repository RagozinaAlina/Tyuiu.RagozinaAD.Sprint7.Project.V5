namespace Tyuiu.RagozinaAD.Sprint7.Project.V5
{
    partial class FormPost
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPost));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonOpen = new Button();
            toolTip = new ToolTip(components);
            buttonSave = new Button();
            dataGridViewTab1 = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            buttonMin = new Button();
            chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonChart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartInfo).BeginInit();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(12, 22);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(97, 56);
            buttonOpen.TabIndex = 0;
            toolTip.SetToolTip(buttonOpen, "Открыть файл");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(12, 96);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 56);
            buttonSave.TabIndex = 1;
            toolTip.SetToolTip(buttonSave, "Сохранить файл");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewTab1
            // 
            dataGridViewTab1.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewTab1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTab1.ColumnHeadersVisible = false;
            dataGridViewTab1.Location = new Point(115, 22);
            dataGridViewTab1.Name = "dataGridViewTab1";
            dataGridViewTab1.RowHeadersVisible = false;
            dataGridViewTab1.RowHeadersWidth = 51;
            dataGridViewTab1.Size = new Size(312, 327);
            dataGridViewTab1.TabIndex = 2;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // buttonMin
            // 
            buttonMin.Location = new Point(470, 30);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(260, 73);
            buttonMin.TabIndex = 3;
            buttonMin.Text = "Сорт";
            buttonMin.UseVisualStyleBackColor = true;
            buttonMin.Click += buttonMin_Click;
            // 
            // chartInfo
            // 
            chartArea1.Name = "ChartArea1";
            chartInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartInfo.Legends.Add(legend1);
            chartInfo.Location = new Point(459, 109);
            chartInfo.Name = "chartInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartInfo.Series.Add(series1);
            chartInfo.Size = new Size(524, 424);
            chartInfo.TabIndex = 4;
            chartInfo.Text = "chart1";
            // 
            // buttonChart
            // 
            buttonChart.Location = new Point(134, 383);
            buttonChart.Name = "buttonChart";
            buttonChart.Size = new Size(130, 60);
            buttonChart.TabIndex = 5;
            buttonChart.Text = "button2";
            buttonChart.UseVisualStyleBackColor = true;
            buttonChart.Click += buttonChart_Click;
            // 
            // FormPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 550);
            Controls.Add(buttonChart);
            Controls.Add(chartInfo);
            Controls.Add(buttonMin);
            Controls.Add(dataGridViewTab1);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Name = "FormPost";
            Text = "Поставщики";
            Load += FormPost_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTab1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private ToolTip toolTip;
        private Button buttonSave;
        private DataGridView dataGridViewTab1;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
        private Button button1;
        private Button buttonMin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
        private Button buttonChart;
    }
}