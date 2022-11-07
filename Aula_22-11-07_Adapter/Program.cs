using System;

namespace Aula_22_11_07_Adapter
{
    public interface ICarro
    {
        void MoverEmRua();
    }
    public interface ITrem
    {
        void MoverEmTrilho();
    }
    public class Ford : ICarro
    {
        public void MoverEmRua()
        {
            Console.WriteLine("Mover carro");
        }
    }
    public class Metro : ITrem
    {
        public virtual void MoverEmTrilho()
        {
            Console.WriteLine("Mover trem");
        }
    }

    public class CarroAdapter : Metro
    {
        ICarro carro;
        public CarroAdapter(ICarro carro)
        {
            this.carro = carro;
        }
        public override void MoverEmTrilho()
        {
            carro.MoverEmRua();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Ford k = new Ford();
            k.MoverEmRua();
            Metro m = new CarroAdapter(k);
            m.MoverEmTrilho();
        }
    }
}
