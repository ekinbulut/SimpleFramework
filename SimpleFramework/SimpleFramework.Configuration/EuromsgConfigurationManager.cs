using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SimpleFramework.Configuration
{
    [Serializable]
    public static class EuromsgConfigurationManager
    {
        public static List<string> GetModuleList()
        {
            var json = File.ReadAllText("appsettings.json", System.Text.Encoding.UTF8);

            var config = JsonConvert.DeserializeObject<ModuleConfig>(json);

            return config.Modules;
        }

    }
}
