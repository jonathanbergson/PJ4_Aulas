using System;

namespace Aula_22_10_17_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu arquivo = new Menu("Arquivo"); 
            Menu editar = new Menu("Editar"); 
            Menu ajuda = new Menu("Ajuda");
            Menu muitaAjuda = new Menu("Realmente Preciso de Ajuda");

            Item novo = new Item("Novo");
            Item salvar = new Item("Salvar"); 
            Item copiar = new Item("Copiar"); 
            Item colar = new Item("Colar");
            Item introducao = new Item("Introdução");

            arquivo.Add(novo);
            arquivo.Add(salvar);
            arquivo.Add(ajuda);
            
            editar.Add(copiar);
            editar.Add(colar);

            ajuda.Add(introducao);
            ajuda.Add(muitaAjuda);
            
            arquivo.Print();
            Console.WriteLine();
            editar.Print();
        }
    }
}
