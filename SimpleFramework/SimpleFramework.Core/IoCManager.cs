using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using SimpleFramework.Configuration;

namespace SimpleFramework.Core
{
    internal class IoCManager
    {
        static IoCManager _iocmanager;
        static ContainerBuilder _cbuilder;
        static IContainer _container;

        private ContainerBuilder ContainerBuilder
        {
            get
            {
                return _cbuilder ?? (_cbuilder = new ContainerBuilder());
            }
        }

        public IoCManager()
        {
            Build();
        }

        #region [ Public Properties ]

        public static IoCManager Manager
        {
            get
            {
                return _iocmanager ?? (_iocmanager = new IoCManager());
            }
        }

        public IContainer Container
        {
            get
            {
                return _container;
            }
        }

        #endregion

        #region [ Public Methods ]

        public void Build()
        {
            if (_container == null)
            {
                ScanForTypes();

                _container = ContainerBuilder.Build(Autofac.Builder.ContainerBuildOptions.None);
            }
        }

        #endregion

        #region [Private Methods]

        private void ScanForTypes()
        {
            List<string> assemblies = EuromsgConfigurationManager.GetModuleList();

            foreach (var item in assemblies)
            {
                var module = Assembly.Load(item);

                ContainerBuilder.RegisterAssemblyModules(module);

            }

        }

        #endregion
    }
}
