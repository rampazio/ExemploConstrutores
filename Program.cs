

using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Leonardo", "Buta" );
            p1.Apresentar();
        }
    }
}



