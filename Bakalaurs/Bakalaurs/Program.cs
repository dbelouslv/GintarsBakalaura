using Bakalaurs.App_Start.Bindings;
using Bakalaurs.BusinessLogic.MainManager;
using Ninject;
using System;
using System.Windows.Forms;

namespace Bakalaurs
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            StandardKernel kernel = new StandardKernel(new Bindings());
            var _mainManager = kernel.Get<IMainManager>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(_mainManager));
        }
    }
}
