/// Program Name: Assignment 3
/// File Name: MovieInfo.cs
/// Author: Mark Chipp 200180985
/// Created: 7-Nov-2016
/// Description: Users may pick a movie to stream online from a pre-defined list of movies.
/// Optionally they can purchase a DVD for any film offered.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_Assignment3_200180985
{
    //////////////////CLASSES//////////////////

    class MovieInfo
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public double Cost { get; set; }

        public System.Drawing.Image Poster { get; set; }

        public string GrandTotalCost { get; set; }
    }
}
