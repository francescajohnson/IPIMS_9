using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPIMS_Group_9.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       /* internal static class Globals
        {
            public string currentUser;
            public string name;
        }*/

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new EPrescription());
            Application.Run(new LoggingIn());
            //Application.Run(new Reporting());
            //Application.Run(new ViewAppointments());
            //Application.Run(new Reporting());
            Application.Run(new Welcome());
        }
    }
}
