using System;
using SimpleFramework.Core;

namespace SimpleFramework
{
    public static class Resolver
    {
        public static T ResoveInstance<T>()
        {
            return ResolveManager.ResoveInstance<T>();
        }
    }
}
