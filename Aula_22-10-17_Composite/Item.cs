using System;

namespace Aula_22_10_17_Composite
{
    public class Item : MenuComponent
    {
        public Item(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public override void Print()
        {
            Console.WriteLine(">> " + name);
        }
    }
}
