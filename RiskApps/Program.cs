//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="CCH">
//     Copyright (c) 2014 CCH. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace RiskApps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}