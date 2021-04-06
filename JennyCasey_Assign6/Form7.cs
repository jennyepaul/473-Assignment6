using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace JennyCasey_Assign6
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        private void fillChart()
        {
            string word;

            //counters in order to count the number of grades in each category
            double Agrades = 0;
            double Bgrades = 0;
            double Cgrades = 0;
            double Dgrades = 0;
            double Fgrades = 0;
            double Allgrades = 0;

            //read in the input file of grades 
            using (StreamReader inFile = new StreamReader("../../Form7Input.txt"))
            {
                //count the number of grades in each category
                //and keep track of the total number of grades in the input file
                while ((word = inFile.ReadLine()) != null)
                {
                    if (int.Parse(word) >= 90)
                    {
                        Agrades++;
                    }
                    else if (int.Parse(word) >= 80)
                    {
                        Bgrades++;
                    }
                    else if (int.Parse(word) >= 70)
                    {
                        Cgrades++;
                    }
                    else if (int.Parse(word) >= 60)
                    {
                        Dgrades++;
                    }
                    else if (int.Parse(word) < 60)
                    {
                        Fgrades++;
                    }
                    Allgrades++;
                }

                //calculate the percentages of each category
                double Apercent = (Agrades / Allgrades) * 100;
                double Bpercent = (Bgrades / Allgrades) * 100;
                double Cpercent = (Cgrades / Allgrades) * 100;
                double Dpercent = (Dgrades / Allgrades) * 100;
                double Fpercent = (Fgrades / Allgrades) * 100;

                //create a new series and select Pie as as the chart type
                Series series1 = new Series();
                series1.ChartType = SeriesChartType.Pie;

                //create five datapoints for each of the categories 
                DataPoint AGrade = new DataPoint(0D, Apercent);
                DataPoint BGrade = new DataPoint(0D, Bpercent);
                DataPoint CGrade = new DataPoint(0D, Cpercent);
                DataPoint DGrade = new DataPoint(0D, Dpercent);
                DataPoint FGrade = new DataPoint(0D, Dpercent);

                //create labels displaying the name and percentage of each category
                AGrade.Label = String.Format("A Grades ({0: 0.00}%)", Apercent);
                BGrade.Label = String.Format("B Grades ({0: 0.00}%)", Bpercent);
                CGrade.Label = String.Format("C Grades ({0: 0.00}%)", Cpercent);
                DGrade.Label = String.Format("D Grades ({0: 0.00}%)", Dpercent);
                FGrade.Label = String.Format("F Grades ({0: 0.00}%)", Fpercent);

                //add all the data points to the chart
                series1.Points.Add(AGrade);
                series1.Points.Add(BGrade);
                series1.Points.Add(CGrade);
                series1.Points.Add(DGrade);
                series1.Points.Add(FGrade);

                //add the series to the chart
                this.StudentGrades.Series.Add(series1);
            }

        }
    }
}
