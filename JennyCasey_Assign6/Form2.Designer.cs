
namespace JennyCasey_Assign6
{
    partial class Form2
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Games Played";
            chartArea1.AxisY.Interval = 75D;
            chartArea1.AxisY.Title = "Gems Acquired in Each Game";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Key:";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 61);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(895, 467);
            this.chart1.TabIndex = 0;
            // 
            // chart1ReturnButton
            // 
            this.chart1ReturnButton.Location = new System.Drawing.Point(12, 12);
            this.chart1ReturnButton.Name = "chart1ReturnButton";
            this.chart1ReturnButton.Size = new System.Drawing.Size(122, 43);
            this.chart1ReturnButton.TabIndex = 2;
            this.chart1ReturnButton.Text = "Return to Portal";
            this.chart1ReturnButton.UseVisualStyleBackColor = true;
            this.chart1ReturnButton.Click += new System.EventHandler(this.chart1ReturnButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 532);
            this.Controls.Add(this.chart1ReturnButton);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Chart 1 - Gems Acquired Each Game";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button chart1ReturnButton;
    }
}