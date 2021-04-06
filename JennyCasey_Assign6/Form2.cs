using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace JennyCasey_Assign6
{
    //This class is the Form that will contain the first chart!
    public partial class Form2 : Form
    {
        public Series chart1filePoints = new Series();

        public Form2()
        {
            InitializeComponent();

            //if the user clicks the "X" in the upper right corner, then go back to home portal screen!
            this.FormClosing += Form2_FormClosing;

            //get info for series
            Series series1 = ReadInfoIntoChart();
            series1.ChartArea = "ChartArea1";
            this.chart1.Series.Add(ReadInfoIntoChart());
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Legend = "Legend1";
            series1.Name = "Gems Acquired";
            Title title = chart1.Titles.Add("Gems Acquired in Game Bar Graph");

        }

        //Event -> when clicked, the user will return back to the "home" portal
        private void chart1ReturnButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        //Event -> when the user clicks the upper right X of the form, we will go back to the home portal
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //the form has been closed out, so go back to home screen
            new Form1().Show();
            this.Hide();
        }

        //Function-> this function reads in the information from an input file and populates the chart with that info
        public Series ReadInfoIntoChart()
        {
            //go to the file and extract the X and Y points
            string line;
            using (StreamReader inFile = new StreamReader("../../LoLMinionKills.txt"))
            {
                while ((line = inFile.ReadLine()) != null)
                {
                    //split the lines by a comma (since input goes X,Y)
                    string[] chartInfo = line.Split(',');

                    //parse it to double
                    double X = double.Parse(chartInfo[0]);
                    double Y = int.Parse(chartInfo[1]);

                    //add the points
                    chart1filePoints.Points.AddXY(X, Y);
                }
            }
            return chart1filePoints;
        }

    }
}
