using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoUm = "Esta é a primeira frase";
            string textoDois = "Esta é a segunda frase";

            string[] palavrasA = textoUm.Split(' ');
            string[] palavrasB = textoDois.Split(' ');

            IEnumerable<string> palavrasIguais = palavrasA.Intersect(palavrasB);

            Console.WriteLine(string.Join(" ", palavrasIguais));
        }
    }
}
