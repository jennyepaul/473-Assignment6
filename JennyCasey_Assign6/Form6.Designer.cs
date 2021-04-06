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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GradesvsStudy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ReturnButton6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GradesvsStudy)).BeginInit();
            this.SuspendLayout();
            // 
            // GradesvsStudy
            // 
            chartArea3.AxisX.Title = "Hours Spent Studying";
            chartArea3.AxisY.Title = "Grades (Percentages)";
            chartArea3.Name = "ChartArea1";
            this.GradesvsStudy.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GradesvsStudy.Legends.Add(legend3);
            this.GradesvsStudy.Location = new System.Drawing.Point(12, 12);
            this.GradesvsStudy.Name = "GradesvsStudy";
            this.GradesvsStudy.Size = new System.Drawing.Size(776, 426);
            this.GradesvsStudy.TabIndex = 0;
            this.GradesvsStudy.Text = "Scatter_Chart";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Study Time vs. Grades";
            title3.Text = "Study Time vs. Grades";
            this.GradesvsStudy.Titles.Add(title3);
            // 
            // ReturnButton6
            // 
            this.ReturnButton6.Location = new System.Drawing.Point(28, 12);
            this.ReturnButton6.Name = "ReturnButton6";
            this.ReturnButton6.Size = new System.Drawing.Size(149, 36);
            this.ReturnButton6.TabIndex = 1;
            this.ReturnButton6.Text = "Return To Portal";
            this.ReturnButton6.UseVisualStyleBackColor = true;
            this.ReturnButton6.Click += new System.EventHandler(this.ReturnButton6_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnButton6);
            this.Controls.Add(this.GradesvsStudy);
            this.Name = "Form6";
            this.Text = "Chart 3 - Study Time vs. Grades";
            this.Load += new System.EventHandler(this.Form6_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GradesvsStudy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GradesvsStudy;
        private System.Windows.Forms.Button ReturnButton6;
    }
}