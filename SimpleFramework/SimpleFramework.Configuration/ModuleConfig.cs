using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFramework.Configuration
{
    [Serializable]
    internal class ModuleConfig
    {
        public List<string> Modules { get; set; }
    }
}
