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
    public partial class Form4 : Form
    {

        private static List<int> XValue = new List<int>();
        private static List<int> YValue = new List<int>();
        public Form4()
        {
            InitializeComponent();
        }
          
        private void Form4_Load_1(object sender, EventArgs e)
        {
             fillChart();
        }
        private void fillChart()
        {
            int counter = 2;
            
            string word;
            //read in the input file 
            using (StreamReader inFile = new StreamReader("../../Form4Input.txt"))
            {
                
                while ((word = inFile.ReadLine()) != null)
                {
                    //determine if the value is a x or y value and add them to list
                    if (counter % 2 == 1)
                    {
                        XValue.Add(int.Parse(word));
                    }
                    else
                    {
                        YValue.Add(int.Parse(word));
                    }
                    counter++;
                }
                //create a new series and select the chart type as point
                Series series1 = new Series();
                series1.ChartType = SeriesChartType.Point;

                //add all the data points from the input file into the chart
                for (int i = 0; i <XValue.Count(); i++)
                {                   
                    series1.Points.Add(new DataPoint(XValue[i], YValue[i]));                  
                }

                this.GradesvsStudy.Series.Add(series1);


            }
        }
    }
}
