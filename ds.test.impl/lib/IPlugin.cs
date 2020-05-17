using System;
using System.Drawing;

namespace lib
{
    public interface IPlugin : IPluginFactory
    {
        string PluginName { get; }
        string Version { get; }
        string Description { get; }
        int Run(int input1, int input2);
    }
}
