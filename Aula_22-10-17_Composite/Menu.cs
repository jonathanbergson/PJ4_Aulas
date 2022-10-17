using System;
using System.Collections.Generic;

namespace Aula_22_10_17_Composite
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> list = new List<MenuComponent>();
        public Menu(string n)
        {
            name = n;
        }
        public override void Add(MenuComponent comp)
        {
            list.Add(comp);
        }
        public override void Remove(MenuComponent comp)
        {
            list.Remove(comp);
        }
        public override MenuComponent getChild(int i)
        {
            return list[i];
        }
        public override string getName()
        {
            return name;
        }
        public override void Print(bool space = false)
        {
            if (space)
            {
                Console.Write("\t");
                Console.WriteLine(name);
                foreach (MenuComponent m in list)
                {
                    Console.Write("\t");
                    m.Print(true);
                }
            } 
            else
            {
                Console.WriteLine(name);
                foreach (MenuComponent m in list) m.Print(true);
            }

        }
    }
}
