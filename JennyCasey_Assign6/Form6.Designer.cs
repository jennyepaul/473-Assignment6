namespace JennyCasey_Assign6
{
    partial class Form6
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GradesvsStudy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GradesvsStudy)).BeginInit();
            this.SuspendLayout();
            // 
            // GradesvsStudy
            // 
            chartArea1.AxisX.Title = "Hours Spent Studying";
            chartArea1.AxisY.Title = "Grades (Percentages)";
            chartArea1.Name = "ChartArea1";
            this.GradesvsStudy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GradesvsStudy.Legends.Add(legend1);
            this.GradesvsStudy.Location = new System.Drawing.Point(12, 12);
            this.GradesvsStudy.Name = "GradesvsStudy";
            this.GradesvsStudy.Size = new System.Drawing.Size(762, 426);
            this.GradesvsStudy.TabIndex = 0;
            this.GradesvsStudy.Text = "Scatter_Chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Study Time vs. Grades";
            title1.Text = "Study Time vs. Grades";
            this.GradesvsStudy.Titles.Add(title1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradesvsStudy);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form6_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GradesvsStudy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GradesvsStudy;
    }
}