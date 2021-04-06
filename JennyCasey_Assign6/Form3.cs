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
    //This form class contains the third chart!
    public partial class Form3 : Form
    {
        public static Series StudentAPoints = new Series();
        public static Series StudentBPoints = new Series();
        public static Series StudentCPoints = new Series();
        public static Series StudentDPoints = new Series();

        public Form3()
        {
            InitializeComponent();

            //if the user clicks the "X" in the upper right corner, then go back to home portal screen!
            this.FormClosing += Form3_FormClosing;

            //read in the input file and get the data points
            ReadInfoIntoChart();

            //create 4 series, one for each student in input file
            Series series1 = StudentAPoints;
            Series series2 = StudentBPoints;
            Series series3 = StudentCPoints;
            Series series4 = StudentDPoints;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";

            //name of each series and make each line a little thicker to see better
            series1.Name = "Bob";
            series1.BorderWidth = 3;
            series2.Name = "Lara";
            series2.BorderWidth = 3;
            series3.Name = "Sara";
            series3.BorderWidth = 3;
            series4.Name = "Tony";
            series4.BorderWidth = 3;

            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            //add the series data to the chart
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);

            //title of chart
            Title title = chart1.Titles.Add("Student Scores per Test in a Semester");
        }

        //Event -> when clicked, the user will return back to the "home" portal
        private void chart2ReturnButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        //Event -> when the user clicks the upper right X of the form, we will go back to the home portal
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            //the form has been closed out, so go back to home screen
            new Form1().Show();
            this.Hide();
        }
        //Function -> the point of this function is to go through each test score/number array and populate the points for the chart
        //for each student, called in the below function "ReadInfoIntoChart"
        public Series createDataPoints(string[] info)
        {
            Series s = new Series();
            double x, y;
            //go through each student's test & score array and populate the correct values into the points for the chart
            for (int i = 0; i < info.Length; i++)
            {
                //split to find the test number and score for it
                string[] scores = info[i].Split(',');

                //test number is X and score is Y
                x = double.Parse(scores[0]);
                y = double.Parse(scores[1]);
                //StudentAPoints.Points.AddXY(studentAX, studentAY);
                s.Points.AddXY(x, y);
            }
            return s; 
        }
        //Function-> this function reads in the information from an input file and populates the chart with that info
        public void ReadInfoIntoChart()
        {
            //go to the file and extract the X and Y points
            string line;
            string StudentA, StudentB, StudentC, StudentD;
            using (StreamReader inFile = new StreamReader("../../GradePercentsOnAssigns.txt"))
            {
                while ((line = inFile.ReadLine()) != null)
                {
                    //each student is split by a tab, each test score per student is split by ":"
                    //split the lines by a comma (since input goes X,Y)
                    string[] Students= line.Split('\t');

                    //get each student's test scores
                    StudentA = Students[0];
                    StudentB = Students[1];
                    StudentC = Students[2];
                    StudentD = Students[3];

                    //now split each student by the colons since each test score is separated by that
                    string[] StudentAScores = StudentA.Split(':');
                    string[] StudentBScores = StudentB.Split(':');
                    string[] StudentCScores = StudentC.Split(':');
                    string[] StudentDScores = StudentD.Split(':');

                    //call function above to go through each student's test & score array 
                    //and populate the correct values into the points for the chart
                    StudentAPoints = createDataPoints(StudentAScores);
                    StudentBPoints = createDataPoints(StudentBScores);
                    StudentCPoints = createDataPoints(StudentCScores);
                    StudentDPoints = createDataPoints(StudentDScores);
                }
            }
        }
    }
}
