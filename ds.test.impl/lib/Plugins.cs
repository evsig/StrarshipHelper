using System;
using System.Collections.Generic;
using System.Text;

namespace lib
{
    // абстрактный класс плагинов
    abstract class Plugins
    {
        public string Name { get; set; }


        public Plugins(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public Action Run();
    }
    // создает плагин сложение
    class AdditionPlugin : Plugins
    {
        public AdditionPlugin(string n) : base(n)
        { }

        public override Action Run()
        {
            return new AdditionAction();
        }
    }
    // создает плагин вычитание
    class SubtractionPlugin : Plugins
    {
        public SubtractionPlugin(string n) : base(n)
        { }

        public override Action Run()
        {
            return new SubtractionAction();
        }
    }
}
