/// Program Name: Assignment 3
/// File Name: StreamForm.cs
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

    public partial class StreamForm : Form
    {
        public OrderForm previousForm { get; set; }

        public StreamForm()
        {
            InitializeComponent();

            CreditCardChargeLabel.Text = ("Your credit card will be charged " + Program.info.GrandTotalCost + ".");
            MovieWillBeginLabel.Text = (Program.info.Title + " will begin shortly.");
        }

        //////////////////EVENT HANDLERS//////////////////

        /// <summary>
        /// Handler for OK button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
