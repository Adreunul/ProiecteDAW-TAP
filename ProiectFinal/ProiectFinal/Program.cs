﻿using ProiectFinal.ImaginiPacienti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectFinal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormPacienti());
            //Application.Run(new FormInternari());
            //Application.Run(new FormServicii());
            Application.Run(new FormStart());
        }
    }
}
