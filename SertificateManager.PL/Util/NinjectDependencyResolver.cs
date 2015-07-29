using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using SertificateManager.BLL.Interfaces;
using SertificateManager.BLL.Services;

namespace SertificateManager.PL.Util
{
    public class NinjectDependencyResolver
    {
        private static IKernel ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            ninjectKernel = new StandardKernel(module);
            ninjectKernel.Bind<IService>().To<SertificateService>();
        }

        public static T Resolve<T>()
        {
            return ninjectKernel.Get<T>();
        }


    }
}

