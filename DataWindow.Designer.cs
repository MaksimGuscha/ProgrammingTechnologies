namespace WindowsFormsТrenajor
{
    partial class DataWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.humidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.workloadLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.bloodLabel = new System.Windows.Forms.Label();
            this.bloodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heartRateLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.conductivityLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heartRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.conductivityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductivityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // humidityChart
            // 
            this.humidityChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea1";
            this.humidityChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.humidityChart.Legends.Add(legend1);
            this.humidityChart.Location = new System.Drawing.Point(12, 763);
            this.humidityChart.Name = "humidityChart";
            this.humidityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.humidityChart.Series.Add(series1);
            this.humidityChart.Size = new System.Drawing.Size(550, 232);
            this.humidityChart.TabIndex = 0;
            this.humidityChart.Text = "chart1";
            this.humidityChart.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пациент:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(71, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Возраст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата обследования:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Тип физической нагрузки:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(70, 35);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(0, 13);
            this.ageLabel.TabIndex = 7;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(70, 58);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(0, 13);
            this.sexLabel.TabIndex = 8;
            // 
            // workloadLabel
            // 
            this.workloadLabel.AutoSize = true;
            this.workloadLabel.Location = new System.Drawing.Point(160, 112);
            this.workloadLabel.Name = "workloadLabel";
            this.workloadLabel.Size = new System.Drawing.Size(0, 13);
            this.workloadLabel.TabIndex = 9;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(129, 90);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 10;
            // 
            // bloodLabel
            // 
            this.bloodLabel.AutoSize = true;
            this.bloodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bloodLabel.Location = new System.Drawing.Point(13, 145);
            this.bloodLabel.Name = "bloodLabel";
            this.bloodLabel.Size = new System.Drawing.Size(254, 20);
            this.bloodLabel.TabIndex = 11;
            this.bloodLabel.Text = "Измерение кровяного давления";
            this.bloodLabel.Visible = false;
            // 
            // bloodChart
            // 
            this.bloodChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea2.Name = "ChartArea1";
            this.bloodChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.bloodChart.Legends.Add(legend2);
            this.bloodChart.Location = new System.Drawing.Point(15, 172);
            this.bloodChart.Name = "bloodChart";
            this.bloodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.bloodChart.Series.Add(series2);
            this.bloodChart.Size = new System.Drawing.Size(550, 201);
            this.bloodChart.TabIndex = 12;
            this.bloodChart.Text = "chart2";
            this.bloodChart.Visible = false;
            // 
            // heartRateLabel
            // 
            this.heartRateLabel.AutoSize = true;
            this.heartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heartRateLabel.Location = new System.Drawing.Point(12, 1329);
            this.heartRateLabel.Name = "heartRateLabel";
            this.heartRateLabel.Size = new System.Drawing.Size(361, 20);
            this.heartRateLabel.TabIndex = 13;
            this.heartRateLabel.Text = "Измерение частоты пульса сердечного ритма";
            this.heartRateLabel.Visible = false;
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.humidityLabel.Location = new System.Drawing.Point(8, 719);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(225, 20);
            this.humidityLabel.TabIndex = 14;
            this.humidityLabel.Text = "Измерение влажности кожи ";
            this.humidityLabel.Visible = false;
            // 
            // conductivityLabel
            // 
            this.conductivityLabel.AutoSize = true;
            this.conductivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conductivityLabel.Location = new System.Drawing.Point(8, 1019);
            this.conductivityLabel.Name = "conductivityLabel";
            this.conductivityLabel.Size = new System.Drawing.Size(372, 20);
            this.conductivityLabel.TabIndex = 15;
            this.conductivityLabel.Text = "Измерение электрической проводимости кожи ";
            this.conductivityLabel.Visible = false;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureLabel.Location = new System.Drawing.Point(11, 424);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(239, 20);
            this.temperatureLabel.TabIndex = 16;
            this.temperatureLabel.Text = "Измерение температуры кожи";
            this.temperatureLabel.Visible = false;
            // 
            // temperatureChart
            // 
            this.temperatureChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea3.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend3);
            this.temperatureChart.Location = new System.Drawing.Point(12, 465);
            this.temperatureChart.Name = "temperatureChart";
            this.temperatureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.temperatureChart.Series.Add(series3);
            this.temperatureChart.Size = new System.Drawing.Size(550, 232);
            this.temperatureChart.TabIndex = 17;
            this.temperatureChart.Text = "chart3";
            this.temperatureChart.Visible = false;
            // 
            // heartRateChart
            // 
            this.heartRateChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea4.Name = "ChartArea1";
            this.heartRateChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.heartRateChart.Legends.Add(legend4);
            this.heartRateChart.Location = new System.Drawing.Point(12, 1379);
            this.heartRateChart.Name = "heartRateChart";
            this.heartRateChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = "пульс";
            series4.Name = "Series1";
            this.heartRateChart.Series.Add(series4);
            this.heartRateChart.Size = new System.Drawing.Size(550, 254);
            this.heartRateChart.TabIndex = 18;
            this.heartRateChart.Text = "chart4";
            this.heartRateChart.Visible = false;
            // 
            // conductivityChart
            // 
            this.conductivityChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea5.Name = "ChartArea1";
            this.conductivityChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.conductivityChart.Legends.Add(legend5);
            this.conductivityChart.Location = new System.Drawing.Point(12, 1063);
            this.conductivityChart.Name = "conductivityChart";
            this.conductivityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.conductivityChart.Series.Add(series5);
            this.conductivityChart.Size = new System.Drawing.Size(550, 243);
            this.conductivityChart.TabIndex = 19;
            this.conductivityChart.Text = "chart5";
            this.conductivityChart.Visible = false;
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conductivityChart);
            this.Controls.Add(this.heartRateChart);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.conductivityLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.heartRateLabel);
            this.Controls.Add(this.bloodChart);
            this.Controls.Add(this.bloodLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.workloadLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humidityChart);
            this.Name = "DataWindow";
            this.Text = "DataWindow";
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductivityChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart humidityChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label workloadLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label bloodLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart bloodChart;
        private System.Windows.Forms.Label heartRateLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label conductivityLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart heartRateChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart conductivityChart;
    }
}