using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    static class ServiceInstaller
    {
        /// <summary>
        /// Installs all the Services dependencies
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static ContainerBuilder InstallServices(this ContainerBuilder builder)
        {
            return builder;
        }
    }
}
