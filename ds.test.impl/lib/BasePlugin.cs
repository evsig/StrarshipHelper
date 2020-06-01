using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace lib
{
    internal abstract class BasePlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        public string Description { get; }
        public Image Image { get; }
        public abstract int Run(int input1, int input2);
    }
}
