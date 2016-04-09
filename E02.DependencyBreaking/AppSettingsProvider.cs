using E03.DependencyBreaking.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.DependencyBreaking
{
    class AppSettingsProvider : IAppSettingsProvider
    {
        public object GetAppSetting(string settingName)
        {
            return ConfigurationManager.AppSettings[settingName];
        }
    }
}
