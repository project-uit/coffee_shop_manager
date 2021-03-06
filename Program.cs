﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFEE_SHOP_MANAGER
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            CultureInfo culture = CultureInfo.CreateSpecificCulture("vi");

            // The following line provides localization for the application's user interface.  
            Thread.CurrentThread.CurrentUICulture = culture;

            // The following line provides localization for data formats.  
            Thread.CurrentThread.CurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }


        public static bool IsInDesignMode()
        {
            if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
            {
                return true;
            }
            return false;
        }
    }
}
