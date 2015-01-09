﻿﻿/*  
 *  Main  
 *  by Boxi Zhang 12238967 (gernerated by Visual Studio)
 *  for Assignment III, 159.212 Application Software Development Summer 2014 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rugby
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
