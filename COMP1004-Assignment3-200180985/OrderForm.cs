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
        public OrderForm()
        {
            InitializeComponent();

            GetProgramInfo();
            SubTotalTextBox.Text = Program.info.Cost.ToString("C2");
            SalesTaxTextBox.Text = (Convert.ToDouble(double.Parse(CostTextBox.Text, NumberStyles.Currency)) * 0.13).ToString("C2");

        }

        /// <summary>
        /// Retrieve informaiton from program info to fill in form fields
        /// </summary>
        private void GetProgramInfo()
        {
            TitleTextBox.Text = Program.info.Title;
            CategoryTextBox.Text = Program.info.Category;
            CostTextBox.Text = Program.info.Cost.ToString("C2");
            MovieArtPictureBox.BackgroundImage = Program.info.Poster;
        }

        private void OrderDVDButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = OrderDVDButton.Checked == true ? true : false;

            DVDTextBox.Text = "$10.00";
            SubTotalTextBox.Text = (Program.info.Cost + Convert.ToDouble(double.Parse(DVDTextBox.Text, NumberStyles.Currency))).ToString("C2");

            DVDLabel.Visible = isChecked;
            DVDTextBox.Visible = isChecked;
        }
    }
}
