using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    public abstract class PluginFactory
    {
        public int PluginsCount { get; }
        public string[] GetPluginsNames { get; }
        public abstract IPlugin GetPlugin(string pluginName);
    }
}
