using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JennyCasey_Assign6
{
    //The purpose of this class & form is the main "Home" portal where the user can click on various buttons 
    //to go see and view different charts
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //if the user clicks the "X" in the upper right corner, then exit out of the form
            this.FormClosing += Form1_FormClosing;
        }
        //Event -> when the user clicks the upper right X of the form, we will exit out of the form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //Event -> upon clicking the "Exit" button, the application will close 
        private void exitButton_Click(object sender, EventArgs e)
        {
            //close out and exit out of all hidden forms
            Environment.Exit(0);
        }
        //Event -> upon clicking the first graph/chart button, the first chart form will be loaded
        private void graph1Button_Click(object sender, EventArgs e)
        {
            //when user clicks on the first chart button, then hide the portal form and show the form for the first chart
            new Form2().Show();
            this.Hide();
        }
        //Event -> upon clicking the second graph/chart button, the second chart form will be loaded
        private void graph2Button_Click(object sender, EventArgs e)
        {
            //when user clicks on the second chart button, then hide the portal form and show the form for the first chart
            new Form3().Show();
            this.Hide();
        }
        
        //Event -> When Clicked a new form with chart 3 is presented and the portal is closed. 
        private void graph3Button_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        //Event -> When clicked a new form with chart 4 is presented and the portal is closed. 
        private void graph4Button_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

    }
}
