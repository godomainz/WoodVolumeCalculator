using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // Open App.Config of executable
            //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);    
            // Add an Application Setting.
            //config.AppSettings.Settings.Remove("connectionString");
            //config.AppSettings.Settings.Add("connectionString", "provider=MySql.Data.MySqlClient;provider connection string=&quot;server=localhost;User Id=root;database=san;password=123&quot;");
        // Save the configuration file.
            //config.Save(ConfigurationSaveMode.Modified);
        // Force a reload of a changed section.
            //ConfigurationManager.RefreshSection("appSettings");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
