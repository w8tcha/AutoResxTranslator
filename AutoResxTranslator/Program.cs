/* 
 * AutoResxTranslator
 * by Salar Khalilzadeh
 * 
 * https://github.com/salarcode/AutoResxTranslator/
 * Mozilla Public License v2
 */
namespace AutoResxTranslator
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}