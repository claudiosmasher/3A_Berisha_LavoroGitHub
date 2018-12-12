using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLavoroGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato = "";
            int num = 0;

            Console.WriteLine("inserisci numero da convertire:");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 1)
            {
                int resto = num % 2;
                risultato = Convert.ToString(resto) + risultato;
                num = num / 2;
            }
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"Il numero binario è {risultato}");
        }
    }
}
