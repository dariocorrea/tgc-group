﻿using System;
using System.Windows.Forms;
using Los_Demoledores.Form;

namespace Los_Demoledores
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GameForm());
            Application.Run(new TwistedForm());
        }
    }
}