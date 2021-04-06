
namespace JennyCasey_Assign6
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "Test Taken in the Semester";
            chartArea2.AxisY.Interval = 5D;
            chartArea2.AxisY.Minimum = 50D;
            chartArea2.AxisY.Title = "Percent Retrieved on Test";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Student\'s Names";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(4, 56);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(876, 443);
            this.chart1.TabIndex = 0;
            // 
            // chart2ReturnButton
            // 
            this.chart2ReturnButton.Location = new System.Drawing.Point(13, 7);
            this.chart2ReturnButton.Name = "chart2ReturnButton";
            this.chart2ReturnButton.Size = new System.Drawing.Size(122, 43);
            this.chart2ReturnButton.TabIndex = 1;
            this.chart2ReturnButton.Text = "Return to Portal";
            this.chart2ReturnButton.UseVisualStyleBackColor = true;
            this.chart2ReturnButton.Click += new System.EventHandler(this.chart2ReturnButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 511);
            this.Controls.Add(this.chart2ReturnButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form3";
            this.Text = "Chart 2 - Percent Scored on Each Test in a Semester for Students";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button chart2ReturnButton;
    }
}