using System;
using System.IO;
using System.Windows.Forms;

namespace httpExplorer
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] myargs = Environment.GetCommandLineArgs();
            //if (myargs.Length > 1){
                string decodedPath = Uri.UnescapeDataString(myargs[1]);
                string rms = decodedPath.Substring(0, decodedPath.Length - 1);
                string filePath = rms.Replace("myexplorer://", "");
                string cPath = "\"" + filePath + "\"";
                if (cPath != null)
                {
                    System.Diagnostics.Process.Start("explorer.exe", cPath);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Path Not Found");
                }
            //}
        }
    }
}
