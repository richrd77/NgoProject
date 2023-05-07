using Application.Repositories;
using Application.Services;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class AppInstaller
    {
        public static ContainerBuilder InstallApplication(this ContainerBuilder builder)
        {
            builder.InstallServices();
            builder.InstallRepositories();
            return builder;
        }
    }
}
