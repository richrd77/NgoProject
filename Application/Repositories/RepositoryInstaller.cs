using Autofac;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    static class RepositoryInstaller
    {
        /// <summary>
        /// Installs all the Repository dependencies
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static ContainerBuilder InstallRepositories(this ContainerBuilder builder)
        {
            builder.RegisterType<NgoDbContext>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerLifetimeScope();
            return builder;
        }
    }
}
