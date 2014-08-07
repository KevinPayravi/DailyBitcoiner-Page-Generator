///////////////////////////////////////////////////////////////////////////////////////////
// Program: DailyBitcoiner Page Generator
// Author: Kevin Payravi (http://www.kevinpayravi.com/
// Description: This app produces HTML code for use on DailyBitcoiner.com.
// License: Fully copyrighted. No distribution without permission.
///////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyBitcoiner_Page_Generator
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
            Application.Run(new MainForm());
        }
    }
}
