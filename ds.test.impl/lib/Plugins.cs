using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    // абстрактный класс плагинов
    public class Plugins: PluginFactory
    {
        public Plugins()
        {
        }
        //todo сделать dictionary(приватный)
        public override IPlugin GetPlugin(string pluginName)
        {
            throw new NotImplementedException();
        }
        // фабричный метод
    }
    // создает плагин сложение
    class AdditionPlugin : BasePlugin, IPlugin
    {
        public AdditionPlugin()
        { }

        public override int Run(int input1, int input2)
        {
            return input1+input2;
        }
    }
    // создает плагин вычитание
    //public
    class SubtractionPlugin : BasePlugin, IPlugin
    {
        public SubtractionPlugin()
        {}

        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
