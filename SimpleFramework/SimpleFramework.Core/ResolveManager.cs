using Autofac;

namespace SimpleFramework.Core
{
    public static class ResolveManager
    {
        public static T ResoveInstance<T>()
        {
            return IoCManager.Manager.Container.Resolve<T>();
        }
    }
}
