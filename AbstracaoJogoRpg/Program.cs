using AbstracaoJogoRpg.src.entities;
using AbstracaoJogoRpg.src.entities.classes;

namespace AbstracaoJogoRpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A classe Ninja e Hero possui comentários da lógica

            Console.WriteLine("LISTA DE HEROIS RPG CADASTRADOS ATÉ O MOMENTO:");
            var arus = new Knight("Arus",749,72);
            var wedge = new Ninja("Wedge", 574,89);
            var jenica = new Wizard("Jenica", 601, 482);
            var topapa = new Wizard("Topapa", 385, 641);
            //adiciono todos os objetos em uma lista de Objet
            var heros = new List<Object> { arus, wedge, jenica, topapa };

            //percorro toda lista imprimindo objeto por objeto
            foreach (var hero in heros)
            {
                Console.WriteLine($"{hero}");
            }
            

        }
    }
}
