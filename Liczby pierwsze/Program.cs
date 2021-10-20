using System;

namespace Liczby_pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ile chcesz wypisac liczb pierwszych?");
            int ile_wypisac = int.Parse(Console.ReadLine());
            int ktora_liczba = 2;
            Console.WriteLine($"{ile_wypisac} pierwszych liczb pierwszych:");
            while (ile_wypisac > 0)
            {
                bool jest_pierwsza = true;
                for (int k = 2; k <= Math.Sqrt(ktora_liczba); k++)
                {
                    if (ktora_liczba % k == 0)
                    {
                        jest_pierwsza = false;
                        break;
                    }
                }

                if (jest_pierwsza)
                {
                    Console.WriteLine(ktora_liczba);
                    ile_wypisac--;
                }

                ktora_liczba++;
            }
        }
    }
}
