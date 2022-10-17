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

        public override void Print(bool space = false)
        {
            if (space) Console.Write("\t");
            Console.WriteLine(">> " + name);
        }
    }
}
