using System;
using System.Drawing;

namespace lib
{
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        string Description { get; }
        Image Image { get; }
        int Run(int input1, int input2);
    }
}
