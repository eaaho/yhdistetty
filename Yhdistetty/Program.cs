using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yhdistetty
{
    class Program
    {
        static void Main(string[] args)
        {
            string Viesti = string.Empty;
            int Numero;
            Console.Write("Annappa luku: ");
            bool Tulos = int.TryParse(Console.ReadLine(), out Numero);

            if (!Tulos)
            {
                Viesti = "Luku ei ole numero.";
            }
            else if (Numero % 2 == 0)
            {
                if (Numero >= 0)
                {
                    Viesti = "Luku " + Numero.ToString() + " on parillinen ja positiivinen.";
                }
                else if (Numero < 0)
                {
                    Viesti = "Luku " + Numero.ToString() + " on parillinen ja negatiivinen.";
                }
            }

            if (Numero % 2 == 1 || Numero % 2 == -1)
            {
                if (Numero >= 0)
                {
                    Viesti = "Luku " + Numero.ToString() + " on pariton ja positiivinen.";
                }
                else
                {
                    Viesti = "Luku " + Numero.ToString() + " on pariton ja negatiivinen.";
                }

            }
            Console.WriteLine(Viesti);
            Console.ReadLine();
        }
    }
}

