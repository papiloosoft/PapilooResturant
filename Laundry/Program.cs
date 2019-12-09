using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new log());
        }
        public class AppContext:ApplicationContext
        {
            public AppContext()
            {
                Application.Idle += new EventHandler(Application_Idle);
                //FormLogin frmlogin = new FormLogin();
                //frmlogin.Show();
                log frmLog = new log();
                frmLog.Show();
            }

            private void Application_Idle(object sender, EventArgs e)
            {
                if (Application.OpenForms.Count == 0)
                    Application.Exit();
            }
            
        }
    }
}
