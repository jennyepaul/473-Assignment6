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

namespace JennyCasey_Assign6
{
    //This class is the Form that will contain the first chart!
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //if the user clicks the "X" in the upper right corner, then go back to home portal screen!
            this.FormClosing += Form2_FormClosing;

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

    }
}
