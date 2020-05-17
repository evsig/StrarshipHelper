using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    public interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginsNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
