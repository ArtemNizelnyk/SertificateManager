using SertificateManager.BLL.Infrastructure;
using SertificateManager.PL.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SertificateManager.PL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NinjectDependencyResolver.Wire(new ServiceModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(NinjectDependencyResolver.Resolve<HomeForm>());
        }
    }
    public static class Data
    {
        public delegate void SearchEvent(string data);
        public static SearchEvent SearchEventHandler;
        public delegate void CreateEvent(SertificateManager.BLL.DTO.SertificateDTO stfM);
        public static CreateEvent CreateEventHandler;
    }
}
