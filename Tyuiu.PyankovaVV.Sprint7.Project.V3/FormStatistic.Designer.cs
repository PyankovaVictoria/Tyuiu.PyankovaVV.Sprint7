
namespace Tyuiu.PyankovaVV.Sprint7.Project.V3
{
    partial class FormStatistic
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunction_PVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOen_PVV = new System.Windows.Forms.Button();
            this.groupBoxFirstSum_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxFirst_PVV = new System.Windows.Forms.TextBox();
            this.groupBoxThirdSum_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxThird_PVV = new System.Windows.Forms.TextBox();
            this.groupBoxSecondSum_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxSecond_PVV = new System.Windows.Forms.TextBox();
            this.toolTip_PVV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_PVV = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PVV)).BeginInit();
            this.groupBoxFirstSum_PVV.SuspendLayout();
            this.groupBoxThirdSum_PVV.SuspendLayout();
            this.groupBoxSecondSum_PVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartFunction_PVV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_PVV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_PVV.Legends.Add(legend1);
            this.chartFunction_PVV.Location = new System.Drawing.Point(453, 12);
            this.chartFunction_PVV.Name = "chartFunction_PVV";
            this.chartFunction_PVV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_PVV.Series.Add(series1);
            this.chartFunction_PVV.Size = new System.Drawing.Size(300, 300);
            this.chartFunction_PVV.TabIndex = 0;
            this.chartFunction_PVV.Text = "chart1";
            // 
            // buttonOen_PVV
            // 
            this.buttonOen_PVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonOen_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOen_PVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.buttonOen_PVV.Location = new System.Drawing.Point(55, 72);
            this.buttonOen_PVV.Name = "buttonOen_PVV";
            this.buttonOen_PVV.Size = new System.Drawing.Size(122, 69);
            this.buttonOen_PVV.TabIndex = 1;
            this.buttonOen_PVV.Text = "Выберите файл";
            this.toolTip_PVV.SetToolTip(this.buttonOen_PVV, "Выберите, нужный файл, \r\nчтобы посмотреть элементы статистики");
            this.buttonOen_PVV.UseVisualStyleBackColor = false;
            this.buttonOen_PVV.Click += new System.EventHandler(this.buttonOen_PVV_Click);
            // 
            // groupBoxFirstSum_PVV
            // 
            this.groupBoxFirstSum_PVV.Controls.Add(this.textBoxFirst_PVV);
            this.groupBoxFirstSum_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxFirstSum_PVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.groupBoxFirstSum_PVV.Location = new System.Drawing.Point(13, 162);
            this.groupBoxFirstSum_PVV.Name = "groupBoxFirstSum_PVV";
            this.groupBoxFirstSum_PVV.Size = new System.Drawing.Size(200, 100);
            this.groupBoxFirstSum_PVV.TabIndex = 2;
            this.groupBoxFirstSum_PVV.TabStop = false;
            this.groupBoxFirstSum_PVV.Text = "Кол-во преподователей 1-ой кафедры";
            // 
            // textBoxFirst_PVV
            // 
            this.textBoxFirst_PVV.Location = new System.Drawing.Point(6, 59);
            this.textBoxFirst_PVV.Name = "textBoxFirst_PVV";
            this.textBoxFirst_PVV.Size = new System.Drawing.Size(188, 22);
            this.textBoxFirst_PVV.TabIndex = 0;
            // 
            // groupBoxThirdSum_PVV
            // 
            this.groupBoxThirdSum_PVV.Controls.Add(this.textBoxThird_PVV);
            this.groupBoxThirdSum_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxThirdSum_PVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.groupBoxThirdSum_PVV.Location = new System.Drawing.Point(230, 162);
            this.groupBoxThirdSum_PVV.Name = "groupBoxThirdSum_PVV";
            this.groupBoxThirdSum_PVV.Size = new System.Drawing.Size(200, 100);
            this.groupBoxThirdSum_PVV.TabIndex = 2;
            this.groupBoxThirdSum_PVV.TabStop = false;
            this.groupBoxThirdSum_PVV.Text = "Кол-во преподователей 3-ей кафедры";
            // 
            // textBoxThird_PVV
            // 
            this.textBoxThird_PVV.Location = new System.Drawing.Point(6, 59);
            this.textBoxThird_PVV.Name = "textBoxThird_PVV";
            this.textBoxThird_PVV.Size = new System.Drawing.Size(188, 22);
            this.textBoxThird_PVV.TabIndex = 0;
            // 
            // groupBoxSecondSum_PVV
            // 
            this.groupBoxSecondSum_PVV.Controls.Add(this.textBoxSecond_PVV);
            this.groupBoxSecondSum_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSecondSum_PVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.groupBoxSecondSum_PVV.Location = new System.Drawing.Point(230, 56);
            this.groupBoxSecondSum_PVV.Name = "groupBoxSecondSum_PVV";
            this.groupBoxSecondSum_PVV.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSecondSum_PVV.TabIndex = 2;
            this.groupBoxSecondSum_PVV.TabStop = false;
            this.groupBoxSecondSum_PVV.Text = "Кол-во преподователей 2-ой кафедры";
            // 
            // textBoxSecond_PVV
            // 
            this.textBoxSecond_PVV.Location = new System.Drawing.Point(6, 54);
            this.textBoxSecond_PVV.Name = "textBoxSecond_PVV";
            this.textBoxSecond_PVV.Size = new System.Drawing.Size(188, 22);
            this.textBoxSecond_PVV.TabIndex = 0;
            // 
            // toolTip_PVV
            // 
            this.toolTip_PVV.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_PVV
            // 
            this.openFileDialog_PVV.FileName = "openFileDialog1";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(766, 333);
            this.Controls.Add(this.groupBoxSecondSum_PVV);
            this.Controls.Add(this.groupBoxThirdSum_PVV);
            this.Controls.Add(this.groupBoxFirstSum_PVV);
            this.Controls.Add(this.buttonOen_PVV);
            this.Controls.Add(this.chartFunction_PVV);
            this.Name = "FormStatistic";
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PVV)).EndInit();
            this.groupBoxFirstSum_PVV.ResumeLayout(false);
            this.groupBoxFirstSum_PVV.PerformLayout();
            this.groupBoxThirdSum_PVV.ResumeLayout(false);
            this.groupBoxThirdSum_PVV.PerformLayout();
            this.groupBoxSecondSum_PVV.ResumeLayout(false);
            this.groupBoxSecondSum_PVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PVV;
        private System.Windows.Forms.Button buttonOen_PVV;
        private System.Windows.Forms.GroupBox groupBoxFirstSum_PVV;
        private System.Windows.Forms.GroupBox groupBoxThirdSum_PVV;
        private System.Windows.Forms.GroupBox groupBoxSecondSum_PVV;
        private System.Windows.Forms.ToolTip toolTip_PVV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PVV;
        private System.Windows.Forms.TextBox textBoxFirst_PVV;
        private System.Windows.Forms.TextBox textBoxThird_PVV;
        private System.Windows.Forms.TextBox textBoxSecond_PVV;
    }
}