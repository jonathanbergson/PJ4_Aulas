namespace Aula_22_10_17_Composite
{
    public abstract class MenuComponent
    {
        protected string name;
        public virtual void Add(MenuComponent comp) { }
        public virtual void Remove(MenuComponent comp) { }
        public virtual MenuComponent getChild(int i) { return null; }
        public virtual string getName() { return ""; }
        public virtual void Print(bool space = false) { }
    }
}
