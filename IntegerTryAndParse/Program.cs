// Chad Weirick
// Estimates:
// UI: 15 minutes
// Code: 30 minutes
// Test: 15 minutes
// Document/upload/submit: 1 hour
// MA539
//
// Purpose: 
// test 2 different ways to handle the exception
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerTryAndParse
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
