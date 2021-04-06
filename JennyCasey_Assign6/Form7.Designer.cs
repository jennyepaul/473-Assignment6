
namespace JennyCasey_Assign6
{
    partial class Form7
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.StudentGrades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReturnButton7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentGrades
            // 
            chartArea2.Name = "ChartArea1";
            this.StudentGrades.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Grades";
            this.StudentGrades.Legends.Add(legend2);
            this.StudentGrades.Location = new System.Drawing.Point(12, 12);
            this.StudentGrades.Name = "StudentGrades";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.LegendText = "#LABEL";
            series2.Name = "Series1";
            this.StudentGrades.Series.Add(series2);
            this.StudentGrades.Size = new System.Drawing.Size(776, 426);
            this.StudentGrades.TabIndex = 0;
            this.StudentGrades.Text = "StudentGrades";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Student Grades";
            title2.Text = "Student Grades";
            this.StudentGrades.Titles.Add(title2);
            // 
            // ReturnButton7
            // 
            this.ReturnButton7.Location = new System.Drawing.Point(28, 24);
            this.ReturnButton7.Name = "ReturnButton7";
            this.ReturnButton7.Size = new System.Drawing.Size(137, 36);
            this.ReturnButton7.TabIndex = 1;
            this.ReturnButton7.Text = "Return To Portal";
            this.ReturnButton7.UseVisualStyleBackColor = true;
            this.ReturnButton7.Click += new System.EventHandler(this.ReturnButton7_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnButton7);
            this.Controls.Add(this.StudentGrades);
            this.Name = "Form7";
            this.Text = "Chart 4 - Student Grades";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StudentGrades;
        private System.Windows.Forms.Button ReturnButton7;
    }
}