using Bakalaurs.BusinessLogic.MainManager;
using Ninject.Modules;

namespace Bakalaurs.App_Start.Bindings
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMainManager>().To<MainManager>();
        }
    }
}
