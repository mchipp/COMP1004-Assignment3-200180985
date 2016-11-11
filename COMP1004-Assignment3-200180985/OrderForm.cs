/// Program Name: Assignment 3
/// File Name: OrderForm.cs
/// Author: Mark Chipp 200180985
/// Description: Users may pick a movie to stream online from a pre-defined list of movies.
/// Optionally they can purchase a DVD for any film offered.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment3_200180985
{
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();

            GetProgramInfo();
            SubTotalTextBox.Text = Program.info.Cost.ToString("C2");
            DVDTextBox.Text = 0.ToString("C2");
            CalculatSubTotal();
            CalculateSalesTax();
            CalculateGrandTotal();
        }

        //////////////////EVENT HANDLERS//////////////////

        /// <summary>
        /// Handles checking and unchecking the Order DVD button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderDVDButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = OrderDVDButton.Checked == true ? true : false;

            DVDTextBox.Text = isChecked ? 10.ToString("C2") : 0.ToString("C2");

            CalculatSubTotal();
            CalculateSalesTax();
            CalculateGrandTotal();

            DVDLabel.Visible = isChecked;
            DVDTextBox.Visible = isChecked;
        }

        /// <summary>
        /// Handles back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            previousForm.Show();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        //////////////////FUNCTIONS//////////////////

        /// <summary>
        /// Calculates sales tax value
        /// </summary>
        private void CalculateSalesTax()
        {
            SalesTaxTextBox.Text = (Convert.ToDouble(double.Parse(SubTotalTextBox.Text, NumberStyles.Currency)) * 0.13).ToString("C2");
        }

        /// <summary>
        /// Calculates sub total value
        /// </summary>
        private void CalculatSubTotal()
        {
            SubTotalTextBox.Text = (Program.info.Cost + Convert.ToDouble(double.Parse(DVDTextBox.Text, NumberStyles.Currency))).ToString("C2");
        }

        /// <summary>
        /// Calculates grand total value
        /// </summary>
        private void CalculateGrandTotal()
        {
            double subTotal = Convert.ToDouble(double.Parse(SubTotalTextBox.Text, NumberStyles.Currency));
            double salesTax = Convert.ToDouble(double.Parse(SalesTaxTextBox.Text, NumberStyles.Currency));
            GrandTotalTextbox.Text = (subTotal + salesTax).ToString("C2");
        }

        /// <summary>
        /// Retrieve information from program info to fill in form fields
        /// </summary>
        private void GetProgramInfo()
        {
            TitleTextBox.Text = Program.info.Title;
            CategoryTextBox.Text = Program.info.Category;
            CostTextBox.Text = Program.info.Cost.ToString("C2");
            MovieArtPictureBox.BackgroundImage = Program.info.Poster;
        }

        ////////////////EVENT HANDLERS////////////////

        /// <summary>
        /// Handler for stream button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            Stream();
        }

        /// <summary>
        /// Handler for stream menu click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream();
        }

        /// <summary>
        /// Cancel function handles shared application closing
        /// </summary>
        private void Cancel()
        {
            Application.Exit();
        }

        ////////////////FUNCTIONS////////////////

        /// <summary>
        /// Stream function handles shared stream button and menu options
        /// </summary>
        private void Stream()
        {
            StreamForm streamForm = new StreamForm();
            streamForm.previousForm = this;
            this.Hide();
            streamForm.Show();
        }
    }
}
