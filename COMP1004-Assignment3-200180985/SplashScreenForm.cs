/// Program Name: Assignment 3
/// File Name: SplashScreenForm.cs
/// Author: Mark Chipp 200180985
/// Created: 7-Nov-2016
/// Description: Users may pick a movie to stream online from a pre-defined list of movies.
/// Optionally they can purchase a DVD for any film offered.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment3_200180985
{
    //////////////////CLASSES//////////////////

    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }


        //////////////////EVENT HANDLERS//////////////////

        /// <summary>
        /// Handles the splash screen timer on tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            // disable this timer
            SplashScreenTimer.Enabled = false;

            // instantiate new StreamForm
            SelectionForm nextForm = new SelectionForm();

            // hide the splash screen
            this.Hide();

            // show the streaming form
            nextForm.Show();
        }
    }
}
