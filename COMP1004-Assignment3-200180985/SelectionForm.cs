/// Program Name: Assignment 3
/// File Name: SelectionForm.cs
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
    public partial class SelectionForm : Form
    {
        private List<Movie> _movieList = new List<Movie>();

        public SelectionForm()
        {
            InitializeComponent();

            // generate new movie objects and add them to the Movie List
            _movieList.Add(new Movie("Blade Runner", "Sci-Fi, Thriller", 4.99, Properties.Resources.bladerunner));
            _movieList.Add(new Movie("D.A.R.Y.L.", "Family, Sci-Fi", 3.99, Properties.Resources.daryl));
            _movieList.Add(new Movie("The Day the Earth Stood Still", "Drama, Sci-Fi", 3.99, Properties.Resources.thedaytheearthstoodstill));
            _movieList.Add(new Movie("The Fifth Element", "Action, Adventure, Sci-Fi ", 3.99, Properties.Resources.thefifthelement));
            _movieList.Add(new Movie("Serenity", "Action, Adventure, Sci-F", 4.99, Properties.Resources.serenity));
            _movieList.Add(new Movie("Short Circuit", "Comdey, Family, Sci-Fi", 3.99, Properties.Resources.shortcircuit));
            _movieList.Add(new Movie("Stargate (1994)", "Action, Adventure, Sci-Fi", 3.99, Properties.Resources.stargate));
            _movieList.Add(new Movie("Stargate: The Ark of Truth", "Action, Adventure, Drama", 4.99, Properties.Resources.sgarkoftruth));
            _movieList.Add(new Movie("Stargate: Continuum", "Action, Adventure, Drama", 4.99, Properties.Resources.sgcontinuum));

            // populate the list box with movie titles from the movie list
            foreach (Movie movie in _movieList)
            {
                CurrentMoviesListBox.Items.Add(movie.Title);
            }

            // sort the list box of movies
            CurrentMoviesListBox.Sorted = true;
        }

        ///////////////////EVENT HANDLERS//////////////////

        /// <summary>
        /// Handler for the Next Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            this.Hide();
            orderForm.Show();
        }

        /// <summary>
        /// Handler for changing the selection in the CurrentMoviesListBox list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFormInfo();
            SetProgramInfo();

            if (CurrentMoviesListBox.Text == "")
            {
                NextButton.Enabled = false;
            }
            else
            {
                NextButton.Enabled = true;
            }
        }

       /////////////////////FUNCTIONS/////////////////////

        /// <summary>
        /// Sets form fields according to the data pulled from the movie object selected
        /// </summary>
        private void SetFormInfo()
        {
            TitleTextBox.Text = CurrentMoviesListBox.Text;

            foreach (Movie movie in _movieList)
            {
                if (movie.Title == TitleTextBox.Text)
                {
                    CategoryTextBox.Text = movie.Category;
                    CostTextBox.Text = movie.Cost.ToString("C2");
                    MovieArtPictureBox.BackgroundImage = movie.Poster;
                }
            }
        }

        /// <summary>
        /// Save information from fields to program info class to easily carry from one form
        /// to the next
        /// </summary>
        private void SetProgramInfo()
        {
            Program.info.Title = TitleTextBox.Text;
            Program.info.Category = CategoryTextBox.Text;
            Program.info.Cost = Convert.ToDouble(double.Parse(CostTextBox.Text, NumberStyles.Currency));
            Program.info.Poster = MovieArtPictureBox.BackgroundImage;
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
    }
}
