/// Program Name: Assignment 3
/// File Name: Program.cs
/// Author: Mark Chipp 200180985
/// Description: Main Program file for assignment three, runs a new SplashScreenForm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment3_200180985
{
    static class Program
    {
        // declare new info object to store movie info across frames
        public static MovieInfo info;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // instantiate new info object
            info = new MovieInfo();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreenForm());
        }
    }
}
