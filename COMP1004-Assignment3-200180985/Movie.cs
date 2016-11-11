using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1004_Assignment3_200180985
{
    class Movie
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public double Cost { get; set; }

        public System.Drawing.Image Poster { get; set; }

        public Movie(string title, string category, double cost, System.Drawing.Image poster)
        {
            this.Title = title;
            this.Category = category;
            this.Cost = cost;
            this.Poster = poster;
        }

    }
}
