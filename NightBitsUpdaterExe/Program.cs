using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace NightBitsUpdaterExe
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new NightBitsUpdaterExe());
            }
            catch (Exception exception)
            {
                var file = new StreamWriter(new FileInfo(Assembly.GetEntryAssembly().Location).Directory + "\\runtimeError.txt");

                file.WriteLine(exception.Message);

                if (exception.InnerException != null)
                {
                    file.WriteLine("Inner Exception: ");
                    file.WriteLine(exception.InnerException.Message);

                    if (exception.InnerException.StackTrace != null)
                    {
                        file.WriteLine(exception.InnerException.StackTrace);
                    }
                }
                file.Close();
            }
        }
    }
}