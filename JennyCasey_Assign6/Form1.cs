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
        }

        //Event -> upon clicking the "Exit" button, the application will close 
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void graph1Button_Click(object sender, EventArgs e)
        {
            //when user clicks on the first chart button, then hide the portal form and show the form for the first chart
            new Form2().Show();
            this.Hide();
        }

        private void graph2Button_Click(object sender, EventArgs e)
        {
            //when user clicks on the second chart button, then hide the portal form and show the form for the first chart
            new Form3().Show();
            this.Hide();
        }
    }
}
