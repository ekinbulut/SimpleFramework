using System.IO;
using System.Linq;
using System.Reflection;
using SimpleFramework.Configuration;

namespace SimpleFramework.Core.Data
{
    using Autofac;    

    public class DataTierModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var dir = AssemblyInstaller.AssemblyDirectory;

            var assemblies = Directory.GetFiles(dir).Where(x=>x.Contains("Data") && x.Contains("dll"));

            foreach (var assembly in assemblies)
            {
                var dataAccess = Assembly.LoadFrom(assembly);

                builder.RegisterAssemblyTypes(dataAccess)
                    .Where(t => t.Name.EndsWith("Repository")).AsSelf()
                    .AsImplementedInterfaces();

                base.Load(builder);
            }


            
        }
    }
}
